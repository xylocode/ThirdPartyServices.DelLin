using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Security.Cryptography;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Unicode;
using XyloCode.ThirdPartyServices.DelLin.Helpers;
using XyloCode.ThirdPartyServices.DelLin.Models;
using XyloCode.ThirdPartyServices.DelLin.OrderStatus.Req;
using XyloCode.ThirdPartyServices.DelLin.OrderStatus.Res;
using XyloCode.ThirdPartyServices.DelLin.Requests;
using XyloCode.ThirdPartyServices.DelLin.Responses;

namespace XyloCode.ThirdPartyServices.DelLin
{
    public class DellinClient
    {
        private const string baseUri = "https://api.dellin.ru";

        private readonly string appKey;
        private readonly HttpClient httpClient;
        private readonly JsonSerializerOptions jso;
        private string sessionId = string.Empty;
        private long expiresIn = 0;

        public DellinClient(
            string appKey,
            string baseUri = baseUri,
            HttpMessageHandler httpMessageHandler = null,
            bool disposeHandler = true)
        {
            this.appKey = appKey;
            if (httpMessageHandler is null)
                httpClient = new HttpClient();
            else
                httpClient = new HttpClient(httpMessageHandler, disposeHandler);

            httpClient.BaseAddress = new Uri(baseUri);

            jso = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                //PropertyNamingPolicy = new JsonSnakeCaseNamingPolicy(),
            };

            jso.Converters.Add(new Helpers.DateTimeConverter());
            jso.Converters.Add(new Helpers.DateOnlyConverter());
            jso.Converters.Add(new Helpers.NTimeOnlyConverter());
            jso.Converters.Add(new Helpers.TimeOnlyConverter());
        }


        #region Вспомогательные методы
        private TRes Send<TRes>(string path, bool sessionRequired = false)
            where TRes : class
        {
            var req = new Request(appKey);
            if (sessionRequired)
            {
                if (DateTime.Now.Ticks > expiresIn)
                    SetSession();
                req.SessionId = sessionId;
            }

            var res = httpClient
                .PostAsJsonAsync(path, req, jso)
                .Result;

            return res
                .Content
                .ReadFromJsonAsync<TRes>(jso)
                .Result;
        }


        private TRes Send<TRes, TReq>(string path, TReq req, bool sessionRequired = false)
            where TRes : class
            where TReq : Request
        {
            req.AppKey = appKey;
            if (sessionRequired)
            {
                if (DateTime.Now.Ticks > expiresIn)
                    SetSession();
                req.SessionId = sessionId;
            }

            var res = httpClient
                .PostAsJsonAsync(path, req, jso)
                .Result;

            return res
                .Content
                .ReadFromJsonAsync<TRes>(jso)
                .Result;
        }


        private static MemoryStream GetFile(string path, string hash)
        {
            var httpClient = new HttpClient
            {
                Timeout = new TimeSpan(0, 10, 0),
            };
            var hashAlgorithm = SHA256.Create();

            MemoryStream ms;
            HttpResponseMessage res;

            const int maxAttemps = 3;
            int attemptNumber = 0;

            while (true)
            {
                attemptNumber++;

                res = httpClient
                    .GetAsync(path)
                    .Result;

                if (!res.IsSuccessStatusCode)
                {
                    if (attemptNumber < maxAttemps)
                        continue;
                    else
                        throw new Exception($"[{res.StatusCode}]: {res.ReasonPhrase}.");
                }

                ms = new MemoryStream();
                res.Content.ReadAsStream().CopyTo(ms);
                ms.Position = 0;
                var hashStr = string.Concat(hashAlgorithm.ComputeHash(ms).Select(x => x.ToString("x2")));

                if (hash != hashStr)
                {
                    if (attemptNumber < maxAttemps)
                    {
                        ms.Dispose();
                        continue;
                    }
                    else throw new Exception("Хеш-код данных не соответствует запрашиваемому!");
                }
                ms.Position = 0;
                return ms;
            }
        }
        #endregion Вспомогательные методы


