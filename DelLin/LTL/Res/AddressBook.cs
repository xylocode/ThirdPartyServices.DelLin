using System.Reflection;
using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.LTL.Res
{
    public class AddressBook
    {
        /// <summary>
        /// Отправитель
        /// </summary>
        [JsonPropertyName("sender")]
        public Member Sender { get; set; }


        /// <summary>
        /// Получатель
        /// </summary>
        [JsonPropertyName("receiver")]
        public Member Receiver { get; set; }


        /// <summary>
        /// Третье лицо
        /// </summary>
        [JsonPropertyName("third")]
        public Member Third { get; set; }
    }
}