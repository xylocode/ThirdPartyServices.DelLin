using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.Models
{
    public class WebhookEvent
    {
        /// <summary>
        /// Тип события.
        /// Формат: сущность.группа_событий.событие
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; }


        /// <summary>
        /// Описание.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description {  get; set; }


        /// <summary>
        /// Признак доступности подписки на событие для пользователя, не являющегося участником перевозки.
        /// Возможные значения:
        /// True - доступно всем,
        /// False - доступно только участникам перевозки
        /// </summary>
        [JsonPropertyName("public")]
        public bool Public { get; set; }
    }
}
