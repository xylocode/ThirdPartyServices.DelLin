using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.LTL.Res
{
    public class BookItem
    {
        /// <summary>
        /// ID нового/отредактированного объекта адресной книги
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }


        /// <summary>
        /// Статус объекта.
        /// Возможные значения:
        /// "existing" - отредактированы данные существующего объекта;
        /// "new" - создан новый объект
        /// </summary>
        [JsonPropertyName("state")]
        public string State { get; set; }


        /// <summary>
        /// Номер телефона(в случае объекта "phoneNumbers") / имя контактного лица(в случае объекта "contactPersons")
        /// Отсутствует у объектов "counteragent" и "address".
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }

    }
}