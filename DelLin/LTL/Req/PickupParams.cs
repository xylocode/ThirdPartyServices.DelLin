using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace XyloCode.ThirdPartyServices.DelLin.LTL.Req
{
    public class PickupParams
    {
        /// <summary>
        /// Время заказа пропуска для въезда на территорию отправителя.
        /// Доступные значения:
        /// "1" - заказать за час;
        /// "24" - заказать за сутки
        /// </summary>
        [JsonPropertyName("derivalDriverPass")]
        public int? DerivalDriverPass { get; set; }


        /// <summary>
        /// Запись на отгрузку.
        /// Значение по умолчанию: "false"
        /// </summary>
        [JsonPropertyName("shipmentRegister")]
        public bool? ShipmentRegister { get; set; }


        /// <summary>
        /// Информация о платном въезде на территорию отправителя
        /// </summary>
        [JsonPropertyName("paidEntry")]
        public PaidEntry PaidEntry { get; set; }


        /// <summary>
        /// Номер отгрузки для получения груза.
        /// Максимальная длина поля: 30 символов
        /// </summary>
        [JsonPropertyName("shipmentDerival")]
        public string ShipmentDerival { get; set; }


        /// <summary>
        /// Предварительный звонок.
        /// Значение по умолчанию: "false"
        /// </summary>
        [JsonPropertyName("priorCall")]
        public bool? PriorCall { get; set; }


        /// <summary>
        /// Не требуется согласование с отправителем.
        /// Значение по умолчанию: "false"
        /// </summary>
        [JsonPropertyName("noNeedAgreement")]
        public bool? NoNeedAgreement { get; set; }


        /// <summary>
        /// Документы для получения груза.
        /// Указываются UID'ы документов из справочника "Документы для получения груза"
        /// </summary>
        [JsonPropertyName("documentsForReceive")]
        public List<Guid> DocumentsForReceive { get; set; }
    }
}
