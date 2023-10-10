using System.Collections.Generic;
using System.Text.Json.Serialization;
using XyloCode.ThirdPartyServices.DelLin.Enums;

namespace XyloCode.ThirdPartyServices.DelLin.Calc1.Res
{
    public class CalculationResponse
    {
        /// <summary>
        /// Данные по доставке груза от отправителя
        /// </summary>
        [JsonPropertyName("derival")]
        public DerivalArrival Derival { get; set; }

        /// <summary>
        /// Информация о стоимости автоперевозки
        /// </summary>
        [JsonPropertyName("intercity")]
        public CostsCalculation Intercity { get; set; }

        /// <summary>
        /// Информация о стоимости доставки  малогабаритного груза
        /// </summary>
        [JsonPropertyName("small")]
        public CostsCalculation Small { get; set; }

        /// <summary>
        /// Информация о стоимости авиаперевозки
        /// </summary>
        [JsonPropertyName("air")]
        public CostsCalculation Air { get; set; }


        /// <summary>
        /// Информация о стоимости экспресс-перевозки
        /// </summary>
        [JsonPropertyName("express")]
        public CostsCalculation Express { get; set; }


        /// <summary>
        /// Информация о стоимости услуги "Письмо"
        /// </summary>
        [JsonPropertyName("letter")]
        public CostsCalculation Letter { get; set; }


        /// <summary>
        /// Данные по доставке груза до получателя
        /// </summary>
        [JsonPropertyName("arrival")]
        public DerivalArrival Arrival { get; set; }

        /// <summary>
        /// Итоговая стоимость для выбранного вида перевозки
        /// Итоговая стоимость складывается из значений следующих параметров:
        /// Cтоимость выбранного вида межтерминальной перевозки ("data.intercity.price"/"data.small.price"/"data.air.price"/"data.express.price"/"data.letter.price").
        /// Где:
        /// "data.derival.price" - стоимость доставки от отправителя;
        /// "data.arrival.price" - стоимость доставки до получателя;
        /// "data.insurance" - стоимость страхования груза;
        /// "data.packages.price" - стоимость упаковки, в ответе может присутствовать несколько таких параметров;
        /// "data.insurance.accompanyingDocuments.send.price" - стоимость отправки сопроводительных документов;
        /// "data.insurance.accompanyingDocuments.receive.price" - стоимость возврата сопроводительных документов;
        /// "data.notify.price" - стоимость услуги "Информация о статусе заказа".
        /// Примечание.
        /// Если стоимость одной из услуг является договорной (значение параметра - "null", а значение соответствующего параметра "contractPrice" - "true"), то итоговая стоимость рассчитывается без учёта стоимости данной услуги
        /// </summary>
        [JsonPropertyName("price")]
        public decimal? Price { get; set; }


        /// <summary>
        /// Способ перевозки с минимальной стоимостью.
        /// Возможные значения:
        /// "auto" - автоперевозка;
        /// "express" - экспресс-доставка;
        /// "small" - доставка малогабаритного груза;
        /// "letter" - письмо;
        /// "avia" - авиадоставка
        /// </summary>
        [JsonPropertyName("priceMinimal")]
        public DeliveryTypeCode? PriceMinimal { get; set; }


        /// <summary>
        /// Информация о стоимости упаковки
        /// </summary>
        [JsonPropertyName("packages")]
        public List<CostsCalculation> Packages { get; set; }


        /// <summary>
        /// График движения груза
        /// </summary>
        [JsonPropertyName("orderDates")]
        public OrderDates OrderDates { get; set; }


        /// <summary>
        /// Срок доставки груза от терминала получения до адреса (в днях)
        /// </summary>
        [JsonPropertyName("deliveryTerm")]
        public int? DeliveryTerm { get; set; }


        /// <summary>
        /// Информация о стоимости отправки/возврата сопроводительных документов
        /// </summary>
        [JsonPropertyName("accompanyingDocuments")]
        public AccompanyingDocuments AccompanyingDocuments { get; set; }


        /// <summary>
        /// Общая стоимость страхования груза
        /// </summary>
        [JsonPropertyName("insurance")]
        public decimal? Insurance { get; set; }


        /// <summary>
        /// Общий список услуг по страхованию груза и их стоимость
        /// </summary>
        [JsonPropertyName("insuranceComponents")]
        public InsuranceComponents InsuranceComponents { get; set; }


        /// <summary>
        /// Информация о стоимости услуги "информация о статусе заказа"
        /// </summary>
        [JsonPropertyName("notify")]
        public CostsCalculation Notify { get; set; }


        /// <summary>
        /// Информация о доступности услуги "упрощённая отправка"
        /// </summary>
        [JsonPropertyName("simpleShippingAvailable")]
        public bool? SimpleShippingAvailable { get; set; }

        /// <summary>
        /// Список доступных видов перевозки и их стоимость
        /// </summary>
        [JsonPropertyName("availableDeliveryTypes")]
        public AvailableDeliveryTypes AvailableDeliveryTypes { get; set; }


        /// <summary>
        /// Данные по найденным адресам/населённым пунктам.
        /// Параметр присутствует в ответе, только если в запросе был передан параметр "address.search" класса "DerivalArrival" или параметр "paymetn.paymentCitySearch.search"
        /// </summary>
        [JsonPropertyName("foundAddresses")]
        public List<FoundAddress> FoundAddresses { get; set; }


        /// <summary>
        /// Информационное сообщение.
        /// Отображается, например, если стоимость какой-то из услуг является договорной (в ответе есть параметр "contractPrice" со значением "true") или если в запросе был передан промокод, но применить его по какой-то причине невозможно.
        /// </summary>
        [JsonPropertyName("information")]
        public List<string> Information { get; set; }
    }
}
