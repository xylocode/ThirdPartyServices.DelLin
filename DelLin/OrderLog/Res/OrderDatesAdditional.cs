using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.OrderLog.Res
{
    /// <summary>
    /// Информация о промежуточных точках маршрута перевозки.
    /// </summary>
    public class OrderDatesAdditional
    {
        /// <summary>
        /// Список промежуточных точек маршрута перевозки.
        /// Максимальное число элементов массива - 10.
        /// Если промежуточных точек больше 10, то в ответе метода будет представлена информация по 10 последним точкам маршрута.
        /// </summary>
        [JsonPropertyName("tracing")]
        public List<Tracing> Tracing { get; set; }
    }

}
