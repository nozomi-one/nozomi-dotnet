// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Nozomi.net.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class UpdateComponentHistoricItemInputModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// UpdateComponentHistoricItemInputModel class.
        /// </summary>
        public UpdateComponentHistoricItemInputModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// UpdateComponentHistoricItemInputModel class.
        /// </summary>
        public UpdateComponentHistoricItemInputModel(System.Guid? guid = default(System.Guid?), System.DateTime? timestamp = default(System.DateTime?), string value = default(string))
        {
            Guid = guid;
            Timestamp = timestamp;
            Value = value;
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
        [JsonProperty(PropertyName = "timestamp")]
        public System.DateTime? Timestamp { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

    }
}
