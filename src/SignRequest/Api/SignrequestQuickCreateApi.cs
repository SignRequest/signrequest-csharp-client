/* 
 * SignRequest API
 *
 * API for SignRequest.com
 *
 * OpenAPI spec version: v1
 * Contact: tech-support@signrequest.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp.Portable;
using SignRequest.Client;
using SignRequest.Model;

namespace SignRequest.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISignrequestQuickCreateApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Quick create a SignRequest
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SignRequest.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="data"></param>
        /// <returns>SignRequestQuickCreate</returns>
        SignRequestQuickCreate SignrequestQuickCreateCreate (SignRequestQuickCreate data);

        /// <summary>
        /// Quick create a SignRequest
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SignRequest.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="data"></param>
        /// <returns>ApiResponse of SignRequestQuickCreate</returns>
        ApiResponse<SignRequestQuickCreate> SignrequestQuickCreateCreateWithHttpInfo (SignRequestQuickCreate data);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Quick create a SignRequest
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SignRequest.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="data"></param>
        /// <returns>Task of SignRequestQuickCreate</returns>
        System.Threading.Tasks.Task<SignRequestQuickCreate> SignrequestQuickCreateCreateAsync (SignRequestQuickCreate data);

        /// <summary>
        /// Quick create a SignRequest
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SignRequest.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="data"></param>
        /// <returns>Task of ApiResponse (SignRequestQuickCreate)</returns>
        System.Threading.Tasks.Task<ApiResponse<SignRequestQuickCreate>> SignrequestQuickCreateCreateAsyncWithHttpInfo (SignRequestQuickCreate data);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SignrequestQuickCreateApi : ISignrequestQuickCreateApi
    {
        private SignRequest.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SignrequestQuickCreateApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SignrequestQuickCreateApi(String basePath)
        {
            this.Configuration = new SignRequest.Client.Configuration { BasePath = basePath };

            ExceptionFactory = SignRequest.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SignrequestQuickCreateApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SignrequestQuickCreateApi(SignRequest.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = SignRequest.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = SignRequest.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public SignRequest.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public SignRequest.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Quick create a SignRequest 
        /// </summary>
        /// <exception cref="SignRequest.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="data"></param>
        /// <returns>SignRequestQuickCreate</returns>
        public SignRequestQuickCreate SignrequestQuickCreateCreate (SignRequestQuickCreate data)
        {
             ApiResponse<SignRequestQuickCreate> localVarResponse = SignrequestQuickCreateCreateWithHttpInfo(data);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Quick create a SignRequest 
        /// </summary>
        /// <exception cref="SignRequest.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="data"></param>
        /// <returns>ApiResponse of SignRequestQuickCreate</returns>
        public ApiResponse< SignRequestQuickCreate > SignrequestQuickCreateCreateWithHttpInfo (SignRequestQuickCreate data)
        {
            // verify the required parameter 'data' is set
            if (data == null)
                throw new ApiException(400, "Missing required parameter 'data' when calling SignrequestQuickCreateApi->SignrequestQuickCreateCreate");

            var localVarPath = "./signrequest-quick-create/";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (data != null && data.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(data); // http body (model) parameter
            }
            else
            {
                localVarPostBody = data; // byte array
            }

            // authentication (Token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SignrequestQuickCreateCreate", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SignRequestQuickCreate>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (SignRequestQuickCreate) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SignRequestQuickCreate)));
        }

        /// <summary>
        /// Quick create a SignRequest 
        /// </summary>
        /// <exception cref="SignRequest.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="data"></param>
        /// <returns>Task of SignRequestQuickCreate</returns>
        public async System.Threading.Tasks.Task<SignRequestQuickCreate> SignrequestQuickCreateCreateAsync (SignRequestQuickCreate data)
        {
             ApiResponse<SignRequestQuickCreate> localVarResponse = await SignrequestQuickCreateCreateAsyncWithHttpInfo(data);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Quick create a SignRequest 
        /// </summary>
        /// <exception cref="SignRequest.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="data"></param>
        /// <returns>Task of ApiResponse (SignRequestQuickCreate)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SignRequestQuickCreate>> SignrequestQuickCreateCreateAsyncWithHttpInfo (SignRequestQuickCreate data)
        {
            // verify the required parameter 'data' is set
            if (data == null)
                throw new ApiException(400, "Missing required parameter 'data' when calling SignrequestQuickCreateApi->SignrequestQuickCreateCreate");

            var localVarPath = "./signrequest-quick-create/";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (data != null && data.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(data); // http body (model) parameter
            }
            else
            {
                localVarPostBody = data; // byte array
            }

            // authentication (Token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SignrequestQuickCreateCreate", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SignRequestQuickCreate>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (SignRequestQuickCreate) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SignRequestQuickCreate)));
        }

    }
}
