using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.CitiesAndTerminals.FileModel
{
    /// <summary>
    /// Отдел терминала
    /// </summary>
    public class Worktable
    {
        /// <summary>
        /// Наименование отдела.
        /// Возможные значения:
        /// "Доставка груза";
        /// "Прием и выдача груза";
        /// "Приём груза";
        /// "Выдача груза
        /// "Приём груза к экспресс-перевозке";
        /// "Выдача грузов экспресс-перевозки";
        /// "Обработка заявок на доставку груза от/до адреса";
        /// "Офис"
        /// </summary>
        [JsonPropertyName("department")]
        public string Department { get; set; }


        /// <summary>
        /// Время работы в понедельник.
        /// </summary>
        [JsonPropertyName("monday")]
        public string Monday { get; set; }


        /// <summary>
        /// Время работы во вторник.
        /// </summary>
        [JsonPropertyName("tuesday")]
        public string Tuesday { get; set; }


        /// <summary>
        /// Время работы в среду.
        /// </summary>
        [JsonPropertyName("wednesday")]
        public string Wednesday { get; set; }


        /// <summary>
        /// Время работы в четверг.
        /// </summary>
        [JsonPropertyName("thursday")]
        public string Thursday { get; set; }


        /// <summary>
        /// Время работы в пятницу.
        /// </summary>
        [JsonPropertyName("friday")]
        public string Friday { get; set; }


        /// <summary>
        /// Время работы в субботу.
        /// </summary>
        [JsonPropertyName("saturday")]
        public string Saturday { get; set; }


        /// <summary>
        /// Время работы в воскресенье.
        /// </summary>
        [JsonPropertyName("sunday")]
        public string Sunday { get; set; }


        /// <summary>
        /// Время работы на всю неделю короткой строкой.
        /// </summary>
        [JsonPropertyName("timetable")]
        public string Timetable { get; set; }
    }
}
