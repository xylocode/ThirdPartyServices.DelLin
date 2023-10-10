using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.Calc3.Res
{
    public class CalculationResponse
    {
        /// <summary>
        /// Данные по автоперевозке от терминала до терминала
        /// </summary>
        [JsonPropertyName("terminals_standard")]
        public PeriodPrice TerminalsStandard { get; set; }


        /// <summary>
        /// Данные по доставке документов от терминала до терминала
        /// </summary>
        [JsonPropertyName("terminals_documents")]
        public PeriodPrice TerminalsDocuments { get; set; }


        /// <summary>
        /// Данные по экспресс-доставке от терминала до терминала
        /// </summary>
        [JsonPropertyName("terminals_express")]
        public PeriodPrice TerminalsExpress { get; set; }


        /// <summary>
        /// Данные по авиаперевозке от терминала до терминала
        /// </summary>
        [JsonPropertyName("terminals_avia")]
        public PeriodPrice TerminalsAvia { get; set; }


        /// <summary>
        /// Данные по автоперевозке от адреса отправителя до адреса получателя
        /// </summary>
        [JsonPropertyName("door_to_door_standard")]
        public PeriodPrice DoorToDoorStandard { get; set; }


        /// <summary>
        /// Данные по доставке документов от адреса отправителя до адреса получателя
        /// </summary>
        [JsonPropertyName("door_to_door_documents")]
        public PeriodPrice DoorToDoorDocuments { get; set; }


        /// <summary>
        /// Данные по доставке малогабаритного груза от адреса отправителя до адреса получателя
        /// </summary>
        [JsonPropertyName("door_to_door_parcel")]
        public PeriodPrice DoorToDoorParcel { get; set; }


        /// <summary>
        /// Данные по экспресс-доставке от адреса отправителя до адреса получателя
        /// </summary>
        [JsonPropertyName("door_to_door_express")]
        public PeriodPrice DoorToDoorExpress { get; set; }


        /// <summary>
        /// Данные по авиаперевозке от адреса отправителя до адреса получателя
        /// </summary>
        [JsonPropertyName("door_to_door_avia")]
        public PeriodPrice DoorToDoorAvia { get; set; }
    }
}
