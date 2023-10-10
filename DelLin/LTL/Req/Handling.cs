using System.Text.Json.Serialization;
using XyloCode.ThirdPartyServices.DelLin.Enums;

namespace XyloCode.ThirdPartyServices.DelLin.LTL.Req
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

        /// <summary>
        /// Плательщик по услуге.
        /// Доступные значения:
        /// "sender" - отправитель;
        /// "receiver" - получатель;
        /// "third" - третье лицо.
        /// Если параметр не передан, то он принимает значение параметра "request.payment.primaryPayer"
        /// </summary>
        [JsonPropertyName("payer")]
        public RoleType? Payer { get; set; }

    }
}
