using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.ShipmentLabels
{
    public class GetShipmentLabelsResponse
    {
        /// <summary>
        /// Артикул грузового места.
        /// При формировании многостраничного документа выводится пустое значение.
        /// </summary>
        [JsonPropertyName("cargoPlace")]
        public string CargoPlace { get; set; }


        /// <summary>
        /// Порядковый номер грузового места.
        /// При формировании многостраничного документа параметр принимает значение "result".
        /// </summary>
        [JsonPropertyName("number")]
        public string Number { get; set; }


        /// <summary>
        /// Размер этикетки.
        /// Возможные значения: 80x50, a4
        /// </summary>
        [JsonPropertyName("format")]
        public string Format { get; set; }


        /// <summary>
        /// MIME-тип файла.
        /// Возможные значения: image/jpeg, application/pdf, image/png
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }


        /// <summary>
        /// Base64-код файла, содержащего этикетку
        /// </summary>
        [JsonPropertyName("base64")]
        public string Base64 { get; set; }

    }
}
