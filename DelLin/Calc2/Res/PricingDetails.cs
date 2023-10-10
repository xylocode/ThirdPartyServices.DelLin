using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.Calc2.Res
{
    public class PricingDetails
    {
        /// <summary>
        /// Наименование типа скидки/наценки. Например, "Наценка на негабарит" или "Открытая акция"
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }


        /// <summary>
        /// Размер скидки/наценки в рублях
        /// </summary>
        [JsonPropertyName("value")]
        public decimal? Value { get; set; }


        /// <summary>
        /// Срок действия.
        /// Формат: "ГГГГ-ММ-ДД"
        /// </summary>
        [JsonPropertyName("date")]
        public DateOnly? Date { get; set; }


        /// <summary>
        /// Признак отношения к акциям.
        /// Возможные значения:
        /// "true" - скидка/наценка в рамках акции;
        /// "false" (или отсутствие параметра в пакете) - скидка/наценка вне акции
        /// </summary>
        [JsonPropertyName("announcement")]
        public bool? Announcement { get; set; }


        /// <summary>
        /// Признак публичной скидки/наценки.
        /// Для авторизованного пользователя наценки могут быть как публичными, так и индивидуальными.
        /// Для неавторизованного - только публичными.
        /// Возможные значения:
        /// "true" - публичная скидка/наценка;
        /// "false" (или отсутствие параметра в пакете) - индивидуальная скидка/наценка (доступно только для авторизованных пользователей)
        /// </summary>
        [JsonPropertyName("public")]
        public bool? Public { get; set; }


        /// <summary>
        /// Массив характеристик заказа, которые инициировали применение скидки.
        /// Параметр выводится в блоке "discountDetails", если такие характеристики есть и скидка была применена
        /// </summary>
        [JsonPropertyName("triggers")]
        public List<Trigger> Triggers { get; set; }
    }
}
