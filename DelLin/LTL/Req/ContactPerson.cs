using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.LTL.Req
{
    public class ContactPerson
    {
        public ContactPerson() { }
        public ContactPerson(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Имя контактного лица
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }


        /// <summary>
        /// Признак сохранения объекта в адресную книгу.
        /// Значение по умолчанию: "false".
        /// Параметр игнорируется для третьего лица.
        /// Параметр игнорирутся для неавторизованных пользователей.
        /// </summary>
        [JsonPropertyName("save")]
        public bool? Save { get; set; }
    }
}