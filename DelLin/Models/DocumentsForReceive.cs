namespace XyloCode.ThirdPartyServices.DelLin.Models
{
    /// <summary>
    /// Документы для получения груза
    /// </summary>
    public class DocumentsForReceive
    {
        /// <summary>
        /// Уникальный идентификатор документа для получения груза.
        /// </summary>
        public string UID {  get; set; }

        /// <summary>
        /// Наименование документа для получения груза.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Признак, определяющий возможность получения груза день в день по данному документу
        /// </summary>
        public string OneDay { get; set; }
    }
}
