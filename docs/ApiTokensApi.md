# SignRequest.Api.ApiTokensApi

All URIs are relative to *https://signrequest.com/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiTokensList**](ApiTokensApi.md#apitokenslist) | **GET** /api-tokens/ | Retrieve a list of API tokens


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
            Configuration.Default.AddApiKeyPrefix("Authorization", "Token");

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

