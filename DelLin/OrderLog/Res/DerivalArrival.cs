using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.OrderLog.Res
{
    public class DerivalArrival
    {
        /// <summary>
        /// Город отправки/доставки груза.
        /// </summary>
        [JsonPropertyName("city")]
        public string City { get; set; }


        /// <summary>
        /// ID города отправления/прибытия.
        /// </summary>
        [JsonPropertyName("cityId")]
        public int? CityId { get; set; }


        /// <summary>
        /// Код КЛАДР города, см. "Поиск населённых пунктов".
        /// </summary>
        [JsonPropertyName("cityCode")]
        public string CityCode { get; set; }


        /// <summary>
        /// Адрес отправки/доставки груза.
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }


        /// <summary>
        /// Код КЛАДР улицы, см. "Поиск улиц".
        /// </summary>
        [JsonPropertyName("addressCode")]
        public string AddressCode { get; set; }


        /// <summary>
        /// Наименование терминала хранения
        /// </summary>
        [JsonPropertyName("terminalName")]
        public string TerminalName { get; set; }


        /// <summary>
        /// Адрес терминала хранения
        /// </summary>
        
        [JsonPropertyName("terminalAddress")]
        public string TerminalAddress { get; set; }


        /// <summary>
        /// ID терминала-отправителя/получателя из "Справочника терминалов".
        /// </summary>
        [JsonPropertyName("terminalId")]
        public string TerminalId { get; set; }


        /// <summary>
        /// Город терминала хранения.
        /// </summary>
        [JsonPropertyName("terminalCity")]
        public string TerminalCity { get; set; }


        /// <summary>
        /// Долгота и широта терминала хранения.
        /// </summary>
        [JsonPropertyName("terminalCoordinates")]
        public double?[] TerminalCoordinates { get; set; }


        /// <summary>
        /// Email терминала хранения.
        /// </summary>
        [JsonPropertyName("terminalEmail")]
        public string TerminalEmail { get; set; }


        /// <summary>
        /// Телефон терминала хранения.
        /// </summary>
        [JsonPropertyName("terminalPhones")]
        public string TerminalPhones { get; set; }


        /// <summary>
        /// Телефон кол-центра
        /// </summary>
        [JsonPropertyName("callCenterPhones")]
        public string CallCenterPhones { get; set; }


        /// <summary>
        /// График работы терминала хранения (график выдачи груза).
        /// </summary>
        [JsonPropertyName("terminalWorktables")]
        public TerminalWorktables TerminalWorktables { get; set; }


        /// <summary>
        /// График работы терминала хранения в праздничные дни.
        /// </summary>
        [JsonPropertyName("specialWorktable")]
        public SpecialWorktable SpecialWorktable { get; set; }


        /// <summary>
        /// Город.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }


        /// <summary>
        /// Код КЛАДР города, см. метод "Поиск населённых пунктов".
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }
    }

}