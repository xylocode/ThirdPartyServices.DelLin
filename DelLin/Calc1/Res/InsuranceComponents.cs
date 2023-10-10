using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.Calc1.Res
{
    /// <summary>
    /// Общий список услуг по страхованию груза и их стоимость.
    /// </summary>
    public class InsuranceComponents
    {
        /// <summary>
        /// Общая стоимость услуги "Страхование груза"
        /// </summary>
        [JsonPropertyName("cargoInsurance")]
        public decimal? CargoInsurance { get; set; }


        /// <summary>
        /// Общая стоимость услуги "Страхование срока доставки груза".
        /// Если стоимость не указана, значит, услуга недоступна для этого направления или груза
        /// </summary>
        [JsonPropertyName("termInsurance")]
        public decimal? TermInsurance { get; set; }


        /// <summary>
        /// Признак договорной цены.
        /// Если стоимость договорная (значение параметра - "true"), то информация о стоимости отсутствует (значения параметров "cargoInsurance" и "termInsurance" - "0").
        /// </summary>
        [JsonPropertyName("contractPrice")]
        public bool? ContractPrice { get; set; }
    }

}
