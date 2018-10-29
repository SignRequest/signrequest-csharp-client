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
using RestSharp;
using Signrequest.Client.Client;
using Signrequest.Client.Model;

namespace Signrequest.Client.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITeamMembersApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Retrieve a list of Team Members
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Signrequest.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isActive"> (optional)</param>
        /// <param name="isOwner"> (optional)</param>
        /// <param name="isAdmin"> (optional)</param>
        /// <param name="userEmail"> (optional)</param>
        /// <param name="userFirstName"> (optional)</param>
        /// <param name="userLastName"> (optional)</param>
        /// <param name="page">A page number within the paginated result set. (optional)</param>
        /// <param name="limit">Number of results to return per page. (optional)</param>
        /// <returns>InlineResponse2006</returns>
        InlineResponse2006 TeamMembersList(string isActive = null, string isOwner = null, string isAdmin = null, string userEmail = null, string userFirstName = null, string userLastName = null, int? page = null, int? limit = null);

        /// <summary>
        /// Retrieve a list of Team Members
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Signrequest.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isActive"> (optional)</param>
        /// <param name="isOwner"> (optional)</param>
        /// <param name="isAdmin"> (optional)</param>
        /// <param name="userEmail"> (optional)</param>
        /// <param name="userFirstName"> (optional)</param>
        /// <param name="userLastName"> (optional)</param>
        /// <param name="page">A page number within the paginated result set. (optional)</param>
        /// <param name="limit">Number of results to return per page. (optional)</param>
        /// <returns>ApiResponse of InlineResponse2006</returns>
        ApiResponse<InlineResponse2006> TeamMembersListWithHttpInfo(string isActive = null, string isOwner = null, string isAdmin = null, string userEmail = null, string userFirstName = null, string userLastName = null, int? page = null, int? limit = null);
        /// <summary>
        /// Retrieve a Team Member
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Signrequest.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uuid"></param>
        /// <returns>TeamMember</returns>
        TeamMember TeamMembersRead(string uuid);

        /// <summary>
        /// Retrieve a Team Member
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Signrequest.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uuid"></param>
        /// <returns>ApiResponse of TeamMember</returns>
        ApiResponse<TeamMember> TeamMembersReadWithHttpInfo(string uuid);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Retrieve a list of Team Members
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Signrequest.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isActive"> (optional)</param>
        /// <param name="isOwner"> (optional)</param>
        /// <param name="isAdmin"> (optional)</param>
        /// <param name="userEmail"> (optional)</param>
        /// <param name="userFirstName"> (optional)</param>
        /// <param name="userLastName"> (optional)</param>
        /// <param name="page">A page number within the paginated result set. (optional)</param>
        /// <param name="limit">Number of results to return per page. (optional)</param>
        /// <returns>Task of InlineResponse2006</returns>
        System.Threading.Tasks.Task<InlineResponse2006> TeamMembersListAsync(string isActive = null, string isOwner = null, string isAdmin = null, string userEmail = null, string userFirstName = null, string userLastName = null, int? page = null, int? limit = null);

        /// <summary>
        /// Retrieve a list of Team Members
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Signrequest.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isActive"> (optional)</param>
        /// <param name="isOwner"> (optional)</param>
        /// <param name="isAdmin"> (optional)</param>
        /// <param name="userEmail"> (optional)</param>
        /// <param name="userFirstName"> (optional)</param>
        /// <param name="userLastName"> (optional)</param>
        /// <param name="page">A page number within the paginated result set. (optional)</param>
        /// <param name="limit">Number of results to return per page. (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2006)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2006>> TeamMembersListAsyncWithHttpInfo(string isActive = null, string isOwner = null, string isAdmin = null, string userEmail = null, string userFirstName = null, string userLastName = null, int? page = null, int? limit = null);
        /// <summary>
        /// Retrieve a Team Member
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Signrequest.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uuid"></param>
        /// <returns>Task of TeamMember</returns>
        System.Threading.Tasks.Task<TeamMember> TeamMembersReadAsync(string uuid);

        /// <summary>
        /// Retrieve a Team Member
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Signrequest.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uuid"></param>
        /// <returns>Task of ApiResponse (TeamMember)</returns>
        System.Threading.Tasks.Task<ApiResponse<TeamMember>> TeamMembersReadAsyncWithHttpInfo(string uuid);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TeamMembersApi : ITeamMembersApi
    {
        private Signrequest.Client.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMembersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TeamMembersApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = Signrequest.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMembersApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TeamMembersApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Signrequest.Client.Client.Configuration.DefaultExceptionFactory;
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
        public Configuration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Signrequest.Client.Client.ExceptionFactory ExceptionFactory
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
        /// Retrieve a list of Team Members 
        /// </summary>
        /// <exception cref="Signrequest.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isActive"> (optional)</param>
        /// <param name="isOwner"> (optional)</param>
        /// <param name="isAdmin"> (optional)</param>
        /// <param name="userEmail"> (optional)</param>
        /// <param name="userFirstName"> (optional)</param>
        /// <param name="userLastName"> (optional)</param>
        /// <param name="page">A page number within the paginated result set. (optional)</param>
        /// <param name="limit">Number of results to return per page. (optional)</param>
        /// <returns>InlineResponse2006</returns>
        public InlineResponse2006 TeamMembersList(string isActive = null, string isOwner = null, string isAdmin = null, string userEmail = null, string userFirstName = null, string userLastName = null, int? page = null, int? limit = null)
        {
            ApiResponse<InlineResponse2006> localVarResponse = TeamMembersListWithHttpInfo(isActive, isOwner, isAdmin, userEmail, userFirstName, userLastName, page, limit);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve a list of Team Members 
        /// </summary>
        /// <exception cref="Signrequest.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isActive"> (optional)</param>
        /// <param name="isOwner"> (optional)</param>
        /// <param name="isAdmin"> (optional)</param>
        /// <param name="userEmail"> (optional)</param>
        /// <param name="userFirstName"> (optional)</param>
        /// <param name="userLastName"> (optional)</param>
        /// <param name="page">A page number within the paginated result set. (optional)</param>
        /// <param name="limit">Number of results to return per page. (optional)</param>
        /// <returns>ApiResponse of InlineResponse2006</returns>
        public ApiResponse<InlineResponse2006> TeamMembersListWithHttpInfo(string isActive = null, string isOwner = null, string isAdmin = null, string userEmail = null, string userFirstName = null, string userLastName = null, int? page = null, int? limit = null)
        {

            var localVarPath = "/team-members/";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (isActive != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "is_active", isActive)); // query parameter
            if (isOwner != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "is_owner", isOwner)); // query parameter
            if (isAdmin != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "is_admin", isAdmin)); // query parameter
            if (userEmail != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "user__email", userEmail)); // query parameter
            if (userFirstName != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "user__first_name", userFirstName)); // query parameter
            if (userLastName != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "user__last_name", userLastName)); // query parameter
            if (page != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter

            // authentication (Token) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("TeamMembersList", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2006>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2006)Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2006)));
        }

        /// <summary>
        /// Retrieve a list of Team Members 
        /// </summary>
        /// <exception cref="Signrequest.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isActive"> (optional)</param>
        /// <param name="isOwner"> (optional)</param>
        /// <param name="isAdmin"> (optional)</param>
        /// <param name="userEmail"> (optional)</param>
        /// <param name="userFirstName"> (optional)</param>
        /// <param name="userLastName"> (optional)</param>
        /// <param name="page">A page number within the paginated result set. (optional)</param>
        /// <param name="limit">Number of results to return per page. (optional)</param>
        /// <returns>Task of InlineResponse2006</returns>
        public async System.Threading.Tasks.Task<InlineResponse2006> TeamMembersListAsync(string isActive = null, string isOwner = null, string isAdmin = null, string userEmail = null, string userFirstName = null, string userLastName = null, int? page = null, int? limit = null)
        {
            ApiResponse<InlineResponse2006> localVarResponse = await TeamMembersListAsyncWithHttpInfo(isActive, isOwner, isAdmin, userEmail, userFirstName, userLastName, page, limit);
            return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve a list of Team Members 
        /// </summary>
        /// <exception cref="Signrequest.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isActive"> (optional)</param>
        /// <param name="isOwner"> (optional)</param>
        /// <param name="isAdmin"> (optional)</param>
        /// <param name="userEmail"> (optional)</param>
        /// <param name="userFirstName"> (optional)</param>
        /// <param name="userLastName"> (optional)</param>
        /// <param name="page">A page number within the paginated result set. (optional)</param>
        /// <param name="limit">Number of results to return per page. (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2006)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2006>> TeamMembersListAsyncWithHttpInfo(string isActive = null, string isOwner = null, string isAdmin = null, string userEmail = null, string userFirstName = null, string userLastName = null, int? page = null, int? limit = null)
        {

            var localVarPath = "/team-members/";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (isActive != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "is_active", isActive)); // query parameter
            if (isOwner != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "is_owner", isOwner)); // query parameter
            if (isAdmin != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "is_admin", isAdmin)); // query parameter
            if (userEmail != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "user__email", userEmail)); // query parameter
            if (userFirstName != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "user__first_name", userFirstName)); // query parameter
            if (userLastName != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "user__last_name", userLastName)); // query parameter
            if (page != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter

            // authentication (Token) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("TeamMembersList", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2006>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2006)Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2006)));
        }

        /// <summary>
        /// Retrieve a Team Member 
        /// </summary>
        /// <exception cref="Signrequest.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uuid"></param>
        /// <returns>TeamMember</returns>
        public TeamMember TeamMembersRead(string uuid)
        {
            ApiResponse<TeamMember> localVarResponse = TeamMembersReadWithHttpInfo(uuid);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve a Team Member 
        /// </summary>
        /// <exception cref="Signrequest.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uuid"></param>
        /// <returns>ApiResponse of TeamMember</returns>
        public ApiResponse<TeamMember> TeamMembersReadWithHttpInfo(string uuid)
        {
            // verify the required parameter 'uuid' is set
            if (uuid == null)
                throw new ApiException(400, "Missing required parameter 'uuid' when calling TeamMembersApi->TeamMembersRead");

            var localVarPath = "/team-members/{uuid}/";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (uuid != null) localVarPathParams.Add("uuid", Configuration.ApiClient.ParameterToString(uuid)); // path parameter

            // authentication (Token) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("TeamMembersRead", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TeamMember>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TeamMember)Configuration.ApiClient.Deserialize(localVarResponse, typeof(TeamMember)));
        }

        /// <summary>
        /// Retrieve a Team Member 
        /// </summary>
        /// <exception cref="Signrequest.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uuid"></param>
        /// <returns>Task of TeamMember</returns>
        public async System.Threading.Tasks.Task<TeamMember> TeamMembersReadAsync(string uuid)
        {
            ApiResponse<TeamMember> localVarResponse = await TeamMembersReadAsyncWithHttpInfo(uuid);
            return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve a Team Member 
        /// </summary>
        /// <exception cref="Signrequest.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uuid"></param>
        /// <returns>Task of ApiResponse (TeamMember)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TeamMember>> TeamMembersReadAsyncWithHttpInfo(string uuid)
        {
            // verify the required parameter 'uuid' is set
            if (uuid == null)
                throw new ApiException(400, "Missing required parameter 'uuid' when calling TeamMembersApi->TeamMembersRead");

            var localVarPath = "/team-members/{uuid}/";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (uuid != null) localVarPathParams.Add("uuid", Configuration.ApiClient.ParameterToString(uuid)); // path parameter

            // authentication (Token) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("TeamMembersRead", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TeamMember>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TeamMember)Configuration.ApiClient.Deserialize(localVarResponse, typeof(TeamMember)));
        }

    }
}
