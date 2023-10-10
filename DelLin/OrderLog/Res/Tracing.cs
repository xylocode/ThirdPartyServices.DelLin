using System;
using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.OrderLog.Res
{
    public class Tracing
    {
        /// <summary>
        /// Событие, дата которого передаётся в параметре "tracing.date".
        /// Значение всегда "Отбытие из ОСП".
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }


        /// <summary>
        /// Дата прохождения точки маршрута.
        /// Формат даты: ГГГГ-ММ-ДД
        /// </summary>
        [JsonPropertyName("date")]
        public DateOnly? Date { get; set; }


        /// <summary>
        /// UID города (промежуточной точки маршрута).
        /// </summary>
        [JsonPropertyName("cityUID")]
        public string CityUID { get; set; }


        /// <summary>
        /// Город (промежуточная точка маршрута).
        /// </summary>
        [JsonPropertyName("cityName")]
        public string CityName { get; set; }


        /// <summary>
        /// Статус заказа на момент прохождения точки маршрута. Значение всегда "inway" (см. "Справочник статусов заказа груза").
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
