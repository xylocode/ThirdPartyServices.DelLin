using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.Responses
{
    public class FileResponse
    {
        /// <summary>
        /// Хеш-код файла (MD5). Путём сравнения хеш-кодов двух файлов, полученных в разное время, можно понять, изменились данные в справочнике или нет.
        /// </summary>
        [JsonPropertyName("hash")]
        public string Hash { get; set; }

        /// <summary>
        /// Ссылка на файл с данными справочника в формате json.
        /// </summary>
        [JsonPropertyName("url")]
        public string URL { get; set; }
    }
}
