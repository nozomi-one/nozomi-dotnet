// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Nozomi.net.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class TypeItemViewModel
    {
        /// <summary>
        /// Initializes a new instance of the TypeItemViewModel class.
        /// </summary>
        public TypeItemViewModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TypeItemViewModel class.
        /// </summary>
        public TypeItemViewModel(System.Guid? guid = default(System.Guid?), System.Guid? itemGuid = default(System.Guid?), ItemViewModel item = default(ItemViewModel), System.Guid? typeGuid = default(System.Guid?), TypeViewModel type = default(TypeViewModel))
        {
            Guid = guid;
            ItemGuid = itemGuid;
            Item = item;
            TypeGuid = typeGuid;
            Type = type;
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
        [JsonProperty(PropertyName = "itemGuid")]
        public System.Guid? ItemGuid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "item")]
        public ItemViewModel Item { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "typeGuid")]
        public System.Guid? TypeGuid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public TypeViewModel Type { get; set; }

    }
}
