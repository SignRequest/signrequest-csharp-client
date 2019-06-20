# SignRequest.Model.DocumentSearch
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uuid** | **string** |  | [optional] 
**Created** | **DateTime?** |  | [optional] 
**Status** | **string** | &#x60;co&#x60;: converting, &#x60;ne&#x60;: new, &#x60;se&#x60;: sent, &#x60;vi&#x60;: viewed, &#x60;si&#x60;: signed, &#x60;do&#x60;: downloaded, &#x60;sd&#x60;: signed and downloaded, &#x60;ca&#x60;: cancelled, &#x60;de&#x60;: declined, &#x60;ec&#x60;: error converting, &#x60;es&#x60;: error sending, &#x60;xp&#x60;: expired | [optional] 
**Who** | **string** |  | 
**Name** | **string** | Defaults to filename | [optional] 
**Autocomplete** | **string** |  | 
**FromEmail** | **string** |  | 
**NrExtraDocs** | **int?** |  | 
**SignerEmails** | **List&lt;string&gt;** |  | [optional] 
**StatusDisplay** | **string** |  | [optional] 
**CreatedTimestamp** | **int?** |  | [optional] 
**FinishedOnTimestamp** | **int?** |  | [optional] 
**ParentDoc** | **string** |  | [optional] 
**FinishedOn** | **DateTime?** |  | [optional] 
**Subdomain** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

