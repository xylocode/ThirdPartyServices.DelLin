using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.LTL.Req
{
    public class Product
    {
        /// <summary>
        /// Наименование товара
        /// </summary>
        [JsonPropertyName("productName")]
        public string ProductName {  get; set; }


        /// <summary>
        /// Номенклатурный номер (артикул)
        /// </summary>
        [JsonPropertyName("productCode")]
        public string ProductCode { get; set; }


        /// <summary>
        /// Количество
        /// </summary>
        [JsonPropertyName("productAmount")]
        public int ProductAmount { get; set; }


        /// <summary>
        /// Цена за ед. с НДС, руб.
        /// </summary>
        [JsonPropertyName("costWithVAT")]
        public decimal CostWithVAT { get; set; }


        /// <summary>
        /// Ставка НДС, %.
        /// Доступные значения:
        /// "0";
        /// "10";
        /// "20".
        /// Если товар не облагается НДС, то следует передавать не 0 значение, а просто не передавать параметр.
        /// </summary>
        [JsonPropertyName("VATRate")]
        public float? VATRate { get; set; }
    }
}