# SignRequest.Api.TeamsApi

All URIs are relative to *https://signrequest.com/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TeamsCreate**](TeamsApi.md#teamscreate) | **POST** /teams/ | Create a Team
[**TeamsInviteMember**](TeamsApi.md#teamsinvitemember) | **POST** /teams/{subdomain}/invite_member/ | Invite a Team Member
[**TeamsList**](TeamsApi.md#teamslist) | **GET** /teams/ | Retrieve a list of Teams
[**TeamsPartialUpdate**](TeamsApi.md#teamspartialupdate) | **PATCH** /teams/{subdomain}/ | Update a Team
[**TeamsRead**](TeamsApi.md#teamsread) | **GET** /teams/{subdomain}/ | Retrieve a Team


<a name="teamscreate"></a>
# **TeamsCreate**
> Team TeamsCreate (Team data)

Create a Team

Required fields are **name** and **subdomain** where the subdomain is globally unique. Use **POST** to create a Team. To update a field on a Team use **PATCH**.  To use the API on behalf of a particular team change the endpoint to: *https://_**{{ subdomain }}**.signrequest.com/api/v1/...*  To invite new team members you can use **POST** {\"email\":\"**email-of-member-to-invite@example.com**\",\"is_admin\":false,\"is_owner\":false} to: *https://signrequest.com/api/v1/teams/_**{{ subdomain }}**_/invite_member/_*

### Example
```csharp
using System;
using System.Diagnostics;
using SignRequest.Api;
using SignRequest.Client;
using SignRequest.Model;

namespace Example
{
    public class TeamsCreateExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            Configuration.Default.AddApiKeyPrefix("Authorization", "Token");

            var apiInstance = new TeamsApi();
            var data = new Team(); // Team | 

            try
            {
                // Create a Team
                Team result = apiInstance.TeamsCreate(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**Team**](Team.md)|  | 

### Return type

[**Team**](Team.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsinvitemember"></a>
# **TeamsInviteMember**
> InviteMember TeamsInviteMember (string subdomain, InviteMember data)

Invite a Team Member

Required fields are **name** and **subdomain** where the subdomain is globally unique. Use **POST** to create a Team. To update a field on a Team use **PATCH**.  To use the API on behalf of a particular team change the endpoint to: *https://_**{{ subdomain }}**.signrequest.com/api/v1/...*  To invite new team members you can use **POST** {\"email\":\"**email-of-member-to-invite@example.com**\",\"is_admin\":false,\"is_owner\":false} to: *https://signrequest.com/api/v1/teams/_**{{ subdomain }}**_/invite_member/_*

### Example
```csharp
using System;
using System.Diagnostics;
using SignRequest.Api;
using SignRequest.Client;
using SignRequest.Model;

namespace Example
{
    public class TeamsInviteMemberExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            Configuration.Default.AddApiKeyPrefix("Authorization", "Token");

            var apiInstance = new TeamsApi();
            var subdomain = subdomain_example;  // string | 
            var data = new InviteMember(); // InviteMember | 

            try
            {
                // Invite a Team Member
                InviteMember result = apiInstance.TeamsInviteMember(subdomain, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsInviteMember: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **subdomain** | **string**|  | 
 **data** | [**InviteMember**](InviteMember.md)|  | 

### Return type

[**InviteMember**](InviteMember.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamslist"></a>
# **TeamsList**
> InlineResponse2007 TeamsList (int? page = null, int? limit = null)

Retrieve a list of Teams

Required fields are **name** and **subdomain** where the subdomain is globally unique. Use **POST** to create a Team. To update a field on a Team use **PATCH**.  To use the API on behalf of a particular team change the endpoint to: *https://_**{{ subdomain }}**.signrequest.com/api/v1/...*  To invite new team members you can use **POST** {\"email\":\"**email-of-member-to-invite@example.com**\",\"is_admin\":false,\"is_owner\":false} to: *https://signrequest.com/api/v1/teams/_**{{ subdomain }}**_/invite_member/_*

### Example
```csharp
using System;
using System.Diagnostics;
using SignRequest.Api;
using SignRequest.Client;
using SignRequest.Model;

namespace Example
{
    public class TeamsListExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            Configuration.Default.AddApiKeyPrefix("Authorization", "Token");

            var apiInstance = new TeamsApi();
            var page = 56;  // int? | A page number within the paginated result set. (optional) 
            var limit = 56;  // int? | Number of results to return per page. (optional) 

            try
            {
                // Retrieve a list of Teams
                InlineResponse2007 result = apiInstance.TeamsList(page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsList: " + e.Message );
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

[**InlineResponse2007**](InlineResponse2007.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamspartialupdate"></a>
# **TeamsPartialUpdate**
> Team TeamsPartialUpdate (string subdomain, Team data)

Update a Team

Required fields are **name** and **subdomain** where the subdomain is globally unique. Use **POST** to create a Team. To update a field on a Team use **PATCH**.  To use the API on behalf of a particular team change the endpoint to: *https://_**{{ subdomain }}**.signrequest.com/api/v1/...*  To invite new team members you can use **POST** {\"email\":\"**email-of-member-to-invite@example.com**\",\"is_admin\":false,\"is_owner\":false} to: *https://signrequest.com/api/v1/teams/_**{{ subdomain }}**_/invite_member/_*

### Example
```csharp
using System;
using System.Diagnostics;
using SignRequest.Api;
using SignRequest.Client;
using SignRequest.Model;

namespace Example
{
    public class TeamsPartialUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            Configuration.Default.AddApiKeyPrefix("Authorization", "Token");

            var apiInstance = new TeamsApi();
            var subdomain = subdomain_example;  // string | 
            var data = new Team(); // Team | 

            try
            {
                // Update a Team
                Team result = apiInstance.TeamsPartialUpdate(subdomain, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsPartialUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **subdomain** | **string**|  | 
 **data** | [**Team**](Team.md)|  | 

### Return type

[**Team**](Team.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsread"></a>
# **TeamsRead**
> Team TeamsRead (string subdomain)

Retrieve a Team

Required fields are **name** and **subdomain** where the subdomain is globally unique. Use **POST** to create a Team. To update a field on a Team use **PATCH**.  To use the API on behalf of a particular team change the endpoint to: *https://_**{{ subdomain }}**.signrequest.com/api/v1/...*  To invite new team members you can use **POST** {\"email\":\"**email-of-member-to-invite@example.com**\",\"is_admin\":false,\"is_owner\":false} to: *https://signrequest.com/api/v1/teams/_**{{ subdomain }}**_/invite_member/_*

### Example
```csharp
using System;
using System.Diagnostics;
using SignRequest.Api;
using SignRequest.Client;
using SignRequest.Model;

namespace Example
{
    public class TeamsReadExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            Configuration.Default.AddApiKeyPrefix("Authorization", "Token");

            var apiInstance = new TeamsApi();
            var subdomain = subdomain_example;  // string | 

            try
            {
                // Retrieve a Team
                Team result = apiInstance.TeamsRead(subdomain);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsRead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **subdomain** | **string**|  | 

### Return type

[**Team**](Team.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

