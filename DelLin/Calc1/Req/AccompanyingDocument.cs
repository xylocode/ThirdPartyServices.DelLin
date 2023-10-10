using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.Calc1.Req
{
    public class AccompanyingDocument
    {
        public enum ActionType
        {
            Send = 1,
            Return
        }

        /// <summary>
        /// Действие с сопроводительными документами.
        /// Возможные значения:
        /// "send" - отправка;
        /// "return" - возврат.
        /// Возможна передача обоих значений с использованием отдельных параметров.
        /// Возврат сопроводительных документов недоступен при отправке груза "анонимному" получателю, то есть, если значение "members.receiver.counteragent.isAnonym" - "true". 
        /// "Анонимный" получатель - получатель, о котором предоставлен минимум информации (см. описание услуги "Упрощённая отправка груза" на сайте компании "Деловые Линии")
        /// </summary>
        [JsonPropertyName("action")]
        public ActionType Action { get; set; }
    }

}
