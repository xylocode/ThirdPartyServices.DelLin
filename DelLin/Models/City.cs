namespace XyloCode.ThirdPartyServices.DelLin.Models
{
    /// <summary>
    /// Для справочника населенных пунктов.
    /// </summary>
    public class City
    {
        /// <summary>
        /// Уникальный идентификатор города в рамках нашей системы.
        /// </summary>
        public int CityID { get; set; }


        /// <summary>
        /// Полное наименование населённого пункта.
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        /// Код КЛАДР населенного пункта.
        /// </summary>
        public string Code { get; set; }


        /// <summary>
        /// Наименование населённого пункта, сформированное специальным образом для поиска.
        /// Например, для реализации автодополнения.
        /// </summary>
        public string SearchString { get; set; }
        
        
        /// <summary>
        /// Наименование региона для населённого пункта.
        /// </summary>
        public string RegName { get; set; }
        
        
        /// <summary>
        /// Код КЛАДР региона для населённого пункта.
        /// </summary>
        public string RegCode { get; set; }
        
        
        /// <summary>
        /// Наименование района для населённого пункта.
        /// </summary>
        public string ZoneName { get; set; }
        
        
        /// <summary>
        /// Код КЛАДР района для населённого пункта.
        /// </summary>
        public string ZoneCode { get; set; }
    }
}
