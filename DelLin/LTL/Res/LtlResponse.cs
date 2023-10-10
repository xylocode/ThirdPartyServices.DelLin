using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.LTL.Res
{
    public class LtlResponse
    {
        /// <summary>
        /// Статус обработки запроса
        /// </summary>
        [JsonPropertyName("state")]
        public string State { get; set; }


        /// <summary>
        /// Номер созданного предзаказа или заявки
        /// </summary>
        [JsonPropertyName("requestID")]
        public int? RequestID { get; set; }


        /// <summary>
        /// Информационное сообщение. Отображается, например, если в запросе был передан промокод, но применить его по какой-то причине невозможно
        /// </summary>
        [JsonPropertyName("information")]
        public List<string> Information { get; set; }


        /// <summary>
        /// Barcode для формирования штрихкода по алгоритму Code 128, если оформлен предзаказ (то есть, если значение параметра запроса "delivery.derival.variant" - "terminal")
        /// </summary>
        [JsonPropertyName("barcode")]
        public string Barcode { get; set; }


        /// <summary>
        /// Информация о сохранении данных в адресную книгу.
        /// Если пользователь не авторизован, то параметр отсутствует в ответе.
        /// </summary>
        [JsonPropertyName("addressBook")]
        public AddressBook AddressBook { get; set; }


        /// <summary>
        /// Данные по найденным адресам / населённым пунктам.Параметр присутствует в ответе, только если в запросе был передан параметр "search" класса "Address" или параметр "payment.paymentCitySearch.search".
        /// </summary>
        [JsonPropertyName("foundAddresses")]
        public List<FoundAddress> FoundAddresses { get; set; }
    }
}
