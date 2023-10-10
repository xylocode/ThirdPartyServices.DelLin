using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.LTL.Req
{
    /// <summary>
    /// Участники перевозки
    /// </summary>
    public class Members
    {
        /// <summary>
        /// Заказчик перевозки
        /// </summary>
        [JsonPropertyName("requester")]
        public Requester Requester { get; set; }


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
