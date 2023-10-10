using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.CitiesAndTerminals.FileModel
{
    /// <summary>
    /// Расписание работы отделов терминала
    /// </summary>
    public class Worktables
    {
        /// <summary>
        /// Список отделов терминала
        /// </summary>
        [JsonPropertyName("worktable")]
        public List<Worktable> Worktable { get; set; }


        /// <summary>
        /// График работы терминала в праздничные дни.
        /// Параметр присутствует в ответе, если значение параметра "worktables.worktable.department" - одно из
        /// "Доставка груза"
        /// "Прием и выдача груза"
        /// "Приём груза"
        /// "Выдача груза"
        /// "Обработка заявок на доставку груза от/до адреса"
        /// </summary>
        [JsonPropertyName("specialWorktable")]
        public SpecialWorktable SpecialWorktable { get; set; }
    }
}
