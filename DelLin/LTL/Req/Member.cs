﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.LTL.Req
{
    public class Member
    {
        /// <summary>
        /// ID контрагента из "Адресной книги".
        /// Если пользователь не авторизован, то параметр игнорируется.
        /// Если пользователь авторизован, то передача одного из взаимоисключающих параметров "counteragentID" или "counteragent" является обязательной
        /// </summary>
        [JsonPropertyName("counteragentID")]
        public int? CounteragentID { get; set; }


        /// <summary>
        /// Контрагент в форме набора параметров.
        /// Если пользователь не авторизован, то параметр является обязательным.
        /// Если пользователь авторизован, то обязательной является передача одного из взаимоисключающих параметров "counteragentID" или "counteragent"
        /// </summary>
        [JsonPropertyName("counteragent")]
        public Counteragent Counteragent { get; set; }


        /// <summary>
        /// Список ID контактных лиц из "Адресной книги".
        /// Максимальное количество элементов в массиве - 3.
        /// Параметр игнорируется для контрагента-"анонимного" получателя.
        /// Также параметр игнорируется, если пользователь не авторизован.
        /// Если пользователь авторизован и контрагент не является анонимным получателем, то передача одного из взаимоисключающих параметров "contactID" или "contactPersons" является обязательной
        /// </summary>
        [JsonPropertyName("contactIDs")]
        public List<int?> ContactIDs { get; set; }


        /// <summary>
        /// Список контактных лиц.
        /// Для авторизованных пользователей максимальное количество элементов в массиве - 3, для неавторизованных - 1.
        /// Параметр игнорируется для контрагента-"анонимного" получателя
        /// Если пользователь не авторизован, то параметр является обязательным.
        /// Если пользователь авторизован и контрагент не является анонимным получателем, то обязательной является передача одного из взаимоисключающих параметров "counteragentID" или "counteragent"
        /// </summary>
        [JsonPropertyName("contactPersons")]
        public List<ContactPerson> ContactPersons { get; set; }


        /// <summary>
        /// Список ID телефонных номеров из "Адресной книги".
        /// Максимальное количество элементов в массиве - 3. 
        /// Параметр игнорируется для контрагента-"анонимного" получателя.
        /// Также параметр игнорируется, если пользователь не авторизован.
        /// Если пользователь авторизован и контрагент не является анонимным получателем, то передача одного из взаимоисключающих параметров "phoneIDs" или "phoneNumbers" является обязательной
        /// </summary>
        [JsonPropertyName("phoneIDs")]
        public List<int?> PhoneIDs { get; set; }


        /// <summary>
        /// Список телефонных номеров.
        /// Для авторизованных пользователей максимальное количество элементов в массиве - 3, для неавторизованных - 1.
        /// Параметр игнорируется для контрагента-"анонимного" получателя.
        /// Если пользователь не авторизован, то параметр является обязательным.
        /// Если пользователь авторизован и контрагент не является анонимным получателем, то обязательной является передача одного из взаимоисключающих параметров "phoneIDs" или "phoneNumbers"
        /// </summary>
        [JsonPropertyName("phoneNumbers")]
        public List<PhoneNumber> PhoneNumbers { get; set; }



        /// <summary>
        /// Email для отправки уведомлений участнику перевозки
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }


        /// <summary>
        /// Контактные данные для отправки электронного чека плательщику-физическому лицу.
        /// Параметр обязателен для контрагента-физического лица, являющегося плательщиком и не являющегося "анонимным" получателем.
        /// Для контрагента-"анонимного" получателя и для контрагента-юридического лица параметр не является обязательным и игнорируется.
        /// </summary>
        [JsonPropertyName("dataForReceipt")]
        public DataForReceipt DataForReceipt { get; set; }
    }
}
