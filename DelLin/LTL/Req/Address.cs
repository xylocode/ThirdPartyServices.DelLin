using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.LTL.Req
{
    public class Address
    {
        public Address() { }
        public Address(string searchString)
        {
            Search = searchString;
        }

        /// <summary>
        /// Адрес в виде текста или координат.
        /// При передаче адреса в виде текста, помимо собственно адреса (улицы и номера дома), в запрос следует включать наименование населённого пункта, элементы необходимо указывать через запятую, например "Омск, Ленина, 5".
        /// Координаты также указываются через запятую, первое число - широта, например "59.924501, 30.241762".
        /// Помимо собственно адреса, в запрос следует включать наименование населённого пункта.
        /// Максимум - 1024 символа.
        /// </summary>
        [JsonPropertyName("search")]
        public string Search { get; set; }


        /// <summary>
        /// Код КЛАДР улицы.Может быть получен с помощью сервисов, представленных на странице "Поиск КЛАДР"
        /// </summary>
        [JsonPropertyName("street")]
        public string Street { get; set; }


        /// <summary>
        /// Номер дома (2).
        /// Максимальная длина поля: 7 символов
        /// </summary>
        [JsonPropertyName("house")]
        public string House { get; set; }


        /// <summary>
        /// Корпус.
        /// Максимальная длина поля: 5 символов
        /// </summary>
        [JsonPropertyName("building")]
        public string Building { get; set; }


        /// <summary>
        /// Строение.
        /// Максимальная длина поля: 7 символов
        /// </summary>
        [JsonPropertyName("structure")]
        public string Structure { get; set; }


        /// <summary>
        /// Квартира.
        /// Максимальная длина поля: 5 символов
        /// </summary>
        [JsonPropertyName("flat")]
        public string Flat { get; set; }


        /// <summary>
        /// Признак сохранения объекта в адресную книгу.
        /// Значение по умолчанию: "false".
        /// Параметр не используется в блоках "juridicalAddress" класса "Counteragent".
        /// Если пользователь не авторизован, то параметр игнорируется
        /// </summary>
        [JsonPropertyName("save")]
        public bool? Save { get; set; }
    }

}
