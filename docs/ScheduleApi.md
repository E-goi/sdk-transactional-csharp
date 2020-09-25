# IO.Swagger.Api.ScheduleApi

All URIs are relative to *https://slingshot.egoiapp.com/api/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CancelScheduledMessage**](ScheduleApi.md#cancelscheduledmessage) | **POST** /v2/messages/{id}/action/send | Cancel a Scheduled Message

<a name="cancelscheduledmessage"></a>
# **CancelScheduledMessage**
> void CancelScheduledMessage (string id)

Cancel a Scheduled Message

Cancel a Scheduled Message

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CancelScheduledMessageExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKey
            Configuration.Default.AddApiKey("ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("ApiKey", "Bearer");

            var apiInstance = new ScheduleApi();
            var id = id_example;  // string | Id of the Message to cancel the send.

            try
            {
                // Cancel a Scheduled Message
                apiInstance.CancelScheduledMessage(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScheduleApi.CancelScheduledMessage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Id of the Message to cancel the send. | 

### Return type

void (empty response body)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
