using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using XyloCode.ThirdPartyServices.DelLin.Enums;

namespace XyloCode.ThirdPartyServices.DelLin.LTL.Req
{
    /// <summary>
    /// Отправка/получение
    /// </summary>
    public class DerivalArrival
    {
        /// <summary>
        /// Дата выполнения заказа.
        /// Формат: "ГГГГ-ММ-ДД"
        /// Используется только для параметра "request.delivery.derival"
        /// </summary>
        [JsonPropertyName("produceDate")]
        public DateOnly? ProduceDate { get; set; }


        /// <summary>
        /// Дополнительные параметры доставки груза от адреса.
        /// Параметр используется для только для объекта "request.delivery.derival"
        /// </summary>
        [JsonPropertyName("pickupParams")]
        public PickupParams PickupParams { get; set; }


        /// <summary>
        /// Способ доставки груза.
        /// Возможные значения:
        /// "address" - доставка груза непосредственно от адреса отправителя/до адреса получателя. Примечание.При заказе перевозки малогабаритного груза(значение параметра запроса "delivery.deliverуType.type" - "small") доставка от/до терминала невозможна;
        /// "terminal" - доставка груза от/до терминала;
        /// "airport" - доставка груза до аэропорта, вариант используется, если в городе, в который необходимо доставить груз, нет терминала "Деловых Линий", в этом случае груз можно получить в грузовом терминале в аэропорту.
        /// Примечание. Вариант используется только для объекта "request.delivery.arrival" и только при заказе авиаперевозки (значение параметра запроса "delivery.deliverуType.type" - "avia"). При заказе доставки груза до аэропорта следует передать параметр "city", передача параметров "terminalID", "addressID", "address" невозможна
        /// </summary>
        [JsonPropertyName("variant")]
        public ArrivalEndpoint? Variant { get; set; }



        /// <summary>
        /// Плательщик по услуге.
        /// Доступные значения:
        /// "sender" - отправитель;
        /// "receiver" - получатель;
        /// "third" - третье лицо.
        /// Если параметр не передан, то он принимает значение параметра "request.payment.primaryPayer"
        /// </summary>
        [JsonPropertyName("payer")]
        public RoleType? Payer { get; set; }


        /// <summary>
        /// ID терминала отправки/доставки груза из "Справочника терминалов".
        /// Заполняется при расчете стоимости предзаказа
        /// Допускается передача только одного из следующих параметров: "terminalID", "addressID", "address", "city"
        /// </summary>
        [JsonPropertyName("terminalID")]
        public Guid? TerminalID { get; set; }


        /// <summary>
        /// ID адреса отправителя/получателя из адресной книги Личного кабинета(подробнее см. сервис "Адреса").
        /// Заполняется в случае, если клиенту необходим расчёт для адреса, сохранённого в Личном Кабинете
        /// Допускается передача только одного из следующих параметров: "terminalID", "addressID", "address", "city"
        /// </summary>
        [JsonPropertyName("addressID")]
        public int? AddressID { get; set; }


        /// <summary>
        /// Адрес
        /// Допускается передача только одного из следующих параметров: "terminalID", "addressID", "address", "city"
        /// </summary>
        [JsonPropertyName("address")]
        public Address Address { get; set; }


        /// <summary>
        /// Код КЛАДР города. Может быть получен с помощью сервисов, представленных на странице "Поиск КЛАДР".
        /// Используется только для параметра "request.delivery.arrival".
        /// Передача параметра невозможна, только если заказана доставка до адреса (значение параметра "variant" - "address").
        /// Допускается передача только одного из следующих параметров: "terminalID", "addressID", "address", "city"
        /// </summary>
        [JsonPropertyName("city")]
        public string City { get; set; }


        /// <summary>
        /// Заезд на второй адрес
        /// </summary>
        [JsonPropertyName("additionalAddress")]
        public Address AdditionalAddress { get; set; }

        /// <summary>
        /// Время передачи груза отправителем/получателю на адресе.
        /// Параметр является обязательным, если выбрана доставка от адреса/до адреса (значение параметра "variant" - "address")
        /// </summary>
        [JsonPropertyName("time")]
        public Time Time { get; set; }


        /// <summary>
        /// Погрузо-разгрузочные работы на адресе.
        /// Необязательный параметр, при его отсутствии расчёт производится без учёта стоимости услуги
        /// </summary>
        [JsonPropertyName("handling")]
        public Handling Handling { get; set; }


        /// <summary>
        /// Дополнительные требования к транспорту: доступные виды загрузки машины (боковая, задняя и пр.), а также другие требования - манипулятор, растентовка и пр.
        /// Указываются UID'ы из "Справочника специальных требований к транспорту" и "Справочника видов загрузки".
        /// Возможна передача нескольких значений
        /// </summary>
        [JsonPropertyName("requirements")]
        public List<Guid> Requirements { get; set; }


        /// <summary>
        /// Телефон для SMS-уведомлений.
        /// Формат номера: "7ХХХХХХХХХХ" (11 цифр с ведущей семёркой).
        /// </summary>
        [JsonPropertyName("smsback")]
        public string SmsBack { get; set; }


        /// <summary>
        /// Комментарий к заказу.
        /// Максимальная длина поля: 500 символов
        /// </summary>
        [JsonPropertyName("comment")]
        public string Comment { get; set; }
  }
}
