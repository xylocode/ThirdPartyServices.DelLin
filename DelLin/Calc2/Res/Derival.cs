using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.Calc2.Res
{
    /// <summary>
    /// Данные о терминале отправления
    /// </summary>
    public class Derival
    {
        /// <summary>
        /// Город, в котором расположен терминал, до которого изначально была заказана доставка, и с которого рассчитывается доставка до адреса
        /// </summary>
        [JsonPropertyName("terminal")]
        public string Terminal { get; set; }
    }

}
