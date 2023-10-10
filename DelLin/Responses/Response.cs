using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.Responses
{
    /// <summary>
    /// Ответ сервера на запрос
    /// </summary>
    /// <typeparam name="T">Тип ответа</typeparam>
    public class Response<T>
    {
        /// <summary>
        /// Системная информация
        /// </summary>
        [JsonPropertyName("metadata")]
        public MetaData MetaData { get; set; }


        /// <summary>
        /// Статус процесса формирования этикеток.
        /// Возможные значения:
        /// enqueued - запрос отправлен;
        /// processed - запрос выполнен.
        /// </summary>
        [JsonPropertyName("state")]
        public string State {  get; set; }


        /// <summary>
        /// Данные
        /// </summary>
        [JsonPropertyName("data")]
        public T Data { get; set; }


        /// <summary>
        /// Ошибки, возникшие при выполнении запроса.
        /// </summary>
        [JsonPropertyName("errors")]
        public List<Error> Errors { get; set; }
    }


    /// <summary>
    /// Системная информация
    /// </summary>
    public class MetaData
    {
        /// <summary>
        /// Эмуляция http-кода состояния.
        /// В случае успешного выполнения возвращается код "200" (OK).
        /// </summary>
        [JsonPropertyName("status")]
        public int? Status { get; set; }


        /// <summary>
        /// Дата и время генерации ответа сервера.
        /// Формат: "ГГГГ-ММ-ДД ЧЧ:ММ:СС"
        /// </summary>
        [JsonPropertyName("generated_at")]
        public DateTime? GeneratedAt { get; set; }


        /// <summary>
        /// Номер текущей страницы со ссылками.
        /// Значение номера будет отличаться от 1, только если было выбрано формирование отдельных файлов и были запрошены данные по конкретной странице.
        /// </summary>
        [JsonPropertyName("current_page")]
        public int? CurrentPage { get; set; }


        /// <summary>
        /// Номер следующей страницы.
        /// При формировании отдельных файлов значение будет отличаться от 2, только если были запрошены данные по конкретной странице.
        /// При формировании многостраничного документа выводится значение "null".
        /// </summary>
        [JsonPropertyName("next_page")]
        public int? NextPage { get; set; }


        /// <summary>
        /// Номер предыдущей страницы.
        /// Значение будет отличаться от "null", только если были запрошены данные по конкретной странице.
        /// </summary>
        [JsonPropertyName("prev_page")]
        public int? PrevPage { get; set; }


        /// <summary>
        /// Общее количество страниц со ссылками.
        /// При формировании многостраничного документа значение всегда равно 1.
        /// </summary>
        [JsonPropertyName("total_pages")]
        public int? TotalPages { get; set; }
    }


    /// <summary>
    /// Ошибки методов API.
    /// </summary>
    public class Error
    {
        /// <summary>
        /// Номер ошибки.
        /// </summary>
        [JsonPropertyName("code")]
        public int? Code { get; set; }


        /// <summary>
        /// Краткое описание ошибки.
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }


        /// <summary>
        /// Детальное описание ошибки.
        /// </summary>
        [JsonPropertyName("detail")]
        public string Detail { get; set; }


        /// <summary>
        /// Ссылка на документацию.
        /// </summary>
        [JsonPropertyName("link")]
        public string Link { get; set; }


        /// <summary>
        /// Список параметров в запросе к методу, вызвавших ошибку.
        /// </summary>
        [JsonPropertyName("fields")]
        public List<string> Fields { get; set; }


        /// <summary>
        /// Список доступных значений параметра.
        /// </summary>
        [JsonPropertyName("validValues")]
        public List<string> ValidValues { get; set; }


        /// <summary>
        /// Список ошибочных значений, переданных в параметре.
        /// </summary>
        [JsonPropertyName("badValues")]
        public List<string> BadValues { get; set; }
    }
}