        #region Авторизация
        /// <summary>
        /// Авторизация пользователя
        /// </summary>
        /// <param name="login">В качестве логина можно использовать как email, так и номер телефона. Формат номера телефона: "+7XXXXXXXXXX" - 12 символов, начиная с "+7".</param>
        /// <param name="password">Пароль от Личного кабинета.</param>
        public void Login(string login, string password)
        {
            var req = new LoginRequest
            {
                Login = login,
                Password = password
            };
            var res = Send<Response<Login>, LoginRequest>("/v3/auth/login.json", req);
            sessionId = res.Data.SessionId;
            expiresIn = -1;
            SetSession();
        }

        /// <summary>
        /// Авторизация с использованием существующего идентификатора сессии.
        /// </summary>
        /// <param name="sessionId">ID сессии для запросов к данным Личного кабинета.</param>
        /// <param name="expiresIn">Дата окончания действия сессии.</param>
        public void SetSession(string sessionId, DateTime expiresIn)
        {
            this.sessionId = sessionId;
            this.expiresIn = expiresIn.Ticks;
        }

        public void SetSession(string sessionId, long expiresInTicks)
        {
            this.sessionId = sessionId;
            this.expiresIn = expiresInTicks;
        }

        private void SetSession()
        {
            if (expiresIn == 0)
                throw new Exception("Необходимо выполнить авторизацию в системе перед вызовом методов.");

            var res = GetSession();

            if (res.Errors is not null)
                throw new Exception(res.Errors.First().Detail);

            var now = res.MetaData.GeneratedAt;
            var exp = res.Data.Session.ExpireTime;

            if (now.HasValue && exp.HasValue)
            {
                var diff = (exp.Value - now.Value).TotalSeconds;
                expiresIn = DateTime.Now.AddSeconds(diff).Ticks;
            }
            else expiresIn = 0;
        }

        /// <summary>
        /// Данные сессии
        /// Отслеживание состояния текущей сессии можно использовать для предварительного возобновления сессии перед отправкой запроса к API Личного Кабинета.
        /// </summary>
        /// <param name="sessionId"></param>
        private Response<SessionResponse> GetSession()
        {
            var req = new Request { SessionId = sessionId };
            return Send<Response<SessionResponse>, Request>("/v3/auth/session_info.json", req, false);
        }

        /// <summary>
        /// Удаление сессии авторизации
        /// </summary>
        /// <returns>Статус обработки запроса. Возможное значение - "success" (операция успешно завершена)</returns>
        public Response<StateResponse> Logout()
        {
            if (string.IsNullOrWhiteSpace(sessionId) || DateTime.Now.Ticks > expiresIn)
                throw new Exception("Сессия завершена, либо отсутствует");
         
            var result = Send<Response<StateResponse>>("/v3/auth/logout.json", true);
            expiresIn = 0;
            return result;
        }

        /// <summary>
        /// Получить полную информацию о контрагентах, связанных с одной учетной записи в ЛК
        /// </summary>
        /// <param name="id">UID контрагента, от имени которого должны создаваться заявки в рамках текущей сессии. Параметр позволяет изменить контрагента, выбранного по умолчанию, на другого контрагента</param>
        /// <param name="fullInfo">	Флаг, обозначающий, что запрошена полная информация по контрагентам, а также информация по взаиморасчётам</param>
        /// <returns></returns>
        public Response<Organizations.Res.OrganizationsResponse> GetOrganizations(Guid? id = null, bool? fullInfo = null)
        {
            var req = new Organizations.Req.OrganizationsRequest
            {
                OrganizationId = id,
                FullInfo = fullInfo,
            };
            return Send<Response<Organizations.Res.OrganizationsResponse>, Organizations.Req.OrganizationsRequest>
                ("/v2/counteragents.json", req, true);
        }
        #endregion Авторизация


        #region Выполнение расчета
        /// <summary>
        /// Метод позволяет получить подробную информацию о стоимости и сроках интересующего способа перевозки
        /// </summary>
        public Response<Calc1.Res.CalculationResponse> Calculation(Calc1.Req.CalculationRequest req)
        {
            return Send<Response<Calc1.Res.CalculationResponse>, Calc1.Req.CalculationRequest>
                ("/v2/calculator.json", req, true);
        }


