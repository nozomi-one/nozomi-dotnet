// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Nozomi.net.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class ComponentViewModel
    {
        /// <summary>
        /// Initializes a new instance of the ComponentViewModel class.
        /// </summary>
        public ComponentViewModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ComponentViewModel class.
        /// </summary>
        public ComponentViewModel(System.Guid? guid = default(System.Guid?), long? type = default(long?), string value = default(string), string identifier = default(string), string query = default(string), bool? isDenominated = default(bool?), IList<ComponentHistoricItemViewModel> history = default(IList<ComponentHistoricItemViewModel>))
        {
            Guid = guid;
            Type = type;
            Value = value;
            Identifier = identifier;
            Query = query;
            IsDenominated = isDenominated;
            History = history;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "guid")]
        public System.Guid? Guid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public long? Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "identifier")]
        public string Identifier { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "query")]
        public string Query { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isDenominated")]
        public bool? IsDenominated { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "history")]
        public IList<ComponentHistoricItemViewModel> History { get; set; }

    }
}