using System;
using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.LTL.Req
{
    /// <summary>
    /// ОПФ в форме набора параметров.
    /// </summary>
    public class CustomForm
    {
        public CustomForm() { }
        public CustomForm(string name, bool isJuridical)
        {
            FormName = name;
            Juridical = isJuridical;

            // Россия
            CountryUID = "0x8f51001438c4d49511dbd774581edb7a";
        }

        /// <summary>
        /// Название ОПФ в текстовом формате.
        /// Максимальная длина поля: 35 символов
        /// </summary>
        [JsonPropertyName("formName")]
        public string FormName {  get; set; }


        /// <summary>
        /// UID страны, см. метод "Поиск стран"
        /// </summary>
        [JsonPropertyName("countryUID")]
        public string CountryUID {  get; set; }


        /// <summary>
        /// Признак юридического лица
        /// </summary>
        [JsonPropertyName("juridical")]
        public bool Juridical {  get; set; }
    }
}