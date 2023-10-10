using System;
using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.LTL.Req
{
    /// <summary>
    /// Информация о грузе
    /// </summary>
    public class Cargo
    {
        /// <summary>
        /// Количество грузовых мест, шт.Значение по умолчанию - "1".
        /// Если вид перевозки груза - "письмо" ("request.delivery.deliveryType.type" = "letter"), то переданное значение параметра игнорируется, используется значение "1"
        /// </summary>
        [JsonPropertyName("quantity")]
        public int? Quantity { get; set; }

        /// <summary>
        /// Длина самого длинного грузового места, м.
        /// Если вид перевозки груза - "письмо"("request.delivery.deliveryType.type" = "letter"), то параметр не является обязательным, переданное значение параметра игнорируется, используется значение "0.3"
        /// </summary>
        [JsonPropertyName("length")]
        public float? Length { get; set; }

        /// <summary>
        /// Ширина самого широкого грузового места, м.
        /// Если вид перевозки груза- "письмо" ("request.delivery.deliveryType.type" = "letter"), то параметр не является обязательным, переданное значение параметра игнорируется, используется значение "0.21"
        /// </summary>
        [JsonPropertyName("width")]
        public float? Width { get; set; }

        /// <summary>
        /// Высота самого высокого грузового места, м.
        /// Если вид доставки - "письмо" ("request.delivery.deliveryType.type" = "letter"), то параметр не является обязательным, переданное значение параметра игнорируется, используется значение "0.01"
        /// </summary>
        [JsonPropertyName("height")]
        public float? Height { get; set; }

        /// <summary>
        /// Вес самого тяжелого грузового места, кг.
        /// Параметр является обязательным, если количество грузовых мест больше одного("request.cargo.quantity" > 1).
        /// В противном случае значение параметра принимается равным значению параметра "request.cargo.totalWeight".
        /// Если вид доставки - "письмо" ("request.delivery.deliveryType.type" = "letter"), то параметр не является обязательным, переданное значение параметра игнорируется, используется значение "0.5"
        /// </summary>
        [JsonPropertyName("weight")]
        public float? Weight { get; set; }

        /// <summary>
        /// Общий объём груза, м3.
        /// Если вид доставки - "письмо" ("request.delivery.deliveryType.type" = "letter"), то параметр не является обязательным, переданное значение параметра игнорируется, используется значение "0.001"
        /// </summary>
        [JsonPropertyName("totalVolume")]
        public float? TotalVolume { get; set; }


        /// <summary>
        /// Общий вес груза, кг.
        /// Если вид доставки - "письмо" ("request.delivery.deliveryType.type" = "letter"), то параметр не является обязательным, переданное значение параметра игнорируется, используется значение "0.5"
        /// </summary>
        [JsonPropertyName("totalWeight")]
        public float? TotalWeight { get; set; }


        /// <summary>
        /// Вес негабаритных грузовых мест, кг.
        /// Если вид доставки - "письмо" ("request.delivery.deliveryType.type" = "letter"), то параметр игнорируется.
        /// Если по весогабаритным характеристикам определено, что груз является негабаритным, то параметр является обязательным
        /// </summary>
        [JsonPropertyName("oversizedWeight")]
        public float? OversizedWeight { get; set; }


        /// <summary>
        /// Объём негабаритных грузовых мест, м3.
        /// Если вид доставки - "письмо" ("request.delivery.deliveryType.type" = "letter"), то параметр игнорируется.
        /// Если по весогабаритным характеристикам определено, что груз является негабаритным, то параметр является обязательным
        /// </summary>
        [JsonPropertyName("oversizedVolume")]
        public float? OversizedVolume { get; set; }


        /// <summary>
        /// UID характера груза из справочника "Характер груза".
        /// Для поиска UID по наименованию груза следует использовать сервис "Характер груза по введенной строке".
        /// Если значение параметра "request.delivery.deliveryType.type" - "letter", то переданное значение игнорируется, автоматически устанавливается UID груза "Документы"
        /// </summary>
        [JsonPropertyName("freightUID")]
        public string FreightUID { get; set; }

        /// <summary>
        /// Класс опасности груза.
        /// Значение по умолчанию - "0"
        /// </summary>
        [JsonPropertyName("hazardClass")]
        public string HazardClass { get; set; }


        /// <summary>
        /// Информация о страховке груза
        /// </summary>
        [JsonPropertyName("insurance")]
        public Insurance Insurance { get; set; }
    }

}
