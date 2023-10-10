using System;
using System.Text.Json.Serialization;
using XyloCode.ThirdPartyServices.DelLin.Helpers;

namespace XyloCode.ThirdPartyServices.DelLin.OrderLog.Res
{
    public class Service
    {
        /// <summary>
        /// Наименование услуги.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// UID услуги.
        /// </summary>
        [JsonPropertyName("serviceUid")]
        public string ServiceUid { get; set; }


        /// <summary>
        /// Дата создания.
        /// </summary>
        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }


        /// <summary>
        /// Количество
        /// </summary>
        [JsonPropertyName("quantity")]
        public int? Quantity { get; set; }


        /// <summary>
        /// Сумма.
        /// </summary>
        [JsonPropertyName("sum")]
        [JsonConverter(typeof(JsonStringAsNDecimalConverter))]
        public decimal? Sum { get; set; }


        /// <summary>
        /// Сумма итого.
        /// </summary>
        [JsonPropertyName("totalSum")]
        [JsonConverter(typeof(JsonStringAsNDecimalConverter))]
        public decimal? TotalSum { get; set; }


        /// <summary>
        /// НДС
        /// </summary>
        [JsonPropertyName("vat")]
        [JsonConverter(typeof(JsonStringAsNDecimalConverter))]
        public decimal? Vat { get; set; }


        /// <summary>
        /// Ставка НДС, если НДС не применяется, то выводится значение "БЕЗ НДС".
        /// </summary>
        [JsonPropertyName("vatRate")]
        public string VatRate { get; set; }


        /// <summary>
        /// Сумма скидки.
        /// </summary>
        [JsonPropertyName("discountSum")]
        [JsonConverter(typeof(JsonStringAsNDecimalConverter))]
        public decimal? DiscountSum { get; set; }
    }
}
