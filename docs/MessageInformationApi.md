# IO.Swagger.Api.MessageInformationApi

All URIs are relative to *https://slingshot.egoiapp.com/api/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListAllEmailMessages**](MessageInformationApi.md#listallemailmessages) | **GET** /v2/email/messages | Get All Email Messages
[**ListAllSmsMessages**](MessageInformationApi.md#listallsmsmessages) | **GET** /v2/sms/messages | Get All Sms Messages
[**ListSingleEmailMessage**](MessageInformationApi.md#listsingleemailmessage) | **GET** /v2/email/messages/{id} | Get Single Email Messages
[**ListSingleSmsMessage**](MessageInformationApi.md#listsinglesmsmessage) | **GET** /v2/sms/messages/{id} | Get Single Sms Messages

<a name="listallemailmessages"></a>
# **ListAllEmailMessages**
> List<PartialEmailMessageResponse> ListAllEmailMessages (string group = null, string dateStart = null, string dateEnd = null, string destination = null, string status = null)

Get All Email Messages

Retrieve the list of all sms messages. Results can be filtered by messages ids, group or channel. The result will be a combination of all parameters present

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListAllEmailMessagesExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKey
            Configuration.Default.AddApiKey("ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("ApiKey", "Bearer");

            var apiInstance = new MessageInformationApi();
            var group = group_example;  // string | The name of the group to search (optional) 
            var dateStart = dateStart_example;  // string | The date to start the report. Date must be in format ``yyyy-MM-dd`` (optional) 
            var dateEnd = dateEnd_example;  // string | The date to end the report. Date should be in format ``yyyy-MM-dd`` (optional) 
            var destination = destination_example;  // string | The mobile number of a recipient. (optional) 
            var status = status_example;  // string | The status to check the message. (optional) 

            try
            {
                // Get All Email Messages
                List&lt;PartialEmailMessageResponse&gt; result = apiInstance.ListAllEmailMessages(group, dateStart, dateEnd, destination, status);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessageInformationApi.ListAllEmailMessages: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **group** | **string**| The name of the group to search | [optional] 
 **dateStart** | **string**| The date to start the report. Date must be in format &#x60;&#x60;yyyy-MM-dd&#x60;&#x60; | [optional] 
 **dateEnd** | **string**| The date to end the report. Date should be in format &#x60;&#x60;yyyy-MM-dd&#x60;&#x60; | [optional] 
 **destination** | **string**| The mobile number of a recipient. | [optional] 
 **status** | **string**| The status to check the message. | [optional] 

### Return type

[**List<PartialEmailMessageResponse>**](PartialEmailMessageResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listallsmsmessages"></a>
# **ListAllSmsMessages**
> List<PartialSmsMessageResponse> ListAllSmsMessages (string group = null, string dateStart = null, string dateEnd = null, string destination = null, string status = null)

Get All Sms Messages

Retrieve the list of all sms messages. Results can be filtered by messages ids, group or channel. The result will be a combination of all parameters present

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListAllSmsMessagesExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKey
            Configuration.Default.AddApiKey("ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("ApiKey", "Bearer");

            var apiInstance = new MessageInformationApi();
            var group = group_example;  // string | The name of the group to search (optional) 
            var dateStart = dateStart_example;  // string | The date to start the report. Date must be in format ``yyyy-MM-dd`` (optional) 
            var dateEnd = dateEnd_example;  // string | The date to end the report. Date should be in format ``yyyy-MM-dd`` (optional) 
            var destination = destination_example;  // string | The mobile number of a recipient. (optional) 
            var status = status_example;  // string | The status to check the message. (optional) 

            try
            {
                // Get All Sms Messages
                List&lt;PartialSmsMessageResponse&gt; result = apiInstance.ListAllSmsMessages(group, dateStart, dateEnd, destination, status);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessageInformationApi.ListAllSmsMessages: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **group** | **string**| The name of the group to search | [optional] 
 **dateStart** | **string**| The date to start the report. Date must be in format &#x60;&#x60;yyyy-MM-dd&#x60;&#x60; | [optional] 
 **dateEnd** | **string**| The date to end the report. Date should be in format &#x60;&#x60;yyyy-MM-dd&#x60;&#x60; | [optional] 
 **destination** | **string**| The mobile number of a recipient. | [optional] 
 **status** | **string**| The status to check the message. | [optional] 

### Return type

[**List<PartialSmsMessageResponse>**](PartialSmsMessageResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listsingleemailmessage"></a>
# **ListSingleEmailMessage**
> CompleteEmailMessageResponse ListSingleEmailMessage (int? id)

Get Single Email Messages

Retrieve the message with the id from path

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListSingleEmailMessageExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKey
            Configuration.Default.AddApiKey("ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("ApiKey", "Bearer");

            var apiInstance = new MessageInformationApi();
            var id = 56;  // int? | The id of the message.

            try
            {
                // Get Single Email Messages
                CompleteEmailMessageResponse result = apiInstance.ListSingleEmailMessage(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessageInformationApi.ListSingleEmailMessage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the message. | 

### Return type

[**CompleteEmailMessageResponse**](CompleteEmailMessageResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listsinglesmsmessage"></a>
# **ListSingleSmsMessage**
> CompleteSmsMessageResponse ListSingleSmsMessage (int? id)

Get Single Sms Messages

Retrieve the message with the id from path

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListSingleSmsMessageExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKey
            Configuration.Default.AddApiKey("ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("ApiKey", "Bearer");

            var apiInstance = new MessageInformationApi();
            var id = 56;  // int? | The id of the message.

            try
            {
                // Get Single Sms Messages
                CompleteSmsMessageResponse result = apiInstance.ListSingleSmsMessage(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessageInformationApi.ListSingleSmsMessage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The id of the message. | 

### Return type

[**CompleteSmsMessageResponse**](CompleteSmsMessageResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
