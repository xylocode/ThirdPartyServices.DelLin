using System.Collections.Generic;
using System.Text.Json.Serialization;
using XyloCode.ThirdPartyServices.DelLin.Enums;
using XyloCode.ThirdPartyServices.DelLin.Requests;

namespace XyloCode.ThirdPartyServices.DelLin.PackagingMarks
{
    public class PackagingMarksRequest : Request
    {
        /// <summary>
        /// Тип файла с этикетками.
        /// Доступные значения: jpg, pdf, png.
        /// Значение по умолчанию - pdf
        /// </summary>
        [JsonPropertyName("type")]
        public FileExt? Type { get; set; }


        /// <summary>
        /// Флаг, позволяющий выбрать, сформировать один многостраничный документ(по одной этикетке на страницу) или сформировать отдельные файлы.
        /// Доступные значения:
        /// true - cформировать один многостраничный документ.
        /// Передача значения возможна, только если значение параметра "type" - "pdf";
        /// false - сформировать отдельные файлы.
        /// Значение по умолчанию - false
        /// </summary>
        [JsonPropertyName("oneFile")]
        public bool? OneFile { get; set; }


        /// <summary>
        /// Количество ссылок на файлы с этикетками на странице.
        /// Максимальное значение - 50.
        /// Значение по умолчанию - 30
        /// </summary>
        [JsonPropertyName("per")]
        public int? Per { get; set; }


        /// <summary>
        /// Номер страницы со ссылками на файлы с этикетками. 
        /// Значение по умолчанию - 1
        /// </summary>
        [JsonPropertyName("page")]
        public int? Page { get; set; }


        /// <summary>
        /// Параметры массива этикеток
        /// </summary>
        [JsonPropertyName("packagingMarks")]
        public List<MarkRequest> PackagingMarks { get; set; }
    }


    public class MarkRequest
    {
        /// <summary>
        /// Тип упаковки.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }


        /// <summary>
        /// Размер этикетки.
        /// Доступные значения: 80x50, a4.
        /// Значение по умолчанию - 80х50
        /// </summary>
        [JsonPropertyName("format")]
        public string Format { get; set; }


        /// <summary>
        /// Количество этикеток
        /// </summary>
        [JsonPropertyName("count")]
        public int? Count { get; set; }
    }
}