        /// <summary>
        /// Метод позволяет рассчитать стоимость услуги "Доставка до адреса" для активной перевозки.
        /// </summary>
        public Calc2.Res.CalculationResponse CalculationDirect(Calc2.Req.CalculationRequest req)
        {
            return Send<Calc2.Res.CalculationResponse, Calc2.Req.CalculationRequest>
                ("/v1/public/calculator_sf.json", req, true);
        }


        /// <summary>
        /// Метод позволяет получить информацию об ориентировочной стоимости и сроках перевозки
        /// </summary>
        public Response<Calc3.Res.CalculationResponse> CalculationRough(Calc3.Req.CalculationRequest req)
        {
            return Send<Response<Calc3.Res.CalculationResponse>, Calc3.Req.CalculationRequest>
                ("/v1/micro_calc.json", req, true);
        }
        #endregion Выполнение расчета


        #region Оформление заявок
        /// <summary>
        /// Перевозка сборных грузов.
        /// Метод предназначен для оформления заказа/предзаказа на доставку грузов.
        /// Метод доступен как авторизованным, так и не авторизованным пользователям.
        /// Авторизованные пользователи могут использовать данные адресной книги, а также сохранять в адресную книгу данные, вводимые при создании заявки.
        /// </summary>
        public Response<LTL.Res.LtlResponse> NewLtlOrder(LTL.Req.LtlRequest req)
        {
            return Send<Response<LTL.Res.LtlResponse>, LTL.Req.LtlRequest>
                ("/v2/request.json", req, expiresIn > 0);
        }
        #endregion Оформление заявок


        #region Информация по заказам
        /// <summary>
        /// Метод позволяет получать актуальную информацию о заказах, используя номер заказа компании "Деловые Линии", номер накладной или заявки, внутренний номер заказа интернет-магазина или штрих-код документа.
        /// Авторизованные пользователи при помощи данного метода также могут получить журнал отправок личного кабинета, в том числе актуальные статусы заказов, заявок и накладных.
        /// </summary>

        public OrderLog.Res.OrderLogResponse GetOrderLog(OrderLog.OrderLogRequest req)
        {
            return Send<OrderLog.Res.OrderLogResponse, OrderLog.OrderLogRequest>
                ("/v3/orders.json", req, expiresIn > 0);
        }


        /// <summary>
        /// Метод позволяет получать историю изменения статусов заказов.
        /// </summary>
        public Response<OrderStatusResponse> GetOrderStatuses (OrderStatusRequest req)
        {
            return Send<Response<OrderStatusResponse>, OrderStatusRequest>
                ("/v3/orders/statuses_history.json", req);
        }


        /// <summary>
        /// Метод позволяет получать историю изменения статусов заказов.
        /// </summary>
        /// <param name="list">Номер заказа, накладной или заявки. Возможна передача нескольких параметров. Максимум может быть передано 5 значений.</param>
        public Response<OrderStatusResponse> GetOrderStatuses(params string[] list)
        {
            if (list is null)
                throw new ArgumentNullException(nameof(list));
            var req = new OrderStatusRequest { DocIds = list.ToList() };
            return Send<Response<OrderStatusResponse>, OrderStatusRequest>
                ("/v3/orders/statuses_history.json", req);
        }
        #endregion


        #region Терминалы
        /// <summary>
        /// Список городов и терминалов
        /// </summary>
        public CitiesAndTerminals.FileModel.CitiesAndTerminalsFileModel GetCitiesAndTerminals()
        {
            var file = Send<FileResponse>("/v3/public/terminals.json");
            var ms = GetFile(file.URL, file.Hash);
            return JsonSerializer.Deserialize<CitiesAndTerminals.FileModel.CitiesAndTerminalsFileModel>(ms, jso);
        }
        #endregion Терминалы


