using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.Calc1.Res
{
    public class DerivalArrival
    {
        // Дополнено из ответа:

        /// <summary>
        /// Город подразделения-отправителя/подразделения-получателя
        /// </summary>
        [JsonPropertyName("terminal")]
        public string Terminal { get; set; }

        /// <summary>
        /// Итоговая стоимость доставки от отправителя/до получателя
        /// Если заказана доставка от терминала/до терминала, то есть в запросе для параметра "request.delivery.derival.variant"/"request.delivery.arrival.variant" было передано значение "terminal", то итоговая стоимость отправки/получения равна стоимости въезда на терминал(см.параметры "response.derival.teminals.pirce"/response.arrival.teminals.pirce").
        /// Если заказана доставка от адреса отправителя/до адреса получателя, то есть в запросе для параметра "request.delivery.derival.variant"/"request.delivery.arrival.variant" было передано значение "address", то итоговая стоимость складывается из значений следующих параметров:
        /// "response.derival.servicePrice"/"response.arrival.servicePrice"- стоимость услуги без учёта скидок и наценок.
        /// "response.derival.handling.price"/"response.arrival.handling.price"- стоимость погрузо-разгрузочных работ.
        /// Если заказана доставка от/до адреса, то также учитывается значение параметра "response.derival.premiumDetails.value"/"response.arrival.premiumDetails.value" - размер наценки (в ответе может присутствовать несколько таких параметров)
        [JsonPropertyName("price")]
        public decimal? Price { get; set; }


        /// <summary>
        /// Флаг, обозначающий, что стоимость доставки является договорной. Если стоимость договорная (значение параметра - "true"), то значение параметров "price" и "servicePrice" - "null", информация о наценках и скидках отсутствует (массивы "premiumDetails" и "discountDetails" - пустые)
        /// </summary>
        [JsonPropertyName("contractPrice")]
        public bool? ContractPrice { get; set; }


        /// <summary>
        /// Стоимость услуги доставки груза от адреса отправителя/до адреса получателя (без учёта скидок и наценок).
        /// Параметр выводится только в том случае, если производится расчёт стоимости доставки непосредственно от/до адреса, то есть в запросе для параметра"request.delivery.derival.variant"/"request.delivery.arrival.variant" было передано значение "address"(в случае, если рассчитывается стоимость доставки от/до терминала, то есть было передано значение "terminal", параметр не выводится).
        /// </summary>
        [JsonPropertyName("servicePrice")]
        public decimal? ServicePrice { get; set; }


        /// <summary>
        /// Подробная информация о наценках по услуге
        /// </summary>
        [JsonPropertyName("premiumDetails")]
        public List<PricingDetails> PremiumDetails { get; set; }


        /// <summary>
        /// Подробная информация о скидках по услуге
        /// </summary>
        [JsonPropertyName("discountDetails")]
        public List<PricingDetails> DiscountDetails { get; set; }


        /// <summary>
        /// Информация о терминалах, где может быть выдан/сдан груз
        /// </summary>
        [JsonPropertyName("terminals")]
        public List<Terminal> Terminals { get; set; }

        /// <summary>
        /// Информация о стоимости погрузо-разгрузочных работ
        /// </summary>
        [JsonPropertyName("handling")]
        public CostsCalculation Handling { get; set; }
    }
}
