// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using Microsoft.Rest;
using Microsoft.Rest.Serialization;
using Newtonsoft.Json;
using Nozomi.net.Constants;
using Nozomi.net.Interfaces;
using Nozomi.net.Services;

namespace Nozomi.net
{
    public partial class NozomiApiClient : ServiceClient<NozomiApiClient>, INozomiAPI
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        public System.Uri BaseUri { get; set; }
        
        /// <summary>
        /// The API Key issued by Nozomi for usage.
        /// </summary>
        public string ApiKey { get; set; }

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
        public virtual IComponentService ComponentService { get; private set; }

        /// <summary>
        /// Gets the IComponentHistoricItemService.
        /// </summary>
        public virtual IComponentHistoricItemService ComponentHistoricItemService { get; private set; }

        /// <summary>
        /// Gets the IComponentTypeService.
        /// </summary>
        public virtual IComponentTypeService ComponentTypeService { get; private set; }

        /// <summary>
        /// Gets the IComputeService.
        /// </summary>
        public virtual IComputeService ComputeService { get; private set; }

        /// <summary>
        /// Gets the IComputeExpressionService.
        /// </summary>
        public virtual IComputeExpressionService ComputeExpressionService { get; private set; }

        /// <summary>
        /// Gets the IComputeValueService.
        /// </summary>
        public virtual IComputeValueService ComputeValueService { get; private set; }

        /// <summary>
        /// Gets the IConnectService.
        /// </summary>
        public virtual IConnectService ConnectService { get; private set; }

        /// <summary>
        /// Gets the IItemService.
        /// </summary>
        public virtual IItemService ItemService { get; private set; }

        /// <summary>
        /// Gets the IRequestService.
        /// </summary>
        public virtual IRequestService RequestService { get; private set; }

        /// <summary>
        /// Gets the IRequestPropertyService.
        /// </summary>
        public virtual IRequestPropertyService RequestPropertyService { get; private set; }

        /// <summary>
        /// Gets the ISubComputeService.
        /// </summary>
        public virtual ISubComputeService SubComputeService { get; private set; }

        /// <summary>
        /// Gets the IWebsocketCommandService.
        /// </summary>
        public virtual IWebsocketCommandService WebsocketCommandService { get; private set; }

        /// <summary>
        /// Gets the IWebsocketCommandPropertyService.
        /// </summary>
        public virtual IWebsocketCommandPropertyService WebsocketCommandPropertyService { get; private set; }

        /// <summary>
        /// Initializes a new instance of the NozomiApiClient class.
        /// </summary>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        public NozomiApiClient(string apiKey, params DelegatingHandler[] handlers) : base(handlers)
        {
            ApiKey = apiKey;
            Initialize();
            InitializeServices();
        }