        #region Географические справочники
        /// <summary>
        /// Метод для поиска страны.
        /// Подбор осуществляется только в том случае, если в запросе передан один параметр.
        /// Если в запросе передано несколько параметров, то ответе приводится полный список стран.
        /// </summary>
        /// <param name="searchString">Часть названия страны. Используется для подбора результата по началу строки.</param>
        public Response<List<Country>> GetCountries(string searchString = null)
        {
            var req = new FilterRequest(searchString);
            return Send<Response<List<Country>>, FilterRequest>
                ("/v1/references/countries.json", req);
        }


        /// <summary>
        /// Список городов.
        /// </summary>
        public IEnumerable<City> GetCities()
        {
            var file = Send<FileResponse>("/v1/public/places.json");
            var ms = GetFile(file.URL, file.Hash);
            var headers = new string[] { "cityID", "name", "code", "searchString", "regname", "regcode", "zonname", "zoncode" };
            var csv = new CsvData(ms, headers);
            while (csv.Read())
            {
                yield return new City
                {
                    CityID = int.Parse(csv[0]),
                    Name = csv[1],
                    Code = csv[2],
                    SearchString = csv[3],
                    RegName = csv[4],
                    RegCode = csv[5],
                    ZoneName = csv[6],
                    ZoneCode = csv[7],
                };
            }
        }

        /// <summary>
        /// Справочник улиц.
        /// </summary>
        public IEnumerable<Street> GetStreets()
        {
            var file = Send<FileResponse>("/v1/public/streets.json");
            var ms = GetFile(file.URL, file.Hash);
            var headers = new string[] { "code", "cityID", "searchString", "name" };
            var csv = new CsvData(ms, headers);
            while (csv.Read())
            {
                yield return new Street
                {
                    Code = csv[0],
                    CityID = int.Parse(csv[1]),
                    SearchString= csv[2],
                    Name = csv[3],
                };
            }
        }


        /// <summary>
        /// Справочник населенных пунктов с ограничениями по оплате.
        /// Данный справочник содержит перечень городов, в которых недоступна оплата наличными/банковской картой, оплатить услуги в этих городах можно только посредством банковского перевода.
        /// </summary>
        public IEnumerable<CityCashlessOnly> GetCitiesCashlessOnly()
        {
            var file = Send<FileResponse>("/v1/public/cities_cashless_only.json");
            var ms = GetFile(file.URL, file.Hash);
            var headers = new string[] { "cityID", "code" };
            var csv = new CsvData(ms, headers);
            while (csv.Read())
            {
                yield return new CityCashlessOnly
                {
                    CityId = int.Parse(csv[0]),
                    Code = csv[1],
                };
            }
        }
        #endregion Географические справочники


        #region Справочники
        /// <summary>
        /// Справочник дополнительных услуг
        /// </summary>
        public IEnumerable<RequestService> RequestServices()
        {
            var file = Send<FileResponse>("/v1/public/request_services.json");
            var ms = GetFile(file.URL, file.Hash);
            var headers = new string[] { "id", "uid", "name" };
            var csv = new CsvData(ms, headers);
            while (csv.Read())
            {
                yield return new RequestService
                {
                    Id = int.Parse(csv[0]),
                    UID = csv[1],
                    Name = csv[2],
                };
            }
        }


        /// <summary>
        /// Характер груза
        /// </summary>
        public IEnumerable<FreightType> GetFreightTypes()
        {
            var file = Send<FileResponse>("/v1/public/freight_types.json");
            var ms = GetFile(file.URL, file.Hash);
            var headers = new string[] { "uid", "description" };
            var csv = new CsvData(ms, headers);
            while (csv.Read())
            {
                yield return new FreightType
                {
                    UID = csv[0],
                    Description = csv[1],
                };
            }
        }


        /// <summary>
        /// Документы для получения груза
        /// </summary>
        public IEnumerable<DocumentsForReceive> GetDocumentsForReceive()
        {
            var file = Send<FileResponse>("/v1/public/documents_for_receive.json");
            var ms = GetFile(file.URL, file.Hash);
            var headers = new string[] { "uid", "name", "day_to_day" };
            var csv = new CsvData(ms, headers);
            while (csv.Read())
            {
                yield return new DocumentsForReceive
                {
                    UID = csv[0],
                    Name = csv[1],
                    OneDay = csv[2],
                };
            }
        }


