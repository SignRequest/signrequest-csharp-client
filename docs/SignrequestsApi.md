# Signrequest.Client.Api.SignrequestsApi

All URIs are relative to *https://signrequest.com/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SignrequestsCancelSignrequest**](SignrequestsApi.md#signrequestscancelsignrequest) | **POST** /signrequests/{uuid}/cancel_signrequest/ | Cancel a SignRequest
[**SignrequestsCreate**](SignrequestsApi.md#signrequestscreate) | **POST** /signrequests/ | Create a SignRequest
[**SignrequestsList**](SignrequestsApi.md#signrequestslist) | **GET** /signrequests/ | Retrieve a list of SignRequests
[**SignrequestsRead**](SignrequestsApi.md#signrequestsread) | **GET** /signrequests/{uuid}/ | Retrieve a SignRequest
[**SignrequestsResendSignrequestEmail**](SignrequestsApi.md#signrequestsresendsignrequestemail) | **POST** /signrequests/{uuid}/resend_signrequest_email/ | Resend a SignRequest


<a name="signrequestscancelsignrequest"></a>
# **SignrequestsCancelSignrequest**
> InlineResponse201 SignrequestsCancelSignrequest (string uuid)

Cancel a SignRequest

### Example
```csharp
using System;
using System.Diagnostics;
using Signrequest.Client.Api;
using Signrequest.Client.Client;
using Signrequest.Client.Model;

namespace Example
{
    public class SignrequestsCancelSignrequestExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            Configuration.Default.AddApiKeyPrefix("Authorization", "Token");

            var apiInstance = new SignrequestsApi();
            var uuid = uuid_example;  // string | 

            try
            {
                // Cancel a SignRequest
                InlineResponse201 result = apiInstance.SignrequestsCancelSignrequest(uuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SignrequestsApi.SignrequestsCancelSignrequest: " + e.Message );
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

[**InlineResponse201**](InlineResponse201.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="signrequestscreate"></a>
# **SignrequestsCreate**
> SignRequest SignrequestsCreate (SignRequest data)

Create a SignRequest

### Example
```csharp
using System;
using System.Diagnostics;
using Signrequest.Client.Api;
using Signrequest.Client.Client;
using Signrequest.Client.Model;

namespace Example
{
    public class SignrequestsCreateExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            Configuration.Default.AddApiKeyPrefix("Authorization", "Token");

            var apiInstance = new SignrequestsApi();
            var data = new SignRequest(); // SignRequest | 

            try
            {
                // Create a SignRequest
                SignRequest result = apiInstance.SignrequestsCreate(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SignrequestsApi.SignrequestsCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**SignRequest**](SignRequest.md)|  | 

### Return type

[**SignRequest**](SignRequest.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="signrequestslist"></a>
# **SignrequestsList**
> InlineResponse2005 SignrequestsList (string who = null, string fromEmail = null, int? page = null, int? limit = null)

Retrieve a list of SignRequests

### Example
```csharp
using System;
using System.Diagnostics;
using Signrequest.Client.Api;
using Signrequest.Client.Client;
using Signrequest.Client.Model;

namespace Example
{
    public class SignrequestsListExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            Configuration.Default.AddApiKeyPrefix("Authorization", "Token");

            var apiInstance = new SignrequestsApi();
            var who = who_example;  // string |  (optional) 
            var fromEmail = fromEmail_example;  // string |  (optional) 
            var page = 56;  // int? | A page number within the paginated result set. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 

            try
            {
                // Retrieve a list of SignRequests
                InlineResponse2005 result = apiInstance.SignrequestsList(who, fromEmail, page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SignrequestsApi.SignrequestsList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **who** | **string**|  | [optional] 
 **fromEmail** | **string**|  | [optional] 
 **page** | **int?**| A page number within the paginated result set. | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 

### Return type

[**InlineResponse2005**](InlineResponse2005.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="signrequestsread"></a>
# **SignrequestsRead**
> SignRequest SignrequestsRead (string uuid)

Retrieve a SignRequest

### Example
```csharp
using System;
using System.Diagnostics;
using Signrequest.Client.Api;
using Signrequest.Client.Client;
using Signrequest.Client.Model;

namespace Example
{
    public class SignrequestsReadExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            Configuration.Default.AddApiKeyPrefix("Authorization", "Token");

            var apiInstance = new SignrequestsApi();
            var uuid = uuid_example;  // string | 

            try
            {
                // Retrieve a SignRequest
                SignRequest result = apiInstance.SignrequestsRead(uuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SignrequestsApi.SignrequestsRead: " + e.Message );
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

[**SignRequest**](SignRequest.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="signrequestsresendsignrequestemail"></a>
# **SignrequestsResendSignrequestEmail**
> InlineResponse2011 SignrequestsResendSignrequestEmail (string uuid)

Resend a SignRequest

### Example
```csharp
using System;
using System.Diagnostics;
using Signrequest.Client.Api;
using Signrequest.Client.Client;
using Signrequest.Client.Model;

namespace Example
{
    public class SignrequestsResendSignrequestEmailExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            Configuration.Default.AddApiKeyPrefix("Authorization", "Token");

            var apiInstance = new SignrequestsApi();
            var uuid = uuid_example;  // string | 

            try
            {
                // Resend a SignRequest
                InlineResponse2011 result = apiInstance.SignrequestsResendSignrequestEmail(uuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SignrequestsApi.SignrequestsResendSignrequestEmail: " + e.Message );
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

[**InlineResponse2011**](InlineResponse2011.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

