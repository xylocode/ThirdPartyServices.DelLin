using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.Calc1.Req
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
    }
}
