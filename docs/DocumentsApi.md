# SignRequest.Api.DocumentsApi

All URIs are relative to *https://signrequest.com/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DocumentsCreate**](DocumentsApi.md#documentscreate) | **POST** /documents/ | Create a Document
[**DocumentsDelete**](DocumentsApi.md#documentsdelete) | **DELETE** /documents/{uuid}/ | Delete a Document
[**DocumentsList**](DocumentsApi.md#documentslist) | **GET** /documents/ | Retrieve a list of Documents
[**DocumentsRead**](DocumentsApi.md#documentsread) | **GET** /documents/{uuid}/ | Retrieve a Document


<a name="documentscreate"></a>
# **DocumentsCreate**
> Document DocumentsCreate (Document data)

Create a Document

### Example
```csharp
using System;
using System.Diagnostics;
using SignRequest.Api;
using SignRequest.Client;
using SignRequest.Model;

namespace Example
{
    public class DocumentsCreateExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DocumentsApi();
            var data = new Document(); // Document | 

            try
            {
                // Create a Document
                Document result = apiInstance.DocumentsCreate(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentsApi.DocumentsCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**Document**](Document.md)|  | 

### Return type

[**Document**](Document.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="documentsdelete"></a>
# **DocumentsDelete**
> void DocumentsDelete (string uuid)

Delete a Document

### Example
```csharp
using System;
using System.Diagnostics;
using SignRequest.Api;
using SignRequest.Client;
using SignRequest.Model;

namespace Example
{
    public class DocumentsDeleteExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DocumentsApi();
            var uuid = uuid_example;  // string | 

            try
            {
                // Delete a Document
                apiInstance.DocumentsDelete(uuid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentsApi.DocumentsDelete: " + e.Message );
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

<a name="documentslist"></a>
# **DocumentsList**
> InlineResponse2003 DocumentsList (string externalId = null, string signrequestWho = null, string signrequestFromEmail = null, string status = null, string userEmail = null, string userFirstName = null, string userLastName = null, string created = null, string modified = null, int? page = null, int? limit = null)

Retrieve a list of Documents

### Example
```csharp
using System;
using System.Diagnostics;
using SignRequest.Api;
using SignRequest.Client;
using SignRequest.Model;

namespace Example
{
    public class DocumentsListExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DocumentsApi();
            var externalId = externalId_example;  // string |  (optional) 
            var signrequestWho = signrequestWho_example;  // string |  (optional) 
            var signrequestFromEmail = signrequestFromEmail_example;  // string |  (optional) 
            var status = status_example;  // string |  (optional) 
            var userEmail = userEmail_example;  // string |  (optional) 
            var userFirstName = userFirstName_example;  // string |  (optional) 
            var userLastName = userLastName_example;  // string |  (optional) 
            var created = created_example;  // string |  (optional) 
            var modified = modified_example;  // string |  (optional) 
            var page = 56;  // int? | A page number within the paginated result set. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 

            try
            {
                // Retrieve a list of Documents
                InlineResponse2003 result = apiInstance.DocumentsList(externalId, signrequestWho, signrequestFromEmail, status, userEmail, userFirstName, userLastName, created, modified, page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentsApi.DocumentsList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **externalId** | **string**|  | [optional] 
 **signrequestWho** | **string**|  | [optional] 
 **signrequestFromEmail** | **string**|  | [optional] 
 **status** | **string**|  | [optional] 
 **userEmail** | **string**|  | [optional] 
 **userFirstName** | **string**|  | [optional] 
 **userLastName** | **string**|  | [optional] 
 **created** | **string**|  | [optional] 
 **modified** | **string**|  | [optional] 
 **page** | **int?**| A page number within the paginated result set. | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 

### Return type

[**InlineResponse2003**](InlineResponse2003.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="documentsread"></a>
# **DocumentsRead**
> Document DocumentsRead (string uuid)

Retrieve a Document

### Example
```csharp
using System;
using System.Diagnostics;
using SignRequest.Api;
using SignRequest.Client;
using SignRequest.Model;

namespace Example
{
    public class DocumentsReadExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DocumentsApi();
            var uuid = uuid_example;  // string | 

            try
            {
                // Retrieve a Document
                Document result = apiInstance.DocumentsRead(uuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentsApi.DocumentsRead: " + e.Message );
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

[**Document**](Document.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

