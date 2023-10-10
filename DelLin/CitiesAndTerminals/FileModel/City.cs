using System;
using System.Text.Json.Serialization;
using XyloCode.ThirdPartyServices.DelLin.Helpers;

namespace XyloCode.ThirdPartyServices.DelLin.CitiesAndTerminals.FileModel
{
    public class City
    {
        /// <summary>
        /// ID города в системе
        /// </summary>
        [JsonPropertyName("id")]
        [JsonConverter(typeof(JsonStringAsIntConverter))]
        public int Id { get; set; }


        /// <summary>
        /// Наименование города
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }


        /// <summary>
        /// Код КЛАДР города
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }


        /// <summary>
        /// ID города, см. "Поиск населённых пунктов"
        /// </summary>
        [JsonPropertyName("cityID")]
        public int? CityID { get; set; }


        /// <summary>
        /// Широта города
        /// </summary>
        [JsonPropertyName("latitude")]
        [JsonConverter(typeof(JsonStringAsNFloatConverter))]
        public float? Latitude { get; set; }


        /// <summary>
        /// Долгота города
        /// </summary>
        [JsonPropertyName("longitude")]
        [JsonConverter(typeof(JsonStringAsNFloatConverter))]
        public float? Longitude { get; set; }


        /// <summary>
        /// Домен для города
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }


        /// <summary>
        /// Смещение времени в часах относительно Москвы
        /// </summary>
        [JsonPropertyName("timeshift")]
        public string Timeshift { get; set; }


        /// <summary>
        /// Время окончания приёма заявок на забор груза от адреса.
        /// Позже этого времени заявка переносится на следующий день.
        /// </summary>
        [JsonPropertyName("requestEndTime")]
        public TimeOnly? RequestEndTime { get; set; }


        /// <summary>
        /// Время окончания приёма заявок на доставку до адреса.
        /// Позже этого времени заявка переносится на следующий день.
        /// </summary>
        [JsonPropertyName("sfrequestEndTime")]
        public TimeOnly? SfrequestEndTime { get; set; }


        /// <summary>
        /// Признак возможности оформить заявку на забор груза от адреса день-в-день в данном подразделении ("1" - да, "0" - нет)
        /// </summary>
        [JsonPropertyName("day2dayRequest")]
        [JsonConverter(typeof(JsonStringAsNBooleanConverter))]
        public bool? Day2dayRequest { get; set; }


        /// <summary>
        /// Признак возможности оформить заявку на доставку груза до адреса день-в-день в данном подразделении ("1" - да, "0" - нет)
        /// </summary>
        [JsonPropertyName("day2daySFRequest")]
        [JsonConverter(typeof(JsonStringAsNBooleanConverter))]
        public bool? Day2daySFRequest { get; set; }

        /// <summary>
        /// Признак возможности оформить предзаказ в данном подразделении("1" - да, "0" - нет)
        /// </summary>
        [JsonPropertyName("preorderRequest")]
        [JsonConverter(typeof(JsonStringAsNBooleanConverter))]
        public bool? PreorderRequest { get; set; }


        /// <summary>
        /// Количество дней бесплатного хранения в данном подразделении
        /// </summary>
        [JsonPropertyName("freeStorageDays")]
        [JsonConverter(typeof(JsonStringAsNIntConverter))]
        public int? FreeStorageDays { get; set; }


        /// <summary>
        /// Информация о терминалах в городе
        /// </summary>
        [JsonPropertyName("terminals")]
        public Terminals Terminals { get; set; }
    }
}