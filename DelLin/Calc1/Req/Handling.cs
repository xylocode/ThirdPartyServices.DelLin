using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.Calc1.Req
{
    /// <summary>
    /// Погрузо-разгрузочные работы на адресе.
    /// </summary>
    public class Handling
    {
        /// <summary>
        /// Есть грузовой лифт.
        /// Значение по умолчанию: "false"
        /// </summary>
        [JsonPropertyName("freightLift")]
        public bool? FreightLift { get; set; }

        /// <summary>
        /// Номер этажа, на который необходимо поднять груз
        /// </summary>
        [JsonPropertyName("toFloor")]
        public int? ToFloor { get; set; }

        /// <summary>
        /// Расстояние, на которое необходимо перенести груз (в метрах)
        /// </summary>
        [JsonPropertyName("carry")]
        public int? Carry { get; set; }
    }
}
