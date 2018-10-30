# SignRequest.Api.WebhooksApi

All URIs are relative to *https://signrequest.com/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**WebhooksCreate**](WebhooksApi.md#webhookscreate) | **POST** /webhooks/ | Create a Webhook
[**WebhooksDelete**](WebhooksApi.md#webhooksdelete) | **DELETE** /webhooks/{uuid}/ | Delete a Webhook
[**WebhooksList**](WebhooksApi.md#webhookslist) | **GET** /webhooks/ | Retrieve a list of Webhooks
[**WebhooksPartialUpdate**](WebhooksApi.md#webhookspartialupdate) | **PATCH** /webhooks/{uuid}/ | Partially update a Webhook
[**WebhooksRead**](WebhooksApi.md#webhooksread) | **GET** /webhooks/{uuid}/ | Retrieve a Webhook
[**WebhooksUpdate**](WebhooksApi.md#webhooksupdate) | **PUT** /webhooks/{uuid}/ | Update a Webhook


<a name="webhookscreate"></a>
# **WebhooksCreate**
> WebhookSubscription WebhooksCreate (WebhookSubscription data)

Create a Webhook

### Example
```csharp
using System;
using System.Diagnostics;
using SignRequest.Api;
using SignRequest.Client;
using SignRequest.Model;

namespace Example
{
    public class WebhooksCreateExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WebhooksApi();
            var data = new WebhookSubscription(); // WebhookSubscription | 

            try
            {
                // Create a Webhook
                WebhookSubscription result = apiInstance.WebhooksCreate(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.WebhooksCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**WebhookSubscription**](WebhookSubscription.md)|  | 

### Return type

[**WebhookSubscription**](WebhookSubscription.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="webhooksdelete"></a>
# **WebhooksDelete**
> void WebhooksDelete (string uuid)

Delete a Webhook

### Example
```csharp
using System;
using System.Diagnostics;
using SignRequest.Api;
using SignRequest.Client;
using SignRequest.Model;

namespace Example
{
    public class WebhooksDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WebhooksApi();
            var uuid = uuid_example;  // string | 

            try
            {
                // Delete a Webhook
                apiInstance.WebhooksDelete(uuid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.WebhooksDelete: " + e.Message );
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

void (empty response body)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="webhookslist"></a>
# **WebhooksList**
> InlineResponse2009 WebhooksList (int? page = null, int? limit = null)

Retrieve a list of Webhooks

### Example
```csharp
using System;
using System.Diagnostics;
using SignRequest.Api;
using SignRequest.Client;
using SignRequest.Model;

namespace Example
{
    public class WebhooksListExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WebhooksApi();
            var page = 56;  // int? | A page number within the paginated result set. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 

            try
            {
                // Retrieve a list of Webhooks
                InlineResponse2009 result = apiInstance.WebhooksList(page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.WebhooksList: " + e.Message );
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

[**InlineResponse2009**](InlineResponse2009.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="webhookspartialupdate"></a>
# **WebhooksPartialUpdate**
> WebhookSubscription WebhooksPartialUpdate (string uuid, WebhookSubscription data)

Partially update a Webhook

### Example
```csharp
using System;
using System.Diagnostics;
using SignRequest.Api;
using SignRequest.Client;
using SignRequest.Model;

namespace Example
{
    public class WebhooksPartialUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WebhooksApi();
            var uuid = uuid_example;  // string | 
            var data = new WebhookSubscription(); // WebhookSubscription | 

            try
            {
                // Partially update a Webhook
                WebhookSubscription result = apiInstance.WebhooksPartialUpdate(uuid, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.WebhooksPartialUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | **string**|  | 
 **data** | [**WebhookSubscription**](WebhookSubscription.md)|  | 

### Return type

[**WebhookSubscription**](WebhookSubscription.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="webhooksread"></a>
# **WebhooksRead**
> WebhookSubscription WebhooksRead (string uuid)

Retrieve a Webhook

### Example
```csharp
using System;
using System.Diagnostics;
using SignRequest.Api;
using SignRequest.Client;
using SignRequest.Model;

namespace Example
{
    public class WebhooksReadExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WebhooksApi();
            var uuid = uuid_example;  // string | 

            try
            {
                // Retrieve a Webhook
                WebhookSubscription result = apiInstance.WebhooksRead(uuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.WebhooksRead: " + e.Message );
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

[**WebhookSubscription**](WebhookSubscription.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="webhooksupdate"></a>
# **WebhooksUpdate**
> WebhookSubscription WebhooksUpdate (string uuid, WebhookSubscription data)

Update a Webhook

### Example
```csharp
using System;
using System.Diagnostics;
using SignRequest.Api;
using SignRequest.Client;
using SignRequest.Model;

namespace Example
{
    public class WebhooksUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WebhooksApi();
            var uuid = uuid_example;  // string | 
            var data = new WebhookSubscription(); // WebhookSubscription | 

            try
            {
                // Update a Webhook
                WebhookSubscription result = apiInstance.WebhooksUpdate(uuid, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.WebhooksUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | **string**|  | 
 **data** | [**WebhookSubscription**](WebhookSubscription.md)|  | 

### Return type

[**WebhookSubscription**](WebhookSubscription.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

