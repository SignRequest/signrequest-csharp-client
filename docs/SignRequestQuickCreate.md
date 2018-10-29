# Signrequest.Client.Model.SignRequestQuickCreate
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FromEmail** | **string** | Email of user sending the SignRequest (must be a validated email) | [optional] 
**FromEmailName** | **string** | Name to be used in the &#x60;From&#x60; email header, e.g. &#x60;{from_email_name} &lt;no-reply@signrequest.com&gt;&#x60; | [optional] 
**IsBeingPrepared** | **bool?** | Have the sender of a SignRequest prepare the document before sending the request out, see: [prepare using the web interface](#section/Preparing-a-document/Prepare-using-the-web-interface) | [optional] 
**PrepareUrl** | **string** |  | [optional] 
**RedirectUrl** | **string** | URL at which SignRequest will redirect to when a document is signed | [optional] 
**RequiredAttachments** | [**List&lt;RequiredAttachment&gt;**](RequiredAttachment.md) | Attachments that signers are required to upload | [optional] 
**DisableAttachments** | **bool?** | Disable uploading/adding of attachments | [optional] 
**DisableTextSignatures** | **bool?** | Disable usage of signatures generated by typing (text) | [optional] 
**DisableText** | **bool?** | Disable adding of text | [optional] 
**DisableDate** | **bool?** | Disable adding of dates | [optional] 
**DisableEmails** | **bool?** | Disable all SignRequest status emails as well as the email that contains the signed documents | [optional] 
**DisableUploadSignatures** | **bool?** | Disable usage of uploaded signatures (images) | [optional] 
**Subject** | **string** | Subject of SignRequest email | [optional] 
**Message** | **string** | Message to include in SignRequest email, may contain the following html tags: &#x60;a&#x60;, &#x60;abbr&#x60;, &#x60;acronym&#x60;, &#x60;b&#x60;, &#x60;blockquote&#x60;, &#x60;code&#x60;, &#x60;em&#x60;, &#x60;i&#x60;, &#x60;ul&#x60;, &#x60;li&#x60;, &#x60;ol&#x60;, and &#x60;strong&#x60; | [optional] 
**Who** | **string** | &#x60;m&#x60;: only me, &#x60;mo&#x60;: me and others, &#x60;o&#x60;: only others | [optional] [default to WhoEnum.O]
**SendReminders** | **bool?** | Automatically remind signers to sign a document | [optional] 
**Signers** | [**List&lt;Signer&gt;**](Signer.md) |  | 
**Uuid** | **string** |  | [optional] 
**Url** | **string** |  | [optional] 
**Document** | **string** |  | [optional] 
**Integration** | **string** |  | [optional] 
**IntegrationData** | **string** |  | [optional] 
**Name** | **string** | Defaults to filename, including extension | [optional] 
**ExternalId** | **string** | ID used to reference document in external system | [optional] 
**FrontendId** | **string** | Shared secret used in conjunction with &lt;a href&#x3D;\&quot;#section/Frontend-API/SignRequest-js-client-(beta)\&quot;&gt;SignRequest-js client&lt;/a&gt; to grant user access to a document that&#39;s not a member of the document&#39;s team | [optional] 
**File** | **string** | Temporary URL to original file, expires in five minutes | [optional] 
**FileFromUrl** | **string** | Publicly accessible URL of document to be downloaded by SignRequest | [optional] 
**EventsCallbackUrl** | **string** | URL at which to receive [event callbacks](#section/Events/Events-callback) for this document | [optional] 
**FileFromContent** | **string** | Base64 encoded document content | [optional] 
**FileFromContentName** | **string** | Filename, including extension. Required when using &#x60;file_from_content&#x60;. | [optional] 
**Template** | **string** |  | [optional] 
**PrefillTags** | [**List&lt;InlinePrefillTags&gt;**](InlinePrefillTags.md) | Prefill signer input data, see [prefill tags](#section/Preparing-a-document/Prefill-tags-templates) | [optional] 
**Integrations** | [**List&lt;InlineIntegrationData&gt;**](InlineIntegrationData.md) |  | [optional] 
**FileFromSf** | [**FileFromSf**](FileFromSf.md) |  | [optional] 
**AutoDeleteDays** | **int?** | Number of days after which a finished document (signed/cancelled/declined) will be automatically deleted | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
