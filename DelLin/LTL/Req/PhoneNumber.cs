using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.LTL.Req
{
    public class PhoneNumber
    {
        public PhoneNumber() { }
        public PhoneNumber(string phoneNumber) { Number = phoneNumber; }

        /// <summary>
        /// Номер телефона.
        /// Максимальная длина поля: 15 цифр
        /// </summary>
        [JsonPropertyName("number")]
        public string Number { get; set; }


        /// <summary>
        /// Добавочный номер.
        /// Максимальная длина поля: 5 цифр
        /// </summary>
        [JsonPropertyName("ext")]
        public string Ext {  get; set; }

        /// <summary>
        /// Признак сохранения объекта в адресную книгу.
        /// Значение по умолчанию: "false".
        /// Параметр игнорируется для третьего лица.Параметр игнорируется для неавторизованных пользователей
        /// </summary>
        [JsonPropertyName("save")]
        public bool? Save { get; set; }
    }
}