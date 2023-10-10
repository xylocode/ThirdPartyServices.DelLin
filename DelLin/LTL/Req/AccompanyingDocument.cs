using System.Text.Json.Serialization;
using XyloCode.ThirdPartyServices.DelLin.Enums;

namespace XyloCode.ThirdPartyServices.DelLin.LTL.Req
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


        /// <summary>
        /// Плательщик по услуге.
        /// Доступные значения:
        /// "sender" - отправитель;
        /// "receiver" - получатель;
        /// "third" - третье лицо.
        /// Если параметр не передан, то он принимает значение параметра "request.payment.primaryPayer"
        /// </summary>
        [JsonPropertyName("payer")]
        public RoleType? Payer { get; set; }
    }
}
