using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using XyloCode.ThirdPartyServices.DelLin.Enums;
using XyloCode.ThirdPartyServices.DelLin.Requests;

namespace XyloCode.ThirdPartyServices.DelLin.OrderLog
{
    public class OrderLogRequest : Request
    {
        /// <summary>
        /// Номер заказа, накладной или заявки.
        /// Возможна передача нескольких параметров.
        /// Максимум может быть передано 5 значений.
        /// Параметр используется для поиска заказа.
        /// Если в запросе отсутствует параметр "sessionID", то в нём должен присутствовать один из следующих параметров: "docIds", "orderNumber" или "barcode".
        /// В запросе может быть передан только один из параметров: "docIds", "orderNumber", "barcode", "cargoPlaces", "shipmentLabelCargoPlace".
        /// </summary>
        [JsonPropertyName("docIds")]
        public List<string> DocIds { get; set; }


        /// <summary>
        /// Номер заказа интернет-магазина (внутренний номер заказа, ВНЗ).
        /// Параметр используется для поиска заказа.
        /// Если в запросе отсутствует параметр "sessionID", то в нём должен присутствовать один из следующих параметров: "docIds", "orderNumber" или "barcode".
        /// </summary>
        [JsonPropertyName("orderNumber")]
        public string OrderNumber { get; set; }


        /// <summary>
        /// Дата заказа интернет-магазина.
        /// Формат: "ГГГГ-ММ-ДД".
        /// </summary>
        [JsonPropertyName("orderDate")]
        public DateOnly? OrderDate { get; set; }


        /// <summary>
        /// Штрих-код, считанный сканером.
        /// Для поиска заказа могут быть использованы следующие штрих-коды:
        /// штрих-код накладной;
        /// штрих-код накладной экспедитора(документ используется водителем-экспедитором при получении груза на адресе отправителя);
        /// штрих-код заявки на доставку груза, оформленной при размещении предзаказа;
        /// штрих-код, считанный с этикетки на грузе(код документа "Накладная" с указанием грузоместа).
        /// Параметр используется для поиска заказа.Если в запросе отсутствует параметр "sessionID", то в нём должен присутствовать один из следующих параметров: "docIds", "orderNumber" или "barcode".
        /// В запросе может быть передан только один из параметров: "docIds", "orderNumber", "barcode", "cargoPlaces", "shipmentLabelCargoPlace".
        /// </summary>
        [JsonPropertyName("barcode")]
        public string Barcode { get; set; }


        /// <summary>
        /// Массив номеров грузовых мест.
        /// Параметр используется для поиска заказа авторизованными пользователями (может быть передан, только если в запросе присутствует параметр "sessionID").
        /// В запросе может быть передан только один из параметров: "docIds", "orderNumber", "barcode", "cargoPlaces", "shipmentLabelCargoPlace".
        /// Поиск производится только по первому значению, переданному в массиве.
        /// </summary>
        [JsonPropertyName("cargoPlaces")]
        public List<string> CargoPlaces { get; set; }


        /// <summary>
        /// Артикул грузового места.
        /// Параметр используется для поиска заказа авторизованными пользователями (может быть передан, только если в запросе присутствует параметр "sessionID").
        /// Чтобы иметь возможность искать заказы по артикулу грузового места, необходимо сначала передать информацию о грузовых местах при помощи метода "Передача артикулов грузовых мест".
        /// Пользователи с ограниченным доступом могут осуществлять поиск только по тем заказам, где они выступают в роли заказчика, пользователи с полным доступом - по всем заказам, независимо от роли(подробнее о доступе см. метод "Список контрагентов", описание параметра ответа "info.accessLevel").
        /// Если заказана доставка груза от адреса отправителя и груз ещё не был принят к перевозке на терминале компании, то информация по грузу доступна только тому пользователю, который оформил заказ.
        /// В запросе может быть передан только один из параметров: "docIds", "orderNumber", "barcode", "cargoPlaces", "shipmentLabelCargoPlace".
        /// </summary>
        [JsonPropertyName("shipmentLabelCargoPlace")]
        public string ShipmentLabelCargoPlace { get; set; }


        /// <summary>
        /// Начальная дата и время периода(для фильтрации результатов поиска по периоду создания заказа).
        /// Формат: "ГГГГ-ММ-ДД ЧЧ:ММ:СС".
        /// Значение параметра учитывается, только если в запросе есть параметр "sessionID", но нет параметров "docIds", "orderNumber", "barcode", "cargoPlaces" или "shipmentLabelCargoPlace".
        /// </summary>
        [JsonPropertyName("dateStart")]
        public DateTime? DateStart { get; set; }


        /// <summary>
        /// Конечная дата и время периода (для фильтрации результатов поиска по периоду создания заказа. Учитывается при указании параметра "dateStart").
        /// Формат: "ГГГГ-ММ-ДД ЧЧ:ММ:СС".
        /// Значение параметра учитывается, только если в запросе есть параметр "sessionID", но нет параметров "docIds", "orderNumber", "barcode", "cargoPlaces" или "shipmentLabelCargoPlace".
        /// </summary>
        [JsonPropertyName("dateEnd")]
        public DateTime? DateEnd { get; set; }


        /// <summary>
        /// Список статусов, заказы с которыми надо получить в ответе.Статусы указываются на основании "Справочника статусов заказа груза".
        /// Значение параметра учитывается, только если в запросе есть параметр "sessionID", но нет параметров "docIds", "orderNumber", "barcode", "cargoPlaces" или "shipmentLabelCargoPlace".
        /// </summary>
        [JsonPropertyName("states")]
        public List<string> States { get; set; }


        /// <summary>
        /// Номер запрашиваемой страницы ответа.
        /// </summary>
        [JsonPropertyName("page")]
        public int? Page { get; set; }


        /// <summary>
        /// Фильтр для поиска заказов, изменившихся в период, начиная с указанного в данном параметре момента времени.
        /// Формат: "ГГГГ-ММ-ДД ЧЧ:ММ:СС".
        /// Значение параметра учитывается, только если в запросе есть параметр "sessionID", но нет параметров "docIds", "orderNumber", "barcode", "cargoPlaces" или "shipmentLabelCargoPlace".
        /// Если в запросе передан параметр "states" со значением "inway", то в ответ будут включены все заказы в статусе "inway", не зависимо от значения параметра "lastUpdate" (для прочих статусов действует иная логика - в ответ включаются заказы в указанных статусах, обновлённые после даты, переданной в параметре "lastUpdate").
        /// </summary>
        [JsonPropertyName("lastUpdate")]
        public DateTime? LastUpdate { get; set; }

        /// <summary>
        /// Сортировка заказов.
        /// Возможные значения:
        /// ordered_at - по дате заказа;
        /// updated_at - по дате обновления.
        /// Значение параметра учитывается, только если в запросе есть параметр "sessionID", но нет параметров "docIds", "orderNumber", "barcode", "cargoPlaces" или "shipmentLabelCargoPlace".
        /// </summary>
        [JsonPropertyName("orderBy")]
        public OrderSortOrderBy? OrderBy { get; set; }


        /// <summary>
        /// Флаг, обозначающий, что необходима информация о промежуточных точках маршрута перевозки
        /// </summary>
        [JsonPropertyName("orderDatesAdditional")]
        public bool? OrderDatesAdditional { get; set; }

    }
}
