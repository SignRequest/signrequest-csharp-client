# SignRequest.Api.ApiTokensApi

All URIs are relative to *https://signrequest.com/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiTokensCreate**](ApiTokensApi.md#apitokenscreate) | **POST** /api-tokens/ | Create an API token
[**ApiTokensDelete**](ApiTokensApi.md#apitokensdelete) | **DELETE** /api-tokens/{key}/ | Delete an API token
[**ApiTokensList**](ApiTokensApi.md#apitokenslist) | **GET** /api-tokens/ | Retrieve a list of API tokens
[**ApiTokensRead**](ApiTokensApi.md#apitokensread) | **GET** /api-tokens/{key}/ | Retrieve an API token


<a name="apitokenscreate"></a>
# **ApiTokensCreate**
> AuthToken ApiTokensCreate (AuthToken data)

Create an API token

You can create an API token in the [team api settings page](/#/teams). It is also possible to get or create a token using the REST api with your login credentials.

### Example
```csharp
using System;
using System.Diagnostics;
using SignRequest.Api;
using SignRequest.Client;
using SignRequest.Model;

namespace Example
{
    public class ApiTokensCreateExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApiTokensApi();
            var data = new AuthToken(); // AuthToken | 

            try
            {
                // Create an API token
                AuthToken result = apiInstance.ApiTokensCreate(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiTokensApi.ApiTokensCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**AuthToken**](AuthToken.md)|  | 

### Return type

[**AuthToken**](AuthToken.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apitokensdelete"></a>
# **ApiTokensDelete**
> void ApiTokensDelete (string key)

Delete an API token

### Example
```csharp
using System;
using System.Diagnostics;
using SignRequest.Api;
using SignRequest.Client;
using SignRequest.Model;

namespace Example
{
    public class ApiTokensDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApiTokensApi();
            var key = key_example;  // string | A unique value identifying this api token.

            try
            {
                // Delete an API token
                apiInstance.ApiTokensDelete(key);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiTokensApi.ApiTokensDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| A unique value identifying this api token. | 

### Return type

void (empty response body)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apitokenslist"></a>
# **ApiTokensList**
> InlineResponse200 ApiTokensList (int? page = null, int? limit = null)

Retrieve a list of API tokens

### Example
```csharp
using System;
using System.Diagnostics;
using SignRequest.Api;
using SignRequest.Client;
using SignRequest.Model;

namespace Example
{
    public class ApiTokensListExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApiTokensApi();
            var page = 56;  // int? | A page number within the paginated result set. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 

            try
            {
                // Retrieve a list of API tokens
                InlineResponse200 result = apiInstance.ApiTokensList(page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiTokensApi.ApiTokensList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| A page number within the paginated result set. | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apitokensread"></a>
# **ApiTokensRead**
> AuthToken ApiTokensRead (string key)

Retrieve an API token

### Example
```csharp
using System;
using System.Diagnostics;
using SignRequest.Api;
using SignRequest.Client;
using SignRequest.Model;

namespace Example
{
    public class ApiTokensReadExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApiTokensApi();
            var key = key_example;  // string | A unique value identifying this api token.

            try
            {
                // Retrieve an API token
                AuthToken result = apiInstance.ApiTokensRead(key);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiTokensApi.ApiTokensRead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| A unique value identifying this api token. | 

### Return type

[**AuthToken**](AuthToken.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

