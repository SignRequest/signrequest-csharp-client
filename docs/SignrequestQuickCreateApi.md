# Signrequest.Client.Api.SignrequestQuickCreateApi

All URIs are relative to *https://signrequest.com/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SignrequestQuickCreateCreate**](SignrequestQuickCreateApi.md#signrequestquickcreatecreate) | **POST** /signrequest-quick-create/ | Quick create a SignRequest


<a name="signrequestquickcreatecreate"></a>
# **SignrequestQuickCreateCreate**
> SignRequestQuickCreate SignrequestQuickCreateCreate (SignRequestQuickCreate data)

Quick create a SignRequest

### Example
```csharp
using System;
using System.Diagnostics;
using Signrequest.Client.Api;
using Signrequest.Client.Client;
using Signrequest.Client.Model;

namespace Example
{
    public class SignrequestQuickCreateCreateExample
    {
        public void main()
        {
            // Configure API key authorization: Token
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            Configuration.Default.AddApiKeyPrefix("Authorization", "Token");

            var apiInstance = new SignrequestQuickCreateApi();
            var data = new SignRequestQuickCreate(); // SignRequestQuickCreate | 

            try
            {
                // Quick create a SignRequest
                SignRequestQuickCreate result = apiInstance.SignrequestQuickCreateCreate(data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SignrequestQuickCreateApi.SignrequestQuickCreateCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **data** | [**SignRequestQuickCreate**](SignRequestQuickCreate.md)|  | 

### Return type

[**SignRequestQuickCreate**](SignRequestQuickCreate.md)

### Authorization

[Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

