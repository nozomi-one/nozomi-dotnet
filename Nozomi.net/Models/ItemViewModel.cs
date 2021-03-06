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

    public partial class ItemViewModel
    {
        /// <summary>
        /// Initializes a new instance of the ItemViewModel class.
        /// </summary>
        public ItemViewModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ItemViewModel class.
        /// </summary>
        public ItemViewModel(System.Guid? guid = default(System.Guid?), string logoPath = default(string), string abbreviation = default(string), string slug = default(string), string name = default(string), int? denominations = default(int?), string denominationName = default(string), IList<ItemPropertyViewModel> properties = default(IList<ItemPropertyViewModel>), IList<ItemSourceViewModel> sources = default(IList<ItemSourceViewModel>), IList<TypeItemViewModel> types = default(IList<TypeItemViewModel>), IList<RequestViewModel> requests = default(IList<RequestViewModel>))
        {
            Guid = guid;
            LogoPath = logoPath;
            Abbreviation = abbreviation;
            Slug = slug;
            Name = name;
            Denominations = denominations;
            DenominationName = denominationName;
            Properties = properties;
            Sources = sources;
            Types = types;
            Requests = requests;
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
        [JsonProperty(PropertyName = "logoPath")]
        public string LogoPath { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abbreviation")]
        public string Abbreviation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slug")]
        public string Slug { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "denominations")]
        public int? Denominations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "denominationName")]
        public string DenominationName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public IList<ItemPropertyViewModel> Properties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sources")]
        public IList<ItemSourceViewModel> Sources { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "types")]
        public IList<TypeItemViewModel> Types { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "requests")]
        public IList<RequestViewModel> Requests { get; set; }

    }
}
