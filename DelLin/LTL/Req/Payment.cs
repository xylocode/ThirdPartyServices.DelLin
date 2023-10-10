﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using XyloCode.ThirdPartyServices.DelLin.Enums;

namespace XyloCode.ThirdPartyServices.DelLin.LTL.Req
{
    /// <summary>
    /// Оплата перевозки
    /// </summary>
    public class Payment
    {
        /// <summary>
        /// Вид оплаты.
        /// Возможные значения:
        /// "cash" - оплата наличными или банковской картой;
        /// "noncash" - оплата посредством банковского перевода
        /// </summary>
        [JsonPropertyName("type")]
        public PaymentType? Type { get; set; }

        /// <summary>
        /// Промокод
        /// </summary>
        [JsonPropertyName("promocode")]
        public string Promocode { get; set; }


        /// <summary>
        /// Плательщик по умолчанию.
        /// Указанный плательщик оплачивает основную услугу (межтерминальную перевозку) и все прочие услуги, если по ним не указаны иные плательщики.
        /// Доступные значения:
        /// "sender" - отправитель;
        /// "receiver" - получатель;
        /// "third" - третье лицо.
        /// </summary>
        [JsonPropertyName("primaryPayer")]
        public RoleType? PrimaryPayer {  get; set; }


        /// <summary>
        /// Код КЛАДР населённого пункта оплаты (1).
        /// Может быть получен с помощью сервисов, представленных на странице "Поиск КЛАДР".
        /// Если один из плательщиков - третье лицо, то один из взаимоисключающих параметров "paymentCity" или "paymentCitySearch" является обязательным, в противном случае параметр игнорируется. 
        /// </summary>
        [JsonPropertyName("paymentCity")]
        public string PaymentCity { get; set; }


        /// <summary>
        /// Населённый пункт в виде произвольной строки.
        /// Максимум - 1024 символа.
        /// Помимо наименования населённого пункта, в строке может быть передано наименование страны, региона, района - это позволит уточнить поиск и исключить ошибки, которые могут возникнуть из-за одинаковых названий населённых пунктов
        /// </summary>
        [JsonPropertyName("paymentCitySearch")]
        public Models.Search PaymentCitySearch { get; set; }


        /// <summary>
        /// Наложенный платеж.
        /// Оформление услуги возможно только при соблюдении следующих условий:
        /// Заказчик является юридическим лицом, которому доступна услуга "Наложенный платёж" (для получения разрешения на использование услуги необходимо обратиться к менеджеру компании "Деловые Линии").
        /// Заказчик выступает в роли отправителя(значение параметра "members.requester.role" - "sender".
        /// Получатель является физическим лицом.
        /// В запросе должен быть передан параметр "cashOnDelivery.products".
        /// Если параметр не передан, то услуга "Наложенный платёж" оформлена не будет, однако объект можно будет использовать для передачи внутреннего номера заказа клиента (см.описание параметра "cashOnDelivery.orderNumber").
        /// При оформлении услуги невозможна доставка до аэропорта / до адреса получателя от аэропорта.
        /// В настоящий момент допускается передача только одного элемента в массив "CashOnDelivery", прочие переданные элементы игнорируются.
        /// Если пользователь не авторизован, то параметр игнорируется.
        /// </summary>
        [JsonPropertyName("cashOnDelivery")]
        public List<CashOnDelivery> CashOnDelivery { get; set; }
    }
}
