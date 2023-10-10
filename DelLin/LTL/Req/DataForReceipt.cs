using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.LTL.Req
{
    /// <summary>
    /// Контактные данные для отправки электронного чека плательщику-физическому лицу
    /// </summary>
    public class DataForReceipt
    {
        /// <summary>
        /// Согласие на получение электронного чека об оплате.Доступные значения:
        /// "true" - пользователь ввел "phone" и/или "email" для отправки чека;
        /// "false" - пользователь отказался предоставлять контактные данные для отправки чека.
        /// </summary>
        [JsonPropertyName("send")]
        public bool Send {  get; set; }


        /// <summary>
        /// Номер телефона для отправки чека.
        /// Формат номера: "+79XXXXXXXXX" (12 символов: начинается с "+79", и далее 9 цифр).
        /// Если "send" = "true", то обязательна передача хотя бы одного из параметров: "phone" или "email";
        /// Если "send" = "false", то параметр игнорируется.
        /// </summary>
        [JsonPropertyName("phone")]
        public string Phone { get; set; }


        /// <summary>
        /// Email адрес для отправки чека
        /// Если "send" = "true", то обязательна передача хотя бы одного из параметров: "phone" или "email"
        /// Если "send" = "false", то параметр игнорируется
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }
    }
}