        /// <summary>
        /// Справочник параметров для статистического отчета
        /// </summary>
        public IEnumerable<ReportParams> GetReportParams()
        {
            var file = Send<FileResponse>("/v1/public/report_params.json");
            var ms = GetFile(file.URL, file.Hash);
            var headers = new string[] { "name", "caption" };
            var csv = new CsvData(ms, headers);
            while (csv.Read())
            {
                yield return new ReportParams
                {
                    Name = csv[0],
                    Caption = csv[1],
                };
            }
        }


        /// <summary>
        /// Справочник видов загрузки
        /// </summary>
        public Response<List<BaseItem>> GetLoadTypes()
        {
            return Send<Response<List<BaseItem>>>("/v1/references/load_types.json");
        }


        /// <summary>
        /// Справочник специальных требований к транспорту
        /// </summary>
        public Response<List<BaseItem>> GetTransportServices()
        {
            return Send<Response<List<BaseItem>>>("/v1/references/services.json");
        }


        /// <summary>
        /// Справочник видов упаковки
        /// </summary>
        public Response<List<Package>> GetPackages()
        {
            return Send<Response<List<Package>>>("/v1/references/packages.json");
        }


        /// <summary>
        /// Справочник статусов заказа груза
        /// </summary>
        public Response<List<Status>> GetStatuses()
        {
            return Send<Response<List<Status>>>("/v1/references/packages.json");
        }

        /// <summary>
        /// Типы событий
        /// </summary>
        public Response<List<WebhookEvent>> GetWebhookEvents()
        {
            return Send<Response<List<WebhookEvent>>>("/v1/webhooks/events.json");
        }
        #endregion Справочники


        #region Самостоятельная маркировка груза

        /// <summary>
        /// Маркировка грузовых мест.
        /// Передача артикулов грузовых мест.
        /// </summary>
        public Response<StateResponse> PostShipmentLabelsRequest(ShipmentLabels.PostShipmentLabelsRequest req)
        {
            return Send<Response<StateResponse>, ShipmentLabels.PostShipmentLabelsRequest>
                ("/v2/request/cargo/shipment_labels.json", req, true);
        }


        /// <summary>
        /// Получение этикеток на груз.
        /// Чтобы сгенерировать этикетки на груз, необходимо предварительно передать информацию по грузовым местам заказа при помощи метода "Передача артикулов грузовых мест".
        /// </summary>
        public Response<ShipmentLabels.GetShipmentLabelsResponse> GetShipmentLabels(ShipmentLabels.GetShipmentLabelsRequest req)
        {
            return Send<Response<ShipmentLabels.GetShipmentLabelsResponse>, ShipmentLabels.GetShipmentLabelsRequest>
                ("/v2/request/cargo/shipment_labels/get.json", req, true);
        }


        /// <summary>
        /// Справочник этикеток с манипуляционными знаками.
        /// </summary>
        public Response<List<Mark>> GetHandlingMarks()
        {
            return Send<Response<List<Mark>>>
                ("/v1/references/marking/handling_marks.json", true);
        }


        /// <summary>
        /// Метод позволяет получить информацию о существующих этикетках с типами упаковки, а также сформировать файлы с этикетками для печати.
        /// </summary>
        public Response<List<Mark>> GetPackagingMarks()
        {
            return Send<Response<List<Mark>>>
                ("/v1/references/marking/packaging_marks.json", true);
        }


        /// <summary>
        /// Получение этикеток типов упаковки
        /// </summary>
        public Response<List<Mark>> GetPackagingMarks(PackagingMarks.PackagingMarksRequest req)
        {
            return Send<Response<List<Mark>>, PackagingMarks.PackagingMarksRequest>
                ("/v1/references/marking/packaging_marks/get.json", req, true);
        }
        #endregion Самостоятельная маркировка груза
    }
}
