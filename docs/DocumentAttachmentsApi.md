# Signrequest.Client.Api.DocumentAttachmentsApi

All URIs are relative to *https://signrequest.com/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DocumentAttachmentsCreate**](DocumentAttachmentsApi.md#documentattachmentscreate) | **POST** /document-attachments/ | Create a Document Attachment
[**DocumentAttachmentsList**](DocumentAttachmentsApi.md#documentattachmentslist) | **GET** /document-attachments/ | Retrieve a list of Document Attachments
[**DocumentAttachmentsRead**](DocumentAttachmentsApi.md#documentattachmentsread) | **GET** /document-attachments/{uuid}/ | Retrieve a Document Attachment


<a name="documentattachmentscreate"></a>
# **DocumentAttachmentsCreate**
> DocumentAttachment DocumentAttachmentsCreate (DocumentAttachment data)

Create a Document Attachment

### Example
```csharp
using System;
using System.Diagnostics;
using Signrequest.Client.Api;
using Signrequest.Client.Client;
using Signrequest.Client.Model;

namespace Example
{
    public class DocumentAttachmentsCreateExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            Configuration.Default.AddApiKeyPrefix("Authorization", "Token");

            var apiInstance = new DocumentAttachmentsApi();
            var data = new DocumentAttachment(); // DocumentAttachment | 

            try
            {
                // Create a Document Attachment
                DocumentAttachment result = apiInstance.DocumentAttachmentsCreate(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentAttachmentsApi.DocumentAttachmentsCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**DocumentAttachment**](DocumentAttachment.md)|  | 

### Return type

[**DocumentAttachment**](DocumentAttachment.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="documentattachmentslist"></a>
# **DocumentAttachmentsList**
> InlineResponse2001 DocumentAttachmentsList (string documentUuid = null, string documentExternalId = null, string created = null, int? page = null, int? limit = null)

Retrieve a list of Document Attachments

### Example
```csharp
using System;
using System.Diagnostics;
using Signrequest.Client.Api;
using Signrequest.Client.Client;
using Signrequest.Client.Model;

namespace Example
{
    public class DocumentAttachmentsListExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            Configuration.Default.AddApiKeyPrefix("Authorization", "Token");

            var apiInstance = new DocumentAttachmentsApi();
            var documentUuid = documentUuid_example;  // string |  (optional) 
            var documentExternalId = documentExternalId_example;  // string |  (optional) 
            var created = created_example;  // string |  (optional) 
            var page = 56;  // int? | A page number within the paginated result set. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 

            try
            {
                // Retrieve a list of Document Attachments
                InlineResponse2001 result = apiInstance.DocumentAttachmentsList(documentUuid, documentExternalId, created, page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentAttachmentsApi.DocumentAttachmentsList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **documentUuid** | **string**|  | [optional] 
 **documentExternalId** | **string**|  | [optional] 
 **created** | **string**|  | [optional] 
 **page** | **int?**| A page number within the paginated result set. | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="documentattachmentsread"></a>
# **DocumentAttachmentsRead**
> DocumentAttachment DocumentAttachmentsRead (string uuid)

Retrieve a Document Attachment

### Example
```csharp
using System;
using System.Diagnostics;
using Signrequest.Client.Api;
using Signrequest.Client.Client;
using Signrequest.Client.Model;

namespace Example
{
    public class DocumentAttachmentsReadExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            Configuration.Default.AddApiKeyPrefix("Authorization", "Token");

            var apiInstance = new DocumentAttachmentsApi();
            var uuid = uuid_example;  // string | 

            try
            {
                // Retrieve a Document Attachment
                DocumentAttachment result = apiInstance.DocumentAttachmentsRead(uuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentAttachmentsApi.DocumentAttachmentsRead: " + e.Message );
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

[**DocumentAttachment**](DocumentAttachment.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

