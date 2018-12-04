# SignRequest - the C# library for [SignRequest.com](https://signrequest.com/)

[![NuGet version](https://badge.fury.io/nu/SignRequest.svg)](https://badge.fury.io/nu/SignRequest)

<a name="frameworks-supported"></a>

## Frameworks supported

- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>

## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:

```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>

## Installation

### NuGet

The SignRequest API client can be installed using NuGet with the package name [SignRequest](https://www.nuget.org/packages/SignRequest/).

### Building from Source

Run the following command to generate the DLL

- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:

```csharp
using SignRequest.Api;
using SignRequest.Client;
using SignRequest.Model;
```

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

All URIs are relative to _https://signrequest.com/api/v1_

| Class                       | Method                                                                                               | HTTP request                                            | Description                             |
| --------------------------- | ---------------------------------------------------------------------------------------------------- | ------------------------------------------------------- | --------------------------------------- |
| _ApiTokensApi_              | [**ApiTokensCreate**](docs/ApiTokensApi.md#apitokenscreate)                                          | **POST** /api-tokens/                                   | Create an API token                     |
| _ApiTokensApi_              | [**ApiTokensDelete**](docs/ApiTokensApi.md#apitokensdelete)                                          | **DELETE** /api-tokens/{key}/                           | Delete an API token                     |
| _ApiTokensApi_              | [**ApiTokensList**](docs/ApiTokensApi.md#apitokenslist)                                              | **GET** /api-tokens/                                    | Retrieve a list of API tokens           |
| _ApiTokensApi_              | [**ApiTokensRead**](docs/ApiTokensApi.md#apitokensread)                                              | **GET** /api-tokens/{key}/                              | Retrieve an API token                   |
| _DocumentAttachmentsApi_    | [**DocumentAttachmentsCreate**](docs/DocumentAttachmentsApi.md#documentattachmentscreate)            | **POST** /document-attachments/                         | Create a Document Attachment            |
| _DocumentAttachmentsApi_    | [**DocumentAttachmentsList**](docs/DocumentAttachmentsApi.md#documentattachmentslist)                | **GET** /document-attachments/                          | Retrieve a list of Document Attachments |
| _DocumentAttachmentsApi_    | [**DocumentAttachmentsRead**](docs/DocumentAttachmentsApi.md#documentattachmentsread)                | **GET** /document-attachments/{uuid}/                   | Retrieve a Document Attachment          |
| _DocumentsApi_              | [**DocumentsCreate**](docs/DocumentsApi.md#documentscreate)                                          | **POST** /documents/                                    | Create a Document                       |
| _DocumentsApi_              | [**DocumentsDelete**](docs/DocumentsApi.md#documentsdelete)                                          | **DELETE** /documents/{uuid}/                           | Delete a Document                       |
| _DocumentsApi_              | [**DocumentsList**](docs/DocumentsApi.md#documentslist)                                              | **GET** /documents/                                     | Retrieve a list of Documents            |
| _DocumentsApi_              | [**DocumentsRead**](docs/DocumentsApi.md#documentsread)                                              | **GET** /documents/{uuid}/                              | Retrieve a Document                     |
| _DocumentsSearchApi_        | [**DocumentsSearchList**](docs/DocumentsSearchApi.md#documentssearchlist)                            | **GET** /documents-search/                              | Search documents                        |
| _EventsApi_                 | [**EventsList**](docs/EventsApi.md#eventslist)                                                       | **GET** /events/                                        | Retrieve a list of Events               |
| _EventsApi_                 | [**EventsRead**](docs/EventsApi.md#eventsread)                                                       | **GET** /events/{id}/                                   | Retrieve an Event                       |
| _SignrequestQuickCreateApi_ | [**SignrequestQuickCreateCreate**](docs/SignrequestQuickCreateApi.md#signrequestquickcreatecreate)   | **POST** /signrequest-quick-create/                     | Quick create a SignRequest              |
| _SignrequestsApi_           | [**SignrequestsCancelSignrequest**](docs/SignrequestsApi.md#signrequestscancelsignrequest)           | **POST** /signrequests/{uuid}/cancel_signrequest/       | Cancel a SignRequest                    |
| _SignrequestsApi_           | [**SignrequestsCreate**](docs/SignrequestsApi.md#signrequestscreate)                                 | **POST** /signrequests/                                 | Create a SignRequest                    |
| _SignrequestsApi_           | [**SignrequestsList**](docs/SignrequestsApi.md#signrequestslist)                                     | **GET** /signrequests/                                  | Retrieve a list of SignRequests         |
| _SignrequestsApi_           | [**SignrequestsRead**](docs/SignrequestsApi.md#signrequestsread)                                     | **GET** /signrequests/{uuid}/                           | Retrieve a SignRequest                  |
| _SignrequestsApi_           | [**SignrequestsResendSignrequestEmail**](docs/SignrequestsApi.md#signrequestsresendsignrequestemail) | **POST** /signrequests/{uuid}/resend_signrequest_email/ | Resend a SignRequest                    |
| _TeamMembersApi_            | [**TeamMembersList**](docs/TeamMembersApi.md#teammemberslist)                                        | **GET** /team-members/                                  | Retrieve a list of Team Members         |
| _TeamMembersApi_            | [**TeamMembersRead**](docs/TeamMembersApi.md#teammembersread)                                        | **GET** /team-members/{uuid}/                           | Retrieve a Team Member                  |
| _TeamsApi_                  | [**TeamsCreate**](docs/TeamsApi.md#teamscreate)                                                      | **POST** /teams/                                        | Create a Team                           |
| _TeamsApi_                  | [**TeamsDelete**](docs/TeamsApi.md#teamsdelete)                                                      | **DELETE** /teams/{subdomain}/                          | Delete a Team                           |
| _TeamsApi_                  | [**TeamsInviteMember**](docs/TeamsApi.md#teamsinvitemember)                                          | **POST** /teams/{subdomain}/invite_member/              | Invite a Team Member                    |
| _TeamsApi_                  | [**TeamsList**](docs/TeamsApi.md#teamslist)                                                          | **GET** /teams/                                         | Retrieve a list of Teams                |
| _TeamsApi_                  | [**TeamsPartialUpdate**](docs/TeamsApi.md#teamspartialupdate)                                        | **PATCH** /teams/{subdomain}/                           | Update a Team                           |
| _TeamsApi_                  | [**TeamsRead**](docs/TeamsApi.md#teamsread)                                                          | **GET** /teams/{subdomain}/                             | Retrieve a Team                         |
| _TemplatesApi_              | [**TemplatesList**](docs/TemplatesApi.md#templateslist)                                              | **GET** /templates/                                     | Retrieve a list of Templates            |
| _TemplatesApi_              | [**TemplatesRead**](docs/TemplatesApi.md#templatesread)                                              | **GET** /templates/{uuid}/                              | Retrieve a Template                     |
| _WebhooksApi_               | [**WebhooksCreate**](docs/WebhooksApi.md#webhookscreate)                                             | **POST** /webhooks/                                     | Create a Webhook                        |
| _WebhooksApi_               | [**WebhooksDelete**](docs/WebhooksApi.md#webhooksdelete)                                             | **DELETE** /webhooks/{uuid}/                            | Delete a Webhook                        |
| _WebhooksApi_               | [**WebhooksList**](docs/WebhooksApi.md#webhookslist)                                                 | **GET** /webhooks/                                      | Retrieve a list of Webhooks             |
| _WebhooksApi_               | [**WebhooksPartialUpdate**](docs/WebhooksApi.md#webhookspartialupdate)                               | **PATCH** /webhooks/{uuid}/                             | Partially update a Webhook              |
| _WebhooksApi_               | [**WebhooksRead**](docs/WebhooksApi.md#webhooksread)                                                 | **GET** /webhooks/{uuid}/                               | Retrieve a Webhook                      |
| _WebhooksApi_               | [**WebhooksUpdate**](docs/WebhooksApi.md#webhooksupdate)                                             | **PUT** /webhooks/{uuid}/                               | Update a Webhook                        |

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
