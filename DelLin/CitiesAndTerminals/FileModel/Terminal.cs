using System.Collections.Generic;
using System.Text.Json.Serialization;
using XyloCode.ThirdPartyServices.DelLin.Helpers;

namespace XyloCode.ThirdPartyServices.DelLin.CitiesAndTerminals.FileModel
{
    public class Terminal
    {
        /// <summary>
        /// ID терминала в системе
        /// </summary>
        [JsonPropertyName("id")]
        [JsonConverter(typeof(JsonStringAsIntConverter))]
        public int Id { get; set; }

        public int? CityId {  get; set; }

        /// <summary>
        /// Наименование терминала
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }


        /// <summary>
        /// Адрес терминала
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }


        /// <summary>
        /// Полный адрес терминала
        /// </summary>
        [JsonPropertyName("fullAddress")]
        public string FullAddress { get; set; }


        /// <summary>
        /// Широта терминала
        /// </summary>
        [JsonPropertyName("latitude")]
        [JsonConverter(typeof(JsonStringAsNFloatConverter))]
        public float? Latitude { get; set; }


        /// <summary>
        /// Долгота терминала
        /// </summary>
        [JsonPropertyName("longitude")]
        [JsonConverter(typeof(JsonStringAsNFloatConverter))]
        public float? Longitude { get; set; }


        /// <summary>
        /// Список телефонных номеров
        /// </summary>
        [JsonPropertyName("phones")]
        public List<Phone> Phones { get; set; }


        /// <summary>
        /// В настоящий момент параметр присутствует в ответе, но не используется.
        /// </summary>
        [JsonPropertyName("isPVZ")]
        public bool? IsPVZ { get; set; }


        /// <summary>
        /// Признак работы терминала только в режиме офиса.
        /// </summary>
        [JsonPropertyName("isOffice")]
        public bool? IsOffice { get; set; }


        /// <summary>
        /// Признак работы терминала на приём груза.
        /// </summary>
        [JsonPropertyName("receiveCargo")]
        public bool? ReceiveCargo { get; set; }


        /// <summary>
        /// Признак работы терминала на выдачу груза
        /// </summary>
        [JsonPropertyName("giveoutCargo")]
        public bool? GiveoutCargo { get; set; }


        /// <summary>
        /// Признак работы терминала в режиме 3PL-склада.
        /// </summary>
        [JsonPropertyName("storage")]
        public bool? Storage { get; set; }


        /// <summary>
        /// Электронная почта
        /// </summary>
        [JsonPropertyName("mail")]
        public string Mail { get; set; }


        /// <summary>
        /// Признак доступности оплаты наложенным платежом на терминале.
        /// </summary>
        [JsonPropertyName("cashOnDelivery")]
        public bool? CashOnDelivery { get; set; }


        /// <summary>
        /// Терминал на карте.
        /// </summary>
        [JsonPropertyName("maps")]
        public Maps Maps { get; set; }


        /// <summary>
        /// Информация о коде КЛАДР адреса терминала.
        /// </summary>
        [JsonPropertyName("addressCode")]
        public AddressCode AddressCode { get; set; }


        /// <summary>
        /// Расписание работы терминала.
        /// </summary>
        [JsonPropertyName("calcSchedule")]
        public CalcSchedule CalcSchedule { get; set; }


        /// <summary>
        /// Признак терминала по умолчанию для города.
        /// </summary>
        [JsonPropertyName("default")]
        public bool? Default { get; set; }


        /// <summary>
        /// Максимально допустимый объем груза.
        /// </summary>
        [JsonPropertyName("maxVolume")]
        public double? MaxVolume { get; set; }


        /// <summary>
        /// Максимально допустимый вес груза.
        /// </summary>
        [JsonPropertyName("maxWeight")]
        public double? MaxWeight { get; set; }


        /// <summary>
        /// Максимально допустимая высота груза.
        /// </summary>
        [JsonPropertyName("maxHeight")]
        public double? MaxHeight { get; set; }


        /// <summary>
        /// Максимально допустимая ширина груза.
        /// </summary>
        [JsonPropertyName("maxWidth")]
        public double? MaxWidth { get; set; }


        /// <summary>
        /// Максимально допустимая длина груза.
        /// </summary>
        [JsonPropertyName("maxLength")]
        public double? MaxLength { get; set; }


        /// <summary>
        /// Расписание работы отделов терминала.
        /// </summary>
        [JsonPropertyName("worktables")]
        public Worktables Worktables { get; set; }
    }
}
