# IO.Swagger.Api.SmsApi

All URIs are relative to *https://slingshot.egoiapp.com/api/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SendSmsMessages**](SmsApi.md#sendsmsmessages) | **POST** /v2/sms/messages/action/send | Send an SMS Message

<a name="sendsmsmessages"></a>
# **SendSmsMessages**
> List<SendMessageIdResponse> SendSmsMessages (List<Object> body = null)

Send an SMS Message

Send an sms message to a recipient

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SendSmsMessagesExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKey
            Configuration.Default.AddApiKey("ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("ApiKey", "Bearer");

            var apiInstance = new SmsApi();
            var body = new List<Object>(); // List<Object> | default response (optional) 

            try
            {
                // Send an SMS Message
                List&lt;SendMessageIdResponse&gt; result = apiInstance.SendSmsMessages(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SmsApi.SendSmsMessages: " + e.Message );
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
