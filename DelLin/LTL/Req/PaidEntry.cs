using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.LTL.Req
{
    /// <summary>
    /// Информация о платном въезде на территорию отправителя
    /// </summary>
    public class PaidEntry
    {
        /// <summary>
        /// Сумма оплаты
        /// </summary>
        [JsonPropertyName("сost")]
        public decimal? Cost { get; set; }


        /// <summary>
        /// Вариант возмещения произведённой оплаты.
        /// Доступные значения:
        /// "1" - по чеку на адресе;
        /// "2" - включить в счет
        /// </summary>
        [JsonPropertyName("type")]
        public byte? Type { get; set; }
    }
}