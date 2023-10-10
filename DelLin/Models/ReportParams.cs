namespace XyloCode.ThirdPartyServices.DelLin.Models
{
    /// <summary>
    /// Справочник параметров для статистического отчета
    /// </summary>
    public class ReportParams
    {
        /// <summary>
        /// Наименование параметра (ключ на латинице).
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Название параметра (на кириллице).
        /// </summary>
        public string Caption { get; set; }
    }
}