        /// <summary>
        /// Initializes a new instance of the NozomiApiClient class.
        /// </summary>
        /// <param name='httpClient'>
        /// HttpClient to be used
        /// </param>
        /// <param name='disposeHttpClient'>
        /// True: will dispose the provided httpClient on calling NozomiApiClient.Dispose().
        /// False: will not dispose provided httpClient</param>
        public NozomiApiClient(string apiKey, HttpClient httpClient, bool disposeHttpClient) 
            : base(httpClient, disposeHttpClient)
        {
            ApiKey = apiKey;
            Initialize();
            InitializeServices();
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
        public NozomiApiClient(string apiKey, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) 
            : base(rootHandler, handlers)
        {
            ApiKey = apiKey;
            Initialize();
            InitializeServices();
        }

        private void InitializeServices()
        {
            ComponentService = new ComponentService(this);
            ComponentHistoricItemService = new ComponentHistoricItemService(this);
            ComponentTypeService = new ComponentTypeService(this);
            ComputeService = new ComputeService(this);
            ComputeExpressionService = new ComputeExpressionService(this);
            ComputeValueService = new ComputeValueService(this);
            ConnectService = new ConnectService(this);
            ItemService = new ItemService(this);
            RequestService = new RequestService(this);
            RequestPropertyService = new RequestPropertyService(this);
            SubComputeService = new SubComputeService(this);
            WebsocketCommandService = new WebsocketCommandService(this);
            WebsocketCommandPropertyService = new WebsocketCommandPropertyService(this);
        }

        /// <summary>
        /// An optional partial-method to perform custom initialization.
        ///</summary>
        public void CustomInitialize()
        {
            // Initialise the response message first.
            HttpResponseMessage = new HttpResponseMessage();
        }
        
        /// <summary>
        /// Initializes client properties.
        /// </summary>
        private void Initialize()
        {
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

        public async Task<HttpOperationResponse<object>> Invoke<T>(HttpMethod httpMethod, string relativeUrl, 
            NameValueCollection queryParameters = null, Dictionary<string, object> tracingParameters = null, 
            Dictionary<string, List<string>> customHeaders = null, 
            CancellationToken cancellationToken = default(CancellationToken))
        {
            Initialize(); // Always re-initialise
            
            // Tracing
            if (tracingParameters == null) tracingParameters = new Dictionary<string, object>(); // Null handling
            bool _shouldTrace = ServiceClientTracing.IsEnabled;
            string _invocationId = null;
            if (_shouldTrace)
            {
                _invocationId = ServiceClientTracing.NextInvocationId.ToString();
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(_invocationId, this, httpMethod.Method, tracingParameters);
            }

            // Construct URL
            var _baseUrl = BaseUri.AbsoluteUri;
            var uriBuilder = new UriBuilder(new System.Uri(
                new System.Uri(_baseUrl + (_baseUrl.EndsWith("/") ? "" : "/")), relativeUrl).ToString());
            var uriQuery = HttpUtility.ParseQueryString(uriBuilder.Query);
            if (queryParameters != null && queryParameters.Count > 0) uriBuilder.Query = queryParameters.ToString();
            var _url = uriBuilder.ToString();

            // Create HTTP transport objects
            var _httpRequest = new HttpRequestMessage();
            HttpResponseMessage _httpResponse = null;
            _httpRequest.Method = httpMethod;
            _httpRequest.RequestUri = new System.Uri(_url);
            
            // Set Headers
            if (customHeaders != null)
                foreach(var _header in customHeaders)
                {
                    if (HttpResponseMessage.Headers.Contains(_header.Key))
                        HttpResponseMessage.Headers.Remove(_header.Key);
                    HttpResponseMessage.Headers.TryAddWithoutValidation(_header.Key, _header.Value);
                }

            // TODO: Validate non-GET/HEAD-based support
            // Serialize RequestService
            string _requestContent = null;
            if (tracingParameters.ContainsKey("body") && tracingParameters.TryGetValue("body", out var body))
            {
                _requestContent = Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(body, 
                    SerializationSettings);
                _httpRequest.Content = new StringContent(_requestContent, System.Text.Encoding.UTF8);
                _httpRequest.Content.Headers.ContentType =System.Net.Http.Headers.MediaTypeHeaderValue
                    .Parse("application/json; charset=utf-8");
            }

            // Send RequestService
            if (_shouldTrace)
                ServiceClientTracing.SendRequest(_invocationId, _httpRequest);
            cancellationToken.ThrowIfCancellationRequested();
            _httpResponse = await HttpClient.SendAsync(_httpRequest, cancellationToken)
                .ConfigureAwait(false);
            if (_shouldTrace)
                ServiceClientTracing.ReceiveResponse(_invocationId, _httpResponse);
            
            var _statusCode = _httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            string _responseContent = null;
            if ((int)_statusCode != 200 && (int)_statusCode != 400 && (int)_statusCode != 401 
                && (int)_statusCode != 403 && (int)_statusCode != 500)
            {
                var ex = new HttpOperationException(string.Format("Operation returned an invalid status " +
                                                                  "code '{0}'", _statusCode));
                if (_httpResponse.Content != null) {
                    _responseContent = await _httpResponse.Content.ReadAsStringAsync()
                        .ConfigureAwait(false);
                }
                else {
                    _responseContent = string.Empty;
                }
                ex.Request = new HttpRequestMessageWrapper(_httpRequest, _requestContent);
                ex.Response = new HttpResponseMessageWrapper(_httpResponse, _responseContent);
                if (_shouldTrace)
                {
                    ServiceClientTracing.Error(_invocationId, ex);
                }
                _httpRequest.Dispose();
                if (_httpResponse != null)
                {
                    _httpResponse.Dispose();
                }
                throw ex;
            }
            
            // Create Result
            var _result = new HttpOperationResponse<object>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            
            // Deserialize Response
            if ((int)_statusCode == 200)
            {
                _responseContent = await _httpResponse.Content.ReadAsStringAsync()
                    .ConfigureAwait(false);
                try
                {
                    _result.Body = Microsoft.Rest.Serialization.SafeJsonConvert
                        .DeserializeObject<T>(_responseContent, DeserializationSettings);
                }
                catch (JsonException ex)
                {
                    _httpRequest.Dispose();
                    if (_httpResponse != null)
                    {
                        _httpResponse.Dispose();
                    }
                    throw new SerializationException("Unable to deserialize the response.", 
                        _responseContent, ex);
                }
            }
            
            // Deserialize Response
            if ((int)_statusCode == 400)
            {
                _responseContent = await _httpResponse.Content.ReadAsStringAsync()
                    .ConfigureAwait(false);
                try
                {
                    _result.Body = Microsoft.Rest.Serialization.SafeJsonConvert
                        .DeserializeObject<string>(_responseContent, DeserializationSettings);
                }
                catch (JsonException ex)
                {
                    _httpRequest.Dispose();
                    if (_httpResponse != null)
                        _httpResponse.Dispose();
                    throw new SerializationException("Unable to deserialize the response.", _responseContent, 
                        ex);
                }
            }
            
            // Deserialize Response
            if ((int)_statusCode == 500)
            {
                _responseContent = await _httpResponse.Content.ReadAsStringAsync()
                    .ConfigureAwait(false);
                try
                {
                    _result.Body = Microsoft.Rest.Serialization.SafeJsonConvert
                        .DeserializeObject<string>(_responseContent, DeserializationSettings);
                }
                catch (JsonException ex)
                {
                    _httpRequest.Dispose();
                    if (_httpResponse != null)
                        _httpResponse.Dispose();
                    throw new SerializationException("Unable to deserialize the response.", _responseContent, 
                        ex);
                }
            }
            if (_shouldTrace)
            {
                ServiceClientTracing.Exit(_invocationId, _result);
            }
            return _result;
        }
    }
}
