# IO.Swagger.Api.WebhooksApi

All URIs are relative to *https://slingshot.egoiapp.com/api/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddWebHook**](WebhooksApi.md#addwebhook) | **POST** /v2/webhooks | Create new Webhook
[**ListWebHooks**](WebhooksApi.md#listwebhooks) | **GET** /v2/webhooks | Get All Webhooks
[**RemoveWebHook**](WebhooksApi.md#removewebhook) | **DELETE** /v2/webhooks | Remove Webhook

<a name="addwebhook"></a>
# **AddWebHook**
> WebhookIdResponse AddWebHook (Body1 body = null)

Create new Webhook

Create a new Webhook

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddWebHookExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKey
            Configuration.Default.AddApiKey("ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("ApiKey", "Bearer");

            var apiInstance = new WebhooksApi();
            var body = new Body1(); // Body1 | default response (optional) 

            try
            {
                // Create new Webhook
                WebhookIdResponse result = apiInstance.AddWebHook(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.AddWebHook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body1**](Body1.md)| default response | [optional] 

### Return type

[**WebhookIdResponse**](WebhookIdResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listwebhooks"></a>
# **ListWebHooks**
> List<GetWebhooksResponse> ListWebHooks (string channel = null)

Get All Webhooks

Return all Webhooks defined by the user

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListWebHooksExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKey
            Configuration.Default.AddApiKey("ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("ApiKey", "Bearer");

            var apiInstance = new WebhooksApi();
            var channel = channel_example;  // string | The channel of the groups. Can be `email` or `sms`, otherwise returns all groups. (optional) 

            try
            {
                // Get All Webhooks
                List&lt;GetWebhooksResponse&gt; result = apiInstance.ListWebHooks(channel);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.ListWebHooks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **channel** | **string**| The channel of the groups. Can be &#x60;email&#x60; or &#x60;sms&#x60;, otherwise returns all groups. | [optional] 

### Return type

[**List<GetWebhooksResponse>**](GetWebhooksResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="removewebhook"></a>
# **RemoveWebHook**
> void RemoveWebHook (string id, string channel = null)

Remove Webhook

Remove a Webhook

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RemoveWebHookExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKey
            Configuration.Default.AddApiKey("ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("ApiKey", "Bearer");

            var apiInstance = new WebhooksApi();
            var id = id_example;  // string | Id of the contact to be delete. Cannot be empty.
            var channel = channel_example;  // string | The channel of the Webhook. Can be `email` or `sms`, otherwise removes all the requested webhooks. (optional) 

            try
            {
                // Remove Webhook
                apiInstance.RemoveWebHook(id, channel);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.RemoveWebHook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Id of the contact to be delete. Cannot be empty. | 
 **channel** | **string**| The channel of the Webhook. Can be &#x60;email&#x60; or &#x60;sms&#x60;, otherwise removes all the requested webhooks. | [optional] 

### Return type

void (empty response body)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
