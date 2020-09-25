# IO.Swagger.Api.EmailApi

All URIs are relative to *https://slingshot.egoiapp.com/api/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SendEmailMessages**](EmailApi.md#sendemailmessages) | **POST** /v2/email/messages/action/send | Send an Email Message

<a name="sendemailmessages"></a>
# **SendEmailMessages**
> List<SendMessageIdResponse> SendEmailMessages (List<Object> body = null)

Send an Email Message

Send an email message to a recipient

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SendEmailMessagesExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKey
            Configuration.Default.AddApiKey("ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("ApiKey", "Bearer");

            var apiInstance = new EmailApi();
            var body = new List<Object>(); // List<Object> | default response (optional) 

            try
            {
                // Send an Email Message
                List&lt;SendMessageIdResponse&gt; result = apiInstance.SendEmailMessages(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailApi.SendEmailMessages: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**List&lt;Object&gt;**](Object.md)| default response | [optional] 

### Return type

[**List<SendMessageIdResponse>**](SendMessageIdResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
