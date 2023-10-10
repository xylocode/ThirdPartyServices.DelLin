using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace XyloCode.ThirdPartyServices.DelLin.Calc2.Res
{
    public class CalculationResponse
    {
        /// <summary>
        /// Признак перенаправления груза
        /// </summary>
        [JsonPropertyName("redirect")]
        public bool? Redirect { get; set; }


        /// <summary>
        /// Данные о терминале отправления
        /// </summary>
        [JsonPropertyName("derival")]
        public Derival Derival { get; set; }


        /// <summary>
        /// Информация о стоимости доставки груза до адреса получателя с учетом стоимости услуг, наценок и скидок на услуги, но без учета ПРР
        /// </summary>
        [JsonPropertyName("arrival")]
        public Arrival Arrival { get; set; }


        /// <summary>
        /// Информация о стоимости ПРР
        /// </summary>
        [JsonPropertyName("loadunload")]
        public Loadunload Loadunload { get; set; }


        /// <summary>
        /// Информационное сообщение. Отображается, например, если в запросе был передан промокод, но применить его по какой-то причине невозможно
        /// </summary>
        [JsonPropertyName("information")]
        public List<string> Information { get; set; }
    }

    public class DiscountDetail
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }

        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("announcement")]
        public string Announcement { get; set; }

        [JsonPropertyName("public")]
        public string Public { get; set; }

        [JsonPropertyName("triggers")]
        public List<Trigger> Triggers { get; set; }
    }

   
    public class PremiumDetail
    {
        [JsonPropertyName("date")]
        public object Date { get; set; }

        [JsonPropertyName("announcement")]
        public bool? Announcement { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }

        [JsonPropertyName("public")]
        public bool? Public { get; set; }
    }


}
