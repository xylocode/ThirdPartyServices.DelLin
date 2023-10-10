using System;
using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.Calc2.Req
{
    /// <summary>
    /// Заказ разгрузки ТС. Содержит дополнительные параметры, необходимые для расчета погрузо-разгрузочных работ
    /// </summary>
    public class ArrivalUnLoading
    {
        /// <summary>
        /// Уникальные идентификаторы дополнительных параметров, необходимых для расчета погрузо-разгрузочных работ.
        /// Список параметров заполняется на основании "Справочника услуг ПРР".
        /// Если дополнительные параметры не будут переданы в запросе, погрузо-разгрузочные работы будут заказаны, но их стоимость будет рассчитана неточно
        /// </summary>
        [JsonPropertyName("uid")]
        public Guid Uid { get; set; }


        /// <summary>
        /// Значение доп.параметра, если оно необходимо.К примеру, доп.параметр = "этаж", значение = "4"
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
