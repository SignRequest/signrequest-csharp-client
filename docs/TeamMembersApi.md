# SignRequest.Api.TeamMembersApi

All URIs are relative to *https://signrequest.com/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TeamMembersList**](TeamMembersApi.md#teammemberslist) | **GET** /team-members/ | Retrieve a list of Team Members
[**TeamMembersRead**](TeamMembersApi.md#teammembersread) | **GET** /team-members/{uuid}/ | Retrieve a Team Member


<a name="teammemberslist"></a>
# **TeamMembersList**
> InlineResponse2006 TeamMembersList (string isActive = null, string isOwner = null, string isAdmin = null, string userEmail = null, string userFirstName = null, string userLastName = null, int? page = null, int? limit = null)

Retrieve a list of Team Members

### Example
```csharp
using System;
using System.Diagnostics;
using SignRequest.Api;
using SignRequest.Client;
using SignRequest.Model;

namespace Example
{
    public class TeamMembersListExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TeamMembersApi();
            var isActive = isActive_example;  // string |  (optional) 
            var isOwner = isOwner_example;  // string |  (optional) 
            var isAdmin = isAdmin_example;  // string |  (optional) 
            var userEmail = userEmail_example;  // string |  (optional) 
            var userFirstName = userFirstName_example;  // string |  (optional) 
            var userLastName = userLastName_example;  // string |  (optional) 
            var page = 56;  // int? | A page number within the paginated result set. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 

            try
            {
                // Retrieve a list of Team Members
                InlineResponse2006 result = apiInstance.TeamMembersList(isActive, isOwner, isAdmin, userEmail, userFirstName, userLastName, page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMembersApi.TeamMembersList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **isActive** | **string**|  | [optional] 
 **isOwner** | **string**|  | [optional] 
 **isAdmin** | **string**|  | [optional] 
 **userEmail** | **string**|  | [optional] 
 **userFirstName** | **string**|  | [optional] 
 **userLastName** | **string**|  | [optional] 
 **page** | **int?**| A page number within the paginated result set. | [optional] 
 **limit** | **int?**| Number of results to return per page. | [optional] 

### Return type

[**InlineResponse2006**](InlineResponse2006.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teammembersread"></a>
# **TeamMembersRead**
> TeamMember TeamMembersRead (string uuid)

Retrieve a Team Member

### Example
```csharp
using System;
using System.Diagnostics;
using SignRequest.Api;
using SignRequest.Client;
using SignRequest.Model;

namespace Example
{
    public class TeamMembersReadExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TeamMembersApi();
            var uuid = uuid_example;  // string | 

            try
            {
                // Retrieve a Team Member
                TeamMember result = apiInstance.TeamMembersRead(uuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamMembersApi.TeamMembersRead: " + e.Message );
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

[**TeamMember**](TeamMember.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

