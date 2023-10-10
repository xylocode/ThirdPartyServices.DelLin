using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.LTL.Res
{
    public class Member
    {
        /// <summary>
        /// Данные контрагента
        /// </summary>
        [JsonPropertyName("counteragent")]
        public BookItem Counteragent { get; set; }


        /// <summary>
        /// Данные об адресе
        /// </summary>
        [JsonPropertyName("address")]
        public BookItem Address { get; set; }


        /// <summary>
        /// Список контактных лиц
        /// </summary>
        [JsonPropertyName("contactPersons")]
        public List<BookItem> ContactPersons { get; set; }


        /// <summary>
        /// Список телефонных номеров
        /// </summary>
        [JsonPropertyName("phoneNumbers")]
        public List<BookItem> PhoneNumbers { get; set; }

    }
}