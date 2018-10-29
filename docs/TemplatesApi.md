# Signrequest.Client.Api.TemplatesApi

All URIs are relative to *https://signrequest.com/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TemplatesList**](TemplatesApi.md#templateslist) | **GET** /templates/ | Retrieve a list of Templates
[**TemplatesRead**](TemplatesApi.md#templatesread) | **GET** /templates/{uuid}/ | Retrieve a Template


<a name="templateslist"></a>
# **TemplatesList**
> InlineResponse2008 TemplatesList (int? page = null, int? limit = null)

Retrieve a list of Templates

### Example
```csharp
using System;
using System.Diagnostics;
using Signrequest.Client.Api;
using Signrequest.Client.Client;
using Signrequest.Client.Model;

namespace Example
{
    public class TemplatesListExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            Configuration.Default.AddApiKeyPrefix("Authorization", "Token");

            var apiInstance = new TemplatesApi();
            var page = 56;  // int? | A page number within the paginated result set. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 

            try
            {
                // Retrieve a list of Templates
                InlineResponse2008 result = apiInstance.TemplatesList(page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatesApi.TemplatesList: " + e.Message );
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

[**InlineResponse2008**](InlineResponse2008.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="templatesread"></a>
# **TemplatesRead**
> Template TemplatesRead (string uuid)

Retrieve a Template

### Example
```csharp
using System;
using System.Diagnostics;
using Signrequest.Client.Api;
using Signrequest.Client.Client;
using Signrequest.Client.Model;

namespace Example
{
    public class TemplatesReadExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            Configuration.Default.AddApiKeyPrefix("Authorization", "Token");

            var apiInstance = new TemplatesApi();
            var uuid = uuid_example;  // string | 

            try
            {
                // Retrieve a Template
                Template result = apiInstance.TemplatesRead(uuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplatesApi.TemplatesRead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | **string**|  | 

### Return type

[**Template**](Template.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

