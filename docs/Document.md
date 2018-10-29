# Signrequest.Client.Model.Document
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Url** | **string** |  | [optional] 
**Team** | [**Team1**](Team1.md) |  | [optional] 
**Uuid** | **string** |  | [optional] 
**User** | [**User**](User.md) |  | [optional] 
**FileAsPdf** | **string** | Temporary URL to original file as PDF, expires in five minutes | [optional] 
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
**Pdf** | **string** | Temporary URL to signed document as PDF, expires in five minutes | [optional] 
**Status** | **string** | &#x60;co&#x60;: converting, &#x60;ne&#x60;: new, &#x60;se&#x60;: sent, &#x60;vi&#x60;: viewed, &#x60;si&#x60;: signed, &#x60;do&#x60;: downloaded, &#x60;sd&#x60;: signed and downloaded, &#x60;ca&#x60;: cancelled, &#x60;de&#x60;: declined, &#x60;ec&#x60;: error converting, &#x60;es&#x60;: error sending, &#x60;xp&#x60;: expired | [optional] 
**Signrequest** | [**Signrequest**](Signrequest.md) |  | [optional] 
**ApiUsed** | **bool?** | Indicates whether document was created using the API | [optional] 
**SigningLog** | [**SigningLog**](SigningLog.md) |  | [optional] 
**SecurityHash** | **string** | SHA256 hash of PDF contents | [optional] 
**Attachments** | [**List&lt;DocumentAttachment&gt;**](DocumentAttachment.md) |  | [optional] 
**AutoDeleteAfter** | **DateTime?** | Date and time calculated using &#x60;auto_delete_days&#x60; after which a finished document (signed/cancelled/declined) will be automatically deleted | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

