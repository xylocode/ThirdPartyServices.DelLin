namespace XyloCode.ThirdPartyServices.DelLin.Models
{
    /// <summary>
    /// Для справочника населенных пунктов с ограничениями по оплате.
    /// Данный справочник содержит перечень городов, в которых недоступна оплата наличными/банковской картой, оплатить услуги в этих городах можно только посредством банковского перевода.
    /// </summary>
    public class CityCashlessOnly
    {
        /// <summary>
        /// Уникальный идентификатор города в рамках нашей системы.
        /// </summary>
        public int CityId {  get; set; }


        /// <summary>
        /// Код КЛАДР города.
        /// </summary>
        public string Code { get; set; }
    }
}
