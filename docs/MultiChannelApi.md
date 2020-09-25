# IO.Swagger.Api.MultiChannelApi

All URIs are relative to *https://slingshot.egoiapp.com/api/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateMultiChannelFlow**](MultiChannelApi.md#createmultichannelflow) | **POST** /v2/multi-channel/flow | Create Multi-Channel Flow
[**ExecuteMultiChannel**](MultiChannelApi.md#executemultichannel) | **POST** /v2/multi-channel/execute | Execute Multi-Channel
[**ListMultiChannel2**](MultiChannelApi.md#listmultichannel2) | **GET** /v2/multi-channel/flow/{id} | Get Single Multi-Channel Flow
[**ListMultiChannels**](MultiChannelApi.md#listmultichannels) | **GET** /v2/multi-channel/flow | Get All Multi-Channel Flows
[**RemoveMultiChannel**](MultiChannelApi.md#removemultichannel) | **DELETE** /v2/multi-channel/flow/{id} | Remove Single Multi-Channel

<a name="createmultichannelflow"></a>
# **CreateMultiChannelFlow**
> MultiChannelFlowIdResponse CreateMultiChannelFlow (MultiChannelFlowRequest body = null)

Create Multi-Channel Flow

This method will create and add a Multi-Channel Flow. First message doesn't need interval or condition, since it doesn't depend on other messages

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateMultiChannelFlowExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKey
            Configuration.Default.AddApiKey("ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("ApiKey", "Bearer");

            var apiInstance = new MultiChannelApi();
            var body = new MultiChannelFlowRequest(); // MultiChannelFlowRequest |  (optional) 

            try
            {
                // Create Multi-Channel Flow
                MultiChannelFlowIdResponse result = apiInstance.CreateMultiChannelFlow(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MultiChannelApi.CreateMultiChannelFlow: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MultiChannelFlowRequest**](MultiChannelFlowRequest.md)|  | [optional] 

### Return type

[**MultiChannelFlowIdResponse**](MultiChannelFlowIdResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="executemultichannel"></a>
# **ExecuteMultiChannel**
> MultiChannelIdResponse ExecuteMultiChannel (ExecuteMultiChannelRequest body = null)

Execute Multi-Channel

This method will create and start a flow, sending the Multi-Channel of messages to the appropriate recipient

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExecuteMultiChannelExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKey
            Configuration.Default.AddApiKey("ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("ApiKey", "Bearer");

            var apiInstance = new MultiChannelApi();
            var body = new ExecuteMultiChannelRequest(); // ExecuteMultiChannelRequest |  (optional) 

            try
            {
                // Execute Multi-Channel
                MultiChannelIdResponse result = apiInstance.ExecuteMultiChannel(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MultiChannelApi.ExecuteMultiChannel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ExecuteMultiChannelRequest**](ExecuteMultiChannelRequest.md)|  | [optional] 

### Return type

[**MultiChannelIdResponse**](MultiChannelIdResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listmultichannel2"></a>
# **ListMultiChannel2**
> List<MultiChannelFlowResponse> ListMultiChannel2 (string id)

Get Single Multi-Channel Flow

This method returns the Multi-Channel Flow wih the id in the path

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListMultiChannel2Example
    {
        public void main()
        {
            // Configure API key authorization: ApiKey
            Configuration.Default.AddApiKey("ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("ApiKey", "Bearer");

            var apiInstance = new MultiChannelApi();
            var id = id_example;  // string | The id of the Multi-Channel Flow

            try
            {
                // Get Single Multi-Channel Flow
                List&lt;MultiChannelFlowResponse&gt; result = apiInstance.ListMultiChannel2(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MultiChannelApi.ListMultiChannel2: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the Multi-Channel Flow | 

### Return type

[**List<MultiChannelFlowResponse>**](MultiChannelFlowResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listmultichannels"></a>
# **ListMultiChannels**
> List<MultiChannelFlowResponse> ListMultiChannels ()

Get All Multi-Channel Flows

This method returns all Multi-Channels Flows set in the system

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListMultiChannelsExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKey
            Configuration.Default.AddApiKey("ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("ApiKey", "Bearer");

            var apiInstance = new MultiChannelApi();

            try
            {
                // Get All Multi-Channel Flows
                List&lt;MultiChannelFlowResponse&gt; result = apiInstance.ListMultiChannels();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MultiChannelApi.ListMultiChannels: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<MultiChannelFlowResponse>**](MultiChannelFlowResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="removemultichannel"></a>
# **RemoveMultiChannel**
> void RemoveMultiChannel (string id)

Remove Single Multi-Channel

This method removes a Multi-Channel Flow from the system

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RemoveMultiChannelExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKey
            Configuration.Default.AddApiKey("ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("ApiKey", "Bearer");

            var apiInstance = new MultiChannelApi();
            var id = id_example;  // string | The id of the Multi-Channel Flow to remove

            try
            {
                // Remove Single Multi-Channel
                apiInstance.RemoveMultiChannel(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MultiChannelApi.RemoveMultiChannel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the Multi-Channel Flow to remove | 

### Return type

void (empty response body)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
