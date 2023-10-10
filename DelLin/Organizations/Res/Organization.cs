using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.Organizations.Res
{
    public class Organization
    {
        /// <summary>
        /// Информация о движении денежных средств контрагента.
        /// Если взаиморасчетов не производилось, значение параметра - null.
        /// Параметр присутствует в ответе, только если в запросе метода был передан параметр "fullInfo" со значением "true"
        /// </summary>
        [JsonPropertyName("balance")]
        public Reconciliation Balance { get; set; }

        /// <summary>
        /// Полная информация о контрагентах.
        /// Параметр присутствует в ответе, только если в запросе метода был передан параметр "fullInfo" со значением "true"
        /// </summary>
        [JsonPropertyName("info")]
        public CounteragentInfo Info { get; set; }

        /// <summary>
        /// Признак выбранного контрагента.
        /// Если в запросе был передан параметр "cauid", то в ответе у контрагента, UID которого был передан в запросе, значение параметра "isCurrent" будет равно "true"
        /// </summary>
        [JsonPropertyName("isCurrent")]
        public bool? IsCurrent { get; set; }

        /// <summary>
        /// Уникальный идентификатор контрагента
        /// </summary>
        [JsonPropertyName("uid")]
        public Guid? Uid { get; set; }


        /// <summary>
        /// Признак юридического лица
        /// Возможные значения:
        /// "true" - юридическое лицо;
        /// "false" - физическое лиц.
        /// Параметр присутствует в ответе, только если в запросе метода был передан параметр "fullInfo" со значением "true"
        /// </summary>
        [JsonPropertyName("juridical")]
        public bool? Juridical { get; set; }


        /// <summary>
        /// ИНН (для юридических лиц), если контрагент является физическим лицом (значение параметра "juridical" - "false"), то значение параметра - null.
        /// Параметр присутствует в ответе, только если в запросе метода был передан параметр "fullInfo" со значением "true"
        /// </summary>
        [JsonPropertyName("inn")]
        public string Inn { get; set; }

        /// <summary>
        /// Данные документа, удостоверяющего личность(для физических лиц), если контрагент является юридическим лицом(значение параметра "juridical" - "true"), то значение параметра - null.
        /// Параметр присутствует в ответе, только если в запросе метода был передан параметр "fullInfo" со значением "true"
        /// </summary>
        [JsonPropertyName("document")]
        public IdentityDocument Document { get; set; }


        /// <summary>
        /// Имя/наименование контрагента
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Признак возможности оформления контрагентом заказа с наложенным платежом
        /// </summary>
        [JsonPropertyName("cashOnDeliveryAvailable")]
        public bool? CashOnDeliveryAvailable { get; set; }
    }

    /// <summary>
    /// Полная информация о контрагентах.
    /// </summary>
    public class CounteragentInfo
    {
        /// <summary>
        /// Данные пользователей, которым предоставлен доступ к учетной записи ЛК
        /// </summary>
        [JsonPropertyName("sharedTo")]
        public List<User> SharedTo { get; set; }


        /// <summary>
        /// Уровень предоставленного доступа.
        /// Возможные значения:
        /// 0 = запрос доступа;
        /// 1 = запрос отклонён;
        /// 2 = полный доступ;
        /// 3 = частичный доступ
        /// </summary>
        [JsonPropertyName("accessLevel")]
        public int? AccessLevel { get; set; }


        /// <summary>
        /// Комментарий при отклонении доступа
        /// </summary>
        [JsonPropertyName("requestComment")]
        public string RequestComment { get; set; }

        /// <summary>
        /// Электронная почта менеджера клиента
        /// </summary>
        [JsonPropertyName("managerEmail")]
        public string ManagerEmail { get; set; }


        /// <summary>
        /// Контактный телефон менеджера клиента
        /// </summary>
        [JsonPropertyName("managerPhone")]
        public string ManagerPhone { get; set; }

        /// <summary>
        /// Данные пользователя, который предоставил доступ к учетной записи ЛК
        /// </summary>
        [JsonPropertyName("sharedFrom")]
        public User SharedFrom { get; set; }

        /// <summary>
        /// ФИО менеджера клиента
        /// </summary>
        [JsonPropertyName("managerName")]
        public string ManagerName { get; set; }
    }
}
