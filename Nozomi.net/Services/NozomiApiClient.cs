// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

using System.Collections.Generic;
using System.Net.Http;
using Microsoft.Rest;
using Microsoft.Rest.Serialization;
using Newtonsoft.Json;
using Nozomi.net.Constants;

namespace Nozomi.net.Services
{
    public partial class NozomiApiClient : ServiceClient<NozomiApiClient>, INozomiAPI
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        public System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        public JsonSerializerSettings SerializationSettings { get; private set; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        public JsonSerializerSettings DeserializationSettings { get; private set; }
        
        /// <summary>
        /// Gets or sets the Http Response message.
        /// </summary>
        public HttpResponseMessage HttpResponseMessage { get; set; }

        /// <summary>
        /// Gets the IComponent.
        /// </summary>
        public virtual IComponent Component { get; private set; }

        /// <summary>
        /// Gets the IComponentHistoricItem.
        /// </summary>
        public virtual IComponentHistoricItem ComponentHistoricItem { get; private set; }

        /// <summary>
        /// Gets the IComponentType.
        /// </summary>
        public virtual IComponentType ComponentType { get; private set; }

        /// <summary>
        /// Gets the ICompute.
        /// </summary>
        public virtual ICompute Compute { get; private set; }

        /// <summary>
        /// Gets the IComputeExpression.
        /// </summary>
        public virtual IComputeExpression ComputeExpression { get; private set; }

        /// <summary>
        /// Gets the IComputeValue.
        /// </summary>
        public virtual IComputeValue ComputeValue { get; private set; }

        /// <summary>
        /// Gets the IConnect.
        /// </summary>
        public virtual IConnect Connect { get; private set; }

        /// <summary>
        /// Gets the IItem.
        /// </summary>
        public virtual IItem Item { get; private set; }

        /// <summary>
        /// Gets the IRequest.
        /// </summary>
        public virtual IRequest Request { get; private set; }

        /// <summary>
        /// Gets the IRequestProperty.
        /// </summary>
        public virtual IRequestProperty RequestProperty { get; private set; }

        /// <summary>
        /// Gets the ISubCompute.
        /// </summary>
        public virtual ISubCompute SubCompute { get; private set; }

        /// <summary>
        /// Gets the IWebsocketCommand.
        /// </summary>
        public virtual IWebsocketCommand WebsocketCommand { get; private set; }

        /// <summary>
        /// Gets the IWebsocketCommandProperty.
        /// </summary>
        public virtual IWebsocketCommandProperty WebsocketCommandProperty { get; private set; }

        /// <summary>
        /// Initializes a new instance of the NozomiApiClient class.
        /// </summary>
        /// <param name='httpClient'>
        /// HttpClient to be used
        /// </param>
        /// <param name='disposeHttpClient'>
        /// True: will dispose the provided httpClient on calling NozomiApiClient.Dispose(). False: will not dispose provided httpClient</param>
        public NozomiApiClient(HttpClient httpClient, bool disposeHttpClient) : base(httpClient, disposeHttpClient)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the NozomiApiClient class.
        /// </summary>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        public NozomiApiClient(params DelegatingHandler[] handlers) : base(handlers)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the NozomiApiClient class.
        /// </summary>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        public NozomiApiClient(HttpClientHandler rootHandler, params DelegatingHandler[] handlers) 
            : base(rootHandler, handlers)
        {
            Initialize();
        }

        /// <summary>
        /// An optional partial-method to perform custom initialization.
        ///</summary>
        private void CustomInitialize()
        {
            // Initialise the response message first.
            HttpResponseMessage = new HttpResponseMessage();
        }
        
        /// <summary>
        /// Initializes client properties.
        /// </summary>
        private void Initialize()
        {
            Component = new ComponentService(this);
            ComponentHistoricItem = new ComponentHistoricItemService(this);
            ComponentType = new ComponentTypeService(this);
            Compute = new ComputeService(this);
            ComputeExpression = new ComputeExpression(this);
            ComputeValue = new ComputeValueService(this);
            Connect = new Connect(this);
            Item = new Item(this);
            Request = new Request(this);
            RequestProperty = new RequestProperty(this);
            SubCompute = new SubCompute(this);
            WebsocketCommand = new WebsocketCommand(this);
            WebsocketCommandProperty = new WebsocketCommandProperty(this);
            BaseUri = new System.Uri(NozomiConstants.ApiBaseUrl);
            SerializationSettings = new JsonSerializerSettings
            {
                Formatting = Newtonsoft.Json.Formatting.Indented,
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new  List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            DeserializationSettings = new JsonSerializerSettings
            {
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            CustomInitialize();
        }
    }
}
