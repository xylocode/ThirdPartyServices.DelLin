using System.Text.Json.Serialization;
using XyloCode.ThirdPartyServices.DelLin.Requests;

namespace XyloCode.ThirdPartyServices.DelLin.LTL.Req
{
    public class LtlRequest : Request
    {
        /// <summary>
        /// Если передано значение "false", то заявка сохраняется, но не передается в дальнейшую обработку (необходимо, например, в случае, если заявку будет включена в состав мультизаявки).
        /// Значение по умолчанию: "true".
        /// Если пользователь не авторизован, то параметр игнорируется.
        /// </summary>
        [JsonPropertyName("inOrder")]
        public bool? InOrder { get; set; }


        /// <summary>
        /// Информация по перевозке груза.
        /// </summary>
        [JsonPropertyName("delivery")]
        public Delivery Delivery { get; set; }


        /// <summary>
        /// Участники перевозки.
        /// </summary>
        [JsonPropertyName("members")]
        public Members Members { get; set; }


        /// <summary>
        /// Информация о грузе.
        /// </summary>
        [JsonPropertyName("cargo")]
        public Cargo Cargo { get; set; }


        /// <summary>
        /// Оплата перевозки.
        /// </summary>
        [JsonPropertyName("payment")]
        public Payment Payment { get; set; }


        /// <summary>
        /// Номер товарно-транспортной накладной клиента.
        /// Максимальная длина строки - 100 символов.
        /// Номер товарно-транспортной накладной используется при формировании пакетных заказов.
        /// </summary>
        [JsonPropertyName("cargoCode")]
        public string CargoCode { get; set; }
    }
}
