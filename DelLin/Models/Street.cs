namespace XyloCode.ThirdPartyServices.DelLin.Models
{
    public class Street
    {
        /// <summary>
        /// Код КЛАДР улицы.
        /// </summary>
        public string Code {  get; set; }

        /// <summary>
        /// Уникальный идентификатор города в рамках нашей системы.
        /// </summary>
        public int CityID { get; set; }

        /// <summary>
        /// Наименование улицы сформированное специальным образом для поиска, например для реализации автодополнения.
        /// </summary>
        public string SearchString { get; set; }

        /// <summary>
        /// Полное наименование улицы.
        /// </summary>
        public string Name { get; set; }
    }
}
