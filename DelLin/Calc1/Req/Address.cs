using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.Calc1.Req
{
    public class Address
    {
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


        public Address() { }
        public Address(string search) { this.Search = search; }
    }

}
