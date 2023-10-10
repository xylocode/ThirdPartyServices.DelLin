namespace XyloCode.ThirdPartyServices.DelLin.Models
{
    /// <summary>
    /// Дополнительная услуга
    /// </summary>
    public class RequestService
    {
        /// <summary>
        /// Уникальный идентификатор услуги
        /// </summary>
        public int Id {  get; set; }

        /// <summary>
        /// Уникальный идентификатор для связи с другими справочниками.
        /// </summary>
        public string UID {  get; set; }

        /// <summary>
        /// Наименование услуги
        /// </summary>
        public string Name { get; set; }
    }
}
