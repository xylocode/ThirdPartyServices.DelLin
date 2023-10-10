using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.Organizations.Res
{
    /// <summary>
    /// Пользователь
    /// </summary>
    public class User
    {
        /// <summary>
        /// Контактный телефон пользователя
        /// </summary>
        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// ФИО пользователя
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Электронная почта пользователя
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }
    }
}
