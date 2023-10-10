using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.Calc2.Req
{
    public class CalculationRequest : Requests.Request
    {
        /// <summary>
        /// Номер дома
        /// </summary>
        [JsonPropertyName("arrivalHouse")]
        public string ArrivalHouse { get; set; }

        /// <summary>
        /// Код КЛАДР пункта прибытия груза.Может быть указан код КЛАДР города или улицы.
        /// Код КЛАДР может быть получен с помощью сервисов, представленных на странице "Поиск КЛАДР"
        /// </summary>
        [JsonPropertyName("arrivalPoint")]
        [Required]
        public string ArrivalPoint { get; set; }


        /// <summary>
        /// UID накладной.
        /// Для получения идентификатора накладной необходимо воспользоваться методом "Журнал заказов"
        /// </summary>
        [JsonPropertyName("docSQLUid")]
        [Required]
        public Guid DocSQLUid { get; set; }


        /// <summary>
        /// Дата прибытия груза.
        /// Если параметр не передан, то используется текущая дата
        /// </summary>
        [JsonPropertyName("calculateDate")]
        public DateOnly? CalculateDate { get; set; }


        /// <summary>
        /// Период времени доставки груза
        /// </summary>
        [JsonPropertyName("arrivalPeriodVisit")]
        public ArrivalPeriodVisit ArrivalPeriodVisit { get; set; }


        /// <summary>
        /// UID дополнительных услуг для доставки груза до адреса.
        /// Заполняется на основании "Справочника услуг ПРР".
        /// Пользователь может одновременно заказать несколько дополнительных услуг, но не все имеющиеся доп. услуги.
        /// Стоимость доп. услуг включается в стоимости доставки от/до адреса
        /// </summary>
        [JsonPropertyName("arrivalServices")]
        public List<Guid> ArrivalServices { get; set; }


        /// <summary>
        /// Фиксированное время доставки груза.
        /// Если передано значение "true", то значение параметра "arrivalPeriodVisit.end" игнорируется, вместо него используется значение("arrivalPeriodVisit.start" + 30 минут).
        /// Значение по умолчанию: "false". Параметр требует передачи в запросе arrivalPeriodVisit, иначе возникает ошибка: "Требуется передать параметр 'arrivalperiodvisit'".
        /// </summary>
        [JsonPropertyName("arrivalFixedTimeVisit")]
        public bool? ArrivalFixedTimeVisit { get; set; }


        /// <summary>
        /// Заказ разгрузки ТС.
        /// Содержит дополнительные параметры, необходимые для расчета погрузо-разгрузочных работ
        /// </summary>
        [JsonPropertyName("arrivalUnLoading")]
        public List<ArrivalUnLoading> ArrivalUnLoading { get; set; }


        /// <summary>
        /// Промокод
        /// </summary>
        [JsonPropertyName("promocode")]
        public string Promocode { get; set; }


        [JsonPropertyName("requester")]
        public int? Requester { get; set; }
    }
}
