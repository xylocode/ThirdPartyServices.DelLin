using System.Collections.Generic;
using System.Text.Json.Serialization;
using XyloCode.ThirdPartyServices.DelLin.Requests;

namespace XyloCode.ThirdPartyServices.DelLin.ShipmentLabels
{
    /// <summary>
    /// Для запроса передачи артикулов грузовых мест.
    /// </summary>
    public class PostShipmentLabelsRequest : Request
    {
        /// <summary>
        /// ID заказа, по которому необходимо сгенерировать этикетки на груз и сопроводительные документы.
        /// Для оформления заказа следует использовать метод "Перевозка сборных грузов".
        /// </summary>
        [JsonPropertyName("orderID")]
        public string OrderID { get; set; }


        /// <summary>
        /// Данные по грузовым местам.
        /// </summary>
        [JsonPropertyName("cargoPlaces")]
        public List<CargoPlace> CargoPlaces { get; set; }
    }

    /// <summary>
    /// Данные по грузовому месту.
    /// </summary>
    public class CargoPlace
    {
        /// <summary>
        /// Артикул грузового места(грузовые места маркируются заказчиком), значение может быть неуникальным.
        /// Если нет информации / возможности передать информацию по грузовому месту, но необходимо сгенерировать этикетки, можно передать null в качестве значения параметра.
        /// </summary>
        [JsonPropertyName("cargoPlace")]
        public string Code { get; set; }


        /// <summary>
        /// Количество грузовых мест с одинаковым артикулом.
        /// Если значение не передано, то параметр принимает значение 1.
        /// </summary>
        [JsonPropertyName("amount")]
        public int? Amount { get; set; }
    }
}
