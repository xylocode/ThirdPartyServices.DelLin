using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using XyloCode.ThirdPartyServices.DelLin.Enums;

namespace XyloCode.ThirdPartyServices.DelLin.LTL.Req
{
    /// <summary>
    /// Наложенный платеж.
    /// </summary>
    public class CashOnDelivery
    {
        /// <summary>
        /// Внутренний номер заказа клиента (например, номер заказа интернет-магазина).
        /// Параметр может быть использован для передачи внутреннего номера заказа не только в случае оплаты наложенным платежом.
        /// При этом соблюдение прочих условий, необходимых для оформления услуги "наложенный платёж", не требуется, см. пример 2 в разделе "Оформление заказа".
        /// </summary>
        [JsonPropertyName("orderNumber")]
        public string OrderNumber {  get; set; }


        /// <summary>
        /// Дата заказа.
        /// Формат: "ГГГГ-ММ-ДД"
        /// </summary>
        [JsonPropertyName("orderDate")]
        public DateOnly? OrderDate {  get; set; }


        /// <summary>
        /// Заявленный вид оплаты.
        /// Доступные значения:
        /// "cash" - оплата наличными
        /// "card" - оплата картой
        /// </summary>
        [JsonPropertyName("paymentType")]
        public PaymentType PaymentType { get; set; }


        /// <summary>
        /// Описание номенклатурного состава груза
        /// </summary>
        [JsonPropertyName("products")]
        public List<Product> Products {  get; set; }
    }
}