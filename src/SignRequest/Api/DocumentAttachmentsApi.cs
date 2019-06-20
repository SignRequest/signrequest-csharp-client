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
    public interface IDocumentAttachmentsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create a Document Attachment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SignRequest.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="data"></param>
        /// <returns>DocumentAttachment</returns>
        DocumentAttachment DocumentAttachmentsCreate (DocumentAttachment data);

        /// <summary>
        /// Create a Document Attachment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SignRequest.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="data"></param>
        /// <returns>ApiResponse of DocumentAttachment</returns>
        ApiResponse<DocumentAttachment> DocumentAttachmentsCreateWithHttpInfo (DocumentAttachment data);
        /// <summary>
        /// Retrieve a list of Document Attachments
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SignRequest.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentUuid"> (optional)</param>
        /// <param name="documentExternalId"> (optional)</param>
        /// <param name="created"> (optional)</param>
        /// <param name="page">A page number within the paginated result set. (optional)</param>
        /// <param name="limit">Number of results to return per page. (optional)</param>
        /// <returns>InlineResponse2001</returns>
        InlineResponse2001 DocumentAttachmentsList (string documentUuid = null, string documentExternalId = null, string created = null, int? page = null, int? limit = null);

        /// <summary>
        /// Retrieve a list of Document Attachments
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SignRequest.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentUuid"> (optional)</param>
        /// <param name="documentExternalId"> (optional)</param>
        /// <param name="created"> (optional)</param>
        /// <param name="page">A page number within the paginated result set. (optional)</param>
        /// <param name="limit">Number of results to return per page. (optional)</param>
        /// <returns>ApiResponse of InlineResponse2001</returns>
        ApiResponse<InlineResponse2001> DocumentAttachmentsListWithHttpInfo (string documentUuid = null, string documentExternalId = null, string created = null, int? page = null, int? limit = null);
        /// <summary>
        /// Retrieve a Document Attachment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SignRequest.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uuid"></param>
        /// <returns>DocumentAttachment</returns>
        DocumentAttachment DocumentAttachmentsRead (string uuid);

        /// <summary>
        /// Retrieve a Document Attachment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SignRequest.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uuid"></param>
        /// <returns>ApiResponse of DocumentAttachment</returns>
        ApiResponse<DocumentAttachment> DocumentAttachmentsReadWithHttpInfo (string uuid);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Create a Document Attachment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SignRequest.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="data"></param>
        /// <returns>Task of DocumentAttachment</returns>
        System.Threading.Tasks.Task<DocumentAttachment> DocumentAttachmentsCreateAsync (DocumentAttachment data);

        /// <summary>
        /// Create a Document Attachment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SignRequest.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="data"></param>
        /// <returns>Task of ApiResponse (DocumentAttachment)</returns>
        System.Threading.Tasks.Task<ApiResponse<DocumentAttachment>> DocumentAttachmentsCreateAsyncWithHttpInfo (DocumentAttachment data);
        /// <summary>
        /// Retrieve a list of Document Attachments
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SignRequest.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentUuid"> (optional)</param>
        /// <param name="documentExternalId"> (optional)</param>
        /// <param name="created"> (optional)</param>
        /// <param name="page">A page number within the paginated result set. (optional)</param>
        /// <param name="limit">Number of results to return per page. (optional)</param>
        /// <returns>Task of InlineResponse2001</returns>
        System.Threading.Tasks.Task<InlineResponse2001> DocumentAttachmentsListAsync (string documentUuid = null, string documentExternalId = null, string created = null, int? page = null, int? limit = null);

        /// <summary>
        /// Retrieve a list of Document Attachments
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SignRequest.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentUuid"> (optional)</param>
        /// <param name="documentExternalId"> (optional)</param>
        /// <param name="created"> (optional)</param>
        /// <param name="page">A page number within the paginated result set. (optional)</param>
        /// <param name="limit">Number of results to return per page. (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2001)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2001>> DocumentAttachmentsListAsyncWithHttpInfo (string documentUuid = null, string documentExternalId = null, string created = null, int? page = null, int? limit = null);
        /// <summary>
        /// Retrieve a Document Attachment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SignRequest.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uuid"></param>
        /// <returns>Task of DocumentAttachment</returns>
        System.Threading.Tasks.Task<DocumentAttachment> DocumentAttachmentsReadAsync (string uuid);

        /// <summary>
        /// Retrieve a Document Attachment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SignRequest.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uuid"></param>
        /// <returns>Task of ApiResponse (DocumentAttachment)</returns>
        System.Threading.Tasks.Task<ApiResponse<DocumentAttachment>> DocumentAttachmentsReadAsyncWithHttpInfo (string uuid);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class DocumentAttachmentsApi : IDocumentAttachmentsApi
    {
        private SignRequest.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentAttachmentsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DocumentAttachmentsApi(String basePath)
        {
            this.Configuration = new SignRequest.Client.Configuration { BasePath = basePath };

            ExceptionFactory = SignRequest.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentAttachmentsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DocumentAttachmentsApi(SignRequest.Client.Configuration configuration = null)
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
        /// Create a Document Attachment 
        /// </summary>
        /// <exception cref="SignRequest.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="data"></param>
        /// <returns>DocumentAttachment</returns>
        public DocumentAttachment DocumentAttachmentsCreate (DocumentAttachment data)
        {
             ApiResponse<DocumentAttachment> localVarResponse = DocumentAttachmentsCreateWithHttpInfo(data);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a Document Attachment 
        /// </summary>
        /// <exception cref="SignRequest.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="data"></param>
        /// <returns>ApiResponse of DocumentAttachment</returns>
        public ApiResponse< DocumentAttachment > DocumentAttachmentsCreateWithHttpInfo (DocumentAttachment data)
        {
            // verify the required parameter 'data' is set
            if (data == null)
                throw new ApiException(400, "Missing required parameter 'data' when calling DocumentAttachmentsApi->DocumentAttachmentsCreate");

            var localVarPath = "./document-attachments/";
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
                Exception exception = ExceptionFactory("DocumentAttachmentsCreate", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DocumentAttachment>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (DocumentAttachment) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentAttachment)));
        }

        /// <summary>
        /// Create a Document Attachment 
        /// </summary>
        /// <exception cref="SignRequest.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="data"></param>
        /// <returns>Task of DocumentAttachment</returns>
        public async System.Threading.Tasks.Task<DocumentAttachment> DocumentAttachmentsCreateAsync (DocumentAttachment data)
        {
             ApiResponse<DocumentAttachment> localVarResponse = await DocumentAttachmentsCreateAsyncWithHttpInfo(data);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a Document Attachment 
        /// </summary>
        /// <exception cref="SignRequest.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="data"></param>
        /// <returns>Task of ApiResponse (DocumentAttachment)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DocumentAttachment>> DocumentAttachmentsCreateAsyncWithHttpInfo (DocumentAttachment data)
        {
            // verify the required parameter 'data' is set
            if (data == null)
                throw new ApiException(400, "Missing required parameter 'data' when calling DocumentAttachmentsApi->DocumentAttachmentsCreate");

            var localVarPath = "./document-attachments/";
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
                Exception exception = ExceptionFactory("DocumentAttachmentsCreate", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DocumentAttachment>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (DocumentAttachment) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentAttachment)));
        }

        /// <summary>
        /// Retrieve a list of Document Attachments 
        /// </summary>
        /// <exception cref="SignRequest.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentUuid"> (optional)</param>
        /// <param name="documentExternalId"> (optional)</param>
        /// <param name="created"> (optional)</param>
        /// <param name="page">A page number within the paginated result set. (optional)</param>
        /// <param name="limit">Number of results to return per page. (optional)</param>
        /// <returns>InlineResponse2001</returns>
        public InlineResponse2001 DocumentAttachmentsList (string documentUuid = null, string documentExternalId = null, string created = null, int? page = null, int? limit = null)
        {
             ApiResponse<InlineResponse2001> localVarResponse = DocumentAttachmentsListWithHttpInfo(documentUuid, documentExternalId, created, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve a list of Document Attachments 
        /// </summary>
        /// <exception cref="SignRequest.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentUuid"> (optional)</param>
        /// <param name="documentExternalId"> (optional)</param>
        /// <param name="created"> (optional)</param>
        /// <param name="page">A page number within the paginated result set. (optional)</param>
        /// <param name="limit">Number of results to return per page. (optional)</param>
        /// <returns>ApiResponse of InlineResponse2001</returns>
        public ApiResponse< InlineResponse2001 > DocumentAttachmentsListWithHttpInfo (string documentUuid = null, string documentExternalId = null, string created = null, int? page = null, int? limit = null)
        {

            var localVarPath = "./document-attachments/";
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

            if (documentUuid != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "document__uuid", documentUuid)); // query parameter
            if (documentExternalId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "document__external_id", documentExternalId)); // query parameter
            if (created != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "created", created)); // query parameter
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter

            // authentication (Token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DocumentAttachmentsList", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2001>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (InlineResponse2001) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2001)));
        }

        /// <summary>
        /// Retrieve a list of Document Attachments 
        /// </summary>
        /// <exception cref="SignRequest.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentUuid"> (optional)</param>
        /// <param name="documentExternalId"> (optional)</param>
        /// <param name="created"> (optional)</param>
        /// <param name="page">A page number within the paginated result set. (optional)</param>
        /// <param name="limit">Number of results to return per page. (optional)</param>
        /// <returns>Task of InlineResponse2001</returns>
        public async System.Threading.Tasks.Task<InlineResponse2001> DocumentAttachmentsListAsync (string documentUuid = null, string documentExternalId = null, string created = null, int? page = null, int? limit = null)
        {
             ApiResponse<InlineResponse2001> localVarResponse = await DocumentAttachmentsListAsyncWithHttpInfo(documentUuid, documentExternalId, created, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve a list of Document Attachments 
        /// </summary>
        /// <exception cref="SignRequest.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentUuid"> (optional)</param>
        /// <param name="documentExternalId"> (optional)</param>
        /// <param name="created"> (optional)</param>
        /// <param name="page">A page number within the paginated result set. (optional)</param>
        /// <param name="limit">Number of results to return per page. (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2001)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2001>> DocumentAttachmentsListAsyncWithHttpInfo (string documentUuid = null, string documentExternalId = null, string created = null, int? page = null, int? limit = null)
        {

            var localVarPath = "./document-attachments/";
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

            if (documentUuid != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "document__uuid", documentUuid)); // query parameter
            if (documentExternalId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "document__external_id", documentExternalId)); // query parameter
            if (created != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "created", created)); // query parameter
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter

            // authentication (Token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DocumentAttachmentsList", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2001>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (InlineResponse2001) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2001)));
        }

        /// <summary>
        /// Retrieve a Document Attachment 
        /// </summary>
        /// <exception cref="SignRequest.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uuid"></param>
        /// <returns>DocumentAttachment</returns>
        public DocumentAttachment DocumentAttachmentsRead (string uuid)
        {
             ApiResponse<DocumentAttachment> localVarResponse = DocumentAttachmentsReadWithHttpInfo(uuid);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve a Document Attachment 
        /// </summary>
        /// <exception cref="SignRequest.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uuid"></param>
        /// <returns>ApiResponse of DocumentAttachment</returns>
        public ApiResponse< DocumentAttachment > DocumentAttachmentsReadWithHttpInfo (string uuid)
        {
            // verify the required parameter 'uuid' is set
            if (uuid == null)
                throw new ApiException(400, "Missing required parameter 'uuid' when calling DocumentAttachmentsApi->DocumentAttachmentsRead");

            var localVarPath = "./document-attachments/{uuid}/";
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

            if (uuid != null) localVarPathParams.Add("uuid", this.Configuration.ApiClient.ParameterToString(uuid)); // path parameter

            // authentication (Token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DocumentAttachmentsRead", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DocumentAttachment>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (DocumentAttachment) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentAttachment)));
        }

        /// <summary>
        /// Retrieve a Document Attachment 
        /// </summary>
        /// <exception cref="SignRequest.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uuid"></param>
        /// <returns>Task of DocumentAttachment</returns>
        public async System.Threading.Tasks.Task<DocumentAttachment> DocumentAttachmentsReadAsync (string uuid)
        {
             ApiResponse<DocumentAttachment> localVarResponse = await DocumentAttachmentsReadAsyncWithHttpInfo(uuid);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve a Document Attachment 
        /// </summary>
        /// <exception cref="SignRequest.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uuid"></param>
        /// <returns>Task of ApiResponse (DocumentAttachment)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DocumentAttachment>> DocumentAttachmentsReadAsyncWithHttpInfo (string uuid)
        {
            // verify the required parameter 'uuid' is set
            if (uuid == null)
                throw new ApiException(400, "Missing required parameter 'uuid' when calling DocumentAttachmentsApi->DocumentAttachmentsRead");

            var localVarPath = "./document-attachments/{uuid}/";
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

            if (uuid != null) localVarPathParams.Add("uuid", this.Configuration.ApiClient.ParameterToString(uuid)); // path parameter

            // authentication (Token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DocumentAttachmentsRead", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DocumentAttachment>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (DocumentAttachment) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentAttachment)));
        }

    }
}
