using System;
using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.LTL.Req
{
    public class Counteragent
    {
        /// <summary>
        /// UID организационно-правовой формы (ОПФ).
        /// Найти ОПФ можно при помощи метода "Поиск ОПФ" или же метода "Поиск контрагентов" (метод доступен неавторизованным пользователям и позволяет осуществлять поиск по данным ЕГРЮЛ (1) и ЕГРИП (2)) 
        /// При передаче данных об "анонимном" получателе(значение параметра "isAnonym" - "true") в качестве значения параметра необходимо передать UID физического лица РФ ("0xAB91FEEA04F6D4AD48DF42161B6C2E7A").
        /// Передача одного из взаимоисключающих параметров "form" или "customForm" является обязательно.
        /// При этом параметр "customForm" следует использовать только в том случае, если не удалось найти нужную ОПФ в справочнике.
        /// </summary>
        [JsonPropertyName("form")]
        public string Form {  get; set; }


        /// <summary>
        /// ОПФ в форме набора параметров.
        /// Передача одного из взаимоисключающих параметров "form" или "customForm" является обязательно.
        /// При этом параметр "customForm" следует использовать только в том случае, если не удалось найти нужную ОПФ в справочнике.
        /// </summary>
        [JsonPropertyName("customForm")]
        public CustomForm CustomForm {  get; set; }


        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("document")]
        public IdentityDocument Document { get; set; }


        /// <summary>
        /// Признак контрагента - "анонимного" получателя.
        /// Если передано значение "true", оформляется упрощенная отправка.
        /// Передача параметра со значением "true" доступна только для участника перевозки с ролью "Получатель" (блок "Receiver").
        /// Значение по умолчанию: "false"
        /// </summary>
        [JsonPropertyName("isAnonym")]
        public bool? IsAnonym { get; set; }


        /// <summary>
        /// Номер телефона контрагента-"анонимного" получателя.
        /// Формат номера: "7ХХХХХХХХХХ" (11 цифр с ведущей семёркой).
        /// Параметр является обязательным только для контрагента-"анонимного" получателя.
        /// </summary>
        [JsonPropertyName("phone")]
        public string Phone { get; set; }


        /// <summary>
        /// Имя контрагента или название юр. лица
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }


        /// <summary>
        /// ИНН.
        /// Максимальная длина поля зависит от страны и ОПФ.
        /// Параметр является обязательным только для юр.лица (в параметре "form" передан UID ОПФ юр. лица или "customForm.juridical" = "true").
        /// </summary>
        [JsonPropertyName("inn")]
        public string TIN { get; set; }


        /// <summary>
        /// Юридический адрес.
        /// Параметр используется только для юр.лица (в параметре "form" передан UID ОПФ юр.лица или "customForm.juridical" = "true").
        /// </summary>
        [JsonPropertyName("juridicalAddress")]
        public Address JuridicalAddress {  get; set; }


        /// <summary>
        /// Признак сохранения объекта в адресную книгу.
        /// Значение по умолчанию: "false".
        /// Если пользователь не авторизован, то параметр игнорируется
        /// </summary>
        [JsonPropertyName("save")]
        public bool? Save {  get; set; }
    }
}