# IO.Swagger.Api.SendersApi

All URIs are relative to *https://slingshot.egoiapp.com/api/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetEmailSenders**](SendersApi.md#getemailsenders) | **GET** /v2/email/senders | Get All Email Senders
[**GetSmsSenders**](SendersApi.md#getsmssenders) | **GET** /v2/sms/senders | Get All Sms Senders

<a name="getemailsenders"></a>
# **GetEmailSenders**
> List<EmailSenderResponse> GetEmailSenders ()

Get All Email Senders

Retrieve the list of available Email senders

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetEmailSendersExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKey
            Configuration.Default.AddApiKey("ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("ApiKey", "Bearer");

            var apiInstance = new SendersApi();

            try
            {
                // Get All Email Senders
                List&lt;EmailSenderResponse&gt; result = apiInstance.GetEmailSenders();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SendersApi.GetEmailSenders: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<EmailSenderResponse>**](EmailSenderResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getsmssenders"></a>
# **GetSmsSenders**
> List<SmsSenderResponse> GetSmsSenders ()

Get All Sms Senders

Return all Sms Senders defined by the user

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSmsSendersExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKey
            Configuration.Default.AddApiKey("ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("ApiKey", "Bearer");

            var apiInstance = new SendersApi();

            try
            {
                // Get All Sms Senders
                List&lt;SmsSenderResponse&gt; result = apiInstance.GetSmsSenders();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SendersApi.GetSmsSenders: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<SmsSenderResponse>**](SmsSenderResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
