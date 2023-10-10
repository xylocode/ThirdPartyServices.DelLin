using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.OrderLog.Res
{
    public class Member
    {
        /*
        /// <summary>
        /// Организационно-правовая форма ОПФ.
        /// </summary>
        [JsonPropertyName("opf")]
        public LegalForm Opf { get; set; }
        */

        /// <summary>
        /// UID ОПФ, см. метод "Поиск ОПФ".
        /// </summary>
        [JsonPropertyName("opfUid")]
        public string OpfUid { get; set; }


        /// <summary>
        /// Наименование контрагента.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }


        /// <summary>
        /// Адрес контрагента.
        /// Параметр используется только для объектов "response.orders.sender", "response.orders.receiver".
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }


        /// <summary>
        /// Флаг "Физическое лицо".
        /// </summary>
        [JsonPropertyName("isPhysical")]
        public bool? IsPhysical { get; set; }


        /// <summary>
        /// ИНН юр.лица.
        /// </summary>
        [JsonPropertyName("inn")]
        public string Inn { get; set; }


        /// <summary>
        /// Вид документа физ.лица.
        /// Возможные значения:
        /// "Паспорт РФ";
        /// "Загранпаспорт";
        /// "Водительское удостоверение"
        /// </summary>
        [JsonPropertyName("documentType")]
        public string DocumentType { get; set; }


        /// <summary>
        /// Серия документа физ. лица.
        /// </summary>
        [JsonPropertyName("documentSeries")]
        public string DocumentSeries { get; set; }


        /// <summary>
        /// Номер документа физ.лица.
        /// </summary>
        [JsonPropertyName("documentNumber")]
        public string DocumentNumber { get; set; }


        /// <summary>
        /// UID контрагента.
        /// </summary>
        [JsonPropertyName("counteragentUid")]
        public string CounteragentUid { get; set; }


        /// <summary>
        /// ФИО контактного лица отправителя.
        /// </summary>
        [JsonPropertyName("contacts")]
        public string Contacts { get; set; }


        /// <summary>
        /// Телефон контрагента
        /// Параметр используется только для объекта "response.orders.sender".
        /// </summary>
        [JsonPropertyName("phones")]
        public string Phones { get; set; }


        /// <summary>
        /// Признак контрагента с минимальным набором данных - "анонимного" получателя.
        /// </summary>
        [JsonPropertyName("IsAnonym")]
        public bool? IsAnonym {  get; set; }


        /// <summary>
        /// Телефон "анонимного" получателя
        /// </summary>
        [JsonPropertyName("anonymEmail")]
        public string AnonymEmail { get; set; }


        /// <summary>
        /// Телефон "анонимного" получателя
        /// </summary>
        [JsonPropertyName("anonymPhone")]
        public string AnonymPhone { get; set; }
    }
}