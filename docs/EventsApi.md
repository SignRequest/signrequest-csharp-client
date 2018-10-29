# Signrequest.Client.Api.EventsApi

All URIs are relative to *https://signrequest.com/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EventsList**](EventsApi.md#eventslist) | **GET** /events/ | Retrieve a list of Events
[**EventsRead**](EventsApi.md#eventsread) | **GET** /events/{id}/ | Retrieve an Event


<a name="eventslist"></a>
# **EventsList**
> InlineResponse2004 EventsList (string documentUuid = null, string documentExternalId = null, string documentSignrequestWho = null, string documentSignrequestFromEmail = null, string documentStatus = null, string documentUserEmail = null, string documentUserFirstName = null, string documentUserLastName = null, string delivered = null, string deliveredOn = null, string timestamp = null, string status = null, string eventType = null, int? page = null, int? limit = null)

Retrieve a list of Events

### Example
```csharp
using System;
using System.Diagnostics;
using Signrequest.Client.Api;
using Signrequest.Client.Client;
using Signrequest.Client.Model;

namespace Example
{
    public class EventsListExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            Configuration.Default.AddApiKeyPrefix("Authorization", "Token");

            var apiInstance = new EventsApi();
            var documentUuid = documentUuid_example;  // string |  (optional) 
            var documentExternalId = documentExternalId_example;  // string |  (optional) 
            var documentSignrequestWho = documentSignrequestWho_example;  // string |  (optional) 
            var documentSignrequestFromEmail = documentSignrequestFromEmail_example;  // string |  (optional) 
            var documentStatus = documentStatus_example;  // string |  (optional) 
            var documentUserEmail = documentUserEmail_example;  // string |  (optional) 
            var documentUserFirstName = documentUserFirstName_example;  // string |  (optional) 
            var documentUserLastName = documentUserLastName_example;  // string |  (optional) 
            var delivered = delivered_example;  // string |  (optional) 
            var deliveredOn = deliveredOn_example;  // string |  (optional) 
            var timestamp = timestamp_example;  // string |  (optional) 
            var status = status_example;  // string |  (optional) 
            var eventType = eventType_example;  // string |  (optional) 
            var page = 56;  // int? | A page number within the paginated result set. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 

            try
            {
                // Retrieve a list of Events
                InlineResponse2004 result = apiInstance.EventsList(documentUuid, documentExternalId, documentSignrequestWho, documentSignrequestFromEmail, documentStatus, documentUserEmail, documentUserFirstName, documentUserLastName, delivered, deliveredOn, timestamp, status, eventType, page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventsApi.EventsList: " + e.Message );
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
 **documentSignrequestWho** | **string**|  | [optional] 
 **documentSignrequestFromEmail** | **string**|  | [optional] 
 **documentStatus** | **string**|  | [optional] 
 **documentUserEmail** | **string**|  | [optional] 
 **documentUserFirstName** | **string**|  | [optional] 
 **documentUserLastName** | **string**|  | [optional] 
 **delivered** | **string**|  | [optional] 
 **deliveredOn** | **string**|  | [optional] 
 **timestamp** | **string**|  | [optional] 
 **status** | **string**|  | [optional] 
 **eventType** | **string**|  | [optional] 
 **page** | **int?**| A page number within the paginated result set. | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 

### Return type

[**InlineResponse2004**](InlineResponse2004.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="eventsread"></a>
# **EventsRead**
> ModelEvent EventsRead (int? id)

Retrieve an Event

### Example
```csharp
using System;
using System.Diagnostics;
using Signrequest.Client.Api;
using Signrequest.Client.Client;
using Signrequest.Client.Model;

namespace Example
{
    public class EventsReadExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            Configuration.Default.AddApiKeyPrefix("Authorization", "Token");

            var apiInstance = new EventsApi();
            var id = 56;  // int? | A unique integer value identifying this event.

            try
            {
                // Retrieve an Event
                ModelEvent result = apiInstance.EventsRead(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventsApi.EventsRead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this event. | 

### Return type

[**ModelEvent**](ModelEvent.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

