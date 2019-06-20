# SignRequest - the C# library for [SignRequest.com](https://signrequest.com/)

[![NuGet version](https://badge.fury.io/nu/SignRequest.svg)](https://badge.fury.io/nu/SignRequest)

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext
- UWP >=10.0

<a name="dependencies"></a>
## Dependencies
- FubarCoder.RestSharp.Portable.Core >=4.0.7
- FubarCoder.RestSharp.Portable.HttpClient >=4.0.7
- Newtonsoft.Json >=10.0.3

<a name="installation"></a>

## Installation

### NuGet

The SignRequest API client can be installed using NuGet with the package name [SignRequest](https://www.nuget.org/packages/SignRequest/).

## API Documentation
Full API documentation, including code samples, can be found here:
https://signrequest.com/api/v1/docs/

<a name="getting-started"></a>
## Getting Started

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
            Configuration.Default.AddApiKeyPrefix("Authorization", "Token");

            var apiInstance = new DocumentsApi();
            var data = new Document();
            data.FileFromUrl = "https://docs.google.com/document/d/1oI2R1SxfMNZXiz3jCQvorpoklF9xq_dCJnOpkI-zo80/edit?usp=sharing";

            try
            {
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

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://signrequest.com/api/v1*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*ApiTokensApi* | [**ApiTokensList**](docs/ApiTokensApi.md#apitokenslist) | **GET** /api-tokens/ | Retrieve a list of API tokens
*DocumentAttachmentsApi* | [**DocumentAttachmentsCreate**](docs/DocumentAttachmentsApi.md#documentattachmentscreate) | **POST** /document-attachments/ | Create a Document Attachment
*DocumentAttachmentsApi* | [**DocumentAttachmentsList**](docs/DocumentAttachmentsApi.md#documentattachmentslist) | **GET** /document-attachments/ | Retrieve a list of Document Attachments
*DocumentAttachmentsApi* | [**DocumentAttachmentsRead**](docs/DocumentAttachmentsApi.md#documentattachmentsread) | **GET** /document-attachments/{uuid}/ | Retrieve a Document Attachment
*DocumentsApi* | [**DocumentsCreate**](docs/DocumentsApi.md#documentscreate) | **POST** /documents/ | Create a Document
*DocumentsApi* | [**DocumentsDelete**](docs/DocumentsApi.md#documentsdelete) | **DELETE** /documents/{uuid}/ | Delete a Document
*DocumentsApi* | [**DocumentsList**](docs/DocumentsApi.md#documentslist) | **GET** /documents/ | Retrieve a list of Documents
*DocumentsApi* | [**DocumentsRead**](docs/DocumentsApi.md#documentsread) | **GET** /documents/{uuid}/ | Retrieve a Document
*DocumentsSearchApi* | [**DocumentsSearchList**](docs/DocumentsSearchApi.md#documentssearchlist) | **GET** /documents-search/ | Search documents
*EventsApi* | [**EventsList**](docs/EventsApi.md#eventslist) | **GET** /events/ | Retrieve a list of Events
*EventsApi* | [**EventsRead**](docs/EventsApi.md#eventsread) | **GET** /events/{id}/ | Retrieve an Event
*SignrequestQuickCreateApi* | [**SignrequestQuickCreateCreate**](docs/SignrequestQuickCreateApi.md#signrequestquickcreatecreate) | **POST** /signrequest-quick-create/ | Quick create a SignRequest
*SignrequestsApi* | [**SignrequestsCancelSignrequest**](docs/SignrequestsApi.md#signrequestscancelsignrequest) | **POST** /signrequests/{uuid}/cancel_signrequest/ | Cancel a SignRequest
*SignrequestsApi* | [**SignrequestsCreate**](docs/SignrequestsApi.md#signrequestscreate) | **POST** /signrequests/ | Create a SignRequest
*SignrequestsApi* | [**SignrequestsList**](docs/SignrequestsApi.md#signrequestslist) | **GET** /signrequests/ | Retrieve a list of SignRequests
*SignrequestsApi* | [**SignrequestsRead**](docs/SignrequestsApi.md#signrequestsread) | **GET** /signrequests/{uuid}/ | Retrieve a SignRequest
*SignrequestsApi* | [**SignrequestsResendSignrequestEmail**](docs/SignrequestsApi.md#signrequestsresendsignrequestemail) | **POST** /signrequests/{uuid}/resend_signrequest_email/ | Resend a SignRequest
*TeamMembersApi* | [**TeamMembersList**](docs/TeamMembersApi.md#teammemberslist) | **GET** /team-members/ | Retrieve a list of Team Members
*TeamMembersApi* | [**TeamMembersRead**](docs/TeamMembersApi.md#teammembersread) | **GET** /team-members/{uuid}/ | Retrieve a Team Member
*TeamsApi* | [**TeamsCreate**](docs/TeamsApi.md#teamscreate) | **POST** /teams/ | Create a Team
*TeamsApi* | [**TeamsDelete**](docs/TeamsApi.md#teamsdelete) | **DELETE** /teams/{subdomain}/ | Delete a Team
*TeamsApi* | [**TeamsInviteMember**](docs/TeamsApi.md#teamsinvitemember) | **POST** /teams/{subdomain}/invite_member/ | Invite a Team Member
*TeamsApi* | [**TeamsList**](docs/TeamsApi.md#teamslist) | **GET** /teams/ | Retrieve a list of Teams
*TeamsApi* | [**TeamsPartialUpdate**](docs/TeamsApi.md#teamspartialupdate) | **PATCH** /teams/{subdomain}/ | Update a Team
*TeamsApi* | [**TeamsRead**](docs/TeamsApi.md#teamsread) | **GET** /teams/{subdomain}/ | Retrieve a Team
*TemplatesApi* | [**TemplatesList**](docs/TemplatesApi.md#templateslist) | **GET** /templates/ | Retrieve a list of Templates
*TemplatesApi* | [**TemplatesRead**](docs/TemplatesApi.md#templatesread) | **GET** /templates/{uuid}/ | Retrieve a Template
*WebhooksApi* | [**WebhooksCreate**](docs/WebhooksApi.md#webhookscreate) | **POST** /webhooks/ | Create a Webhook
*WebhooksApi* | [**WebhooksDelete**](docs/WebhooksApi.md#webhooksdelete) | **DELETE** /webhooks/{uuid}/ | Delete a Webhook
*WebhooksApi* | [**WebhooksList**](docs/WebhooksApi.md#webhookslist) | **GET** /webhooks/ | Retrieve a list of Webhooks
*WebhooksApi* | [**WebhooksPartialUpdate**](docs/WebhooksApi.md#webhookspartialupdate) | **PATCH** /webhooks/{uuid}/ | Partially update a Webhook
*WebhooksApi* | [**WebhooksRead**](docs/WebhooksApi.md#webhooksread) | **GET** /webhooks/{uuid}/ | Retrieve a Webhook
*WebhooksApi* | [**WebhooksUpdate**](docs/WebhooksApi.md#webhooksupdate) | **PUT** /webhooks/{uuid}/ | Update a Webhook


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AuthToken](docs/AuthToken.md)
 - [Model.Document](docs/Document.md)
 - [Model.DocumentAttachment](docs/DocumentAttachment.md)
 - [Model.DocumentSearch](docs/DocumentSearch.md)
 - [Model.DocumentSignerTemplateConf](docs/DocumentSignerTemplateConf.md)
 - [Model.DocumentSigningLog](docs/DocumentSigningLog.md)
 - [Model.DocumentSignrequest](docs/DocumentSignrequest.md)
 - [Model.DocumentTeam](docs/DocumentTeam.md)
 - [Model.Event](docs/Event.md)
 - [Model.FileFromSf](docs/FileFromSf.md)
 - [Model.InlineDocumentSignerIntegrationData](docs/InlineDocumentSignerIntegrationData.md)
 - [Model.InlineIntegrationData](docs/InlineIntegrationData.md)
 - [Model.InlinePrefillTags](docs/InlinePrefillTags.md)
 - [Model.InlineResponse200](docs/InlineResponse200.md)
 - [Model.InlineResponse2001](docs/InlineResponse2001.md)
 - [Model.InlineResponse2002](docs/InlineResponse2002.md)
 - [Model.InlineResponse2003](docs/InlineResponse2003.md)
 - [Model.InlineResponse2004](docs/InlineResponse2004.md)
 - [Model.InlineResponse2005](docs/InlineResponse2005.md)
 - [Model.InlineResponse2006](docs/InlineResponse2006.md)
 - [Model.InlineResponse2007](docs/InlineResponse2007.md)
 - [Model.InlineResponse2008](docs/InlineResponse2008.md)
 - [Model.InlineResponse2009](docs/InlineResponse2009.md)
 - [Model.InlineResponse201](docs/InlineResponse201.md)
 - [Model.InlineResponse2011](docs/InlineResponse2011.md)
 - [Model.InlineSignRequest](docs/InlineSignRequest.md)
 - [Model.InlineTeam](docs/InlineTeam.md)
 - [Model.InlineTeamMember](docs/InlineTeamMember.md)
 - [Model.InviteMember](docs/InviteMember.md)
 - [Model.Placeholder](docs/Placeholder.md)
 - [Model.RequiredAttachment](docs/RequiredAttachment.md)
 - [Model.SignRequest](docs/SignRequest.md)
 - [Model.SignRequestQuickCreate](docs/SignRequestQuickCreate.md)
 - [Model.Signer](docs/Signer.md)
 - [Model.SignerAttachment](docs/SignerAttachment.md)
 - [Model.SignerInputs](docs/SignerInputs.md)
 - [Model.SigningLog](docs/SigningLog.md)
 - [Model.Team](docs/Team.md)
 - [Model.TeamMember](docs/TeamMember.md)
 - [Model.Template](docs/Template.md)
 - [Model.User](docs/User.md)
 - [Model.WebhookSubscription](docs/WebhookSubscription.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="Token"></a>
### Token

- **Type**: API key
- **API key parameter name**: Authorization
- **Location**: HTTP header

