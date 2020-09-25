# IO.Swagger.Api.AlertsApi

All URIs are relative to *https://slingshot.egoiapp.com/api/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ChangeAlertTemplate**](AlertsApi.md#changealerttemplate) | **PATCH** /v2/alert/template/{id} | Change Single Alert Template
[**CreateAlertTemplate**](AlertsApi.md#createalerttemplate) | **POST** /v2/alert/template | Create Alert Template
[**ExecuteEmailAlert**](AlertsApi.md#executeemailalert) | **POST** /v2/alert/action/execute | Execute Alert
[**ListMultiChannel**](AlertsApi.md#listmultichannel) | **GET** /v2/alert/template/{id} | Get Single Alert Template
[**ListMultiChannel1**](AlertsApi.md#listmultichannel1) | **GET** /v2/alert/template | Get All Alert Template
[**RemoveAlertTemplate**](AlertsApi.md#removealerttemplate) | **DELETE** /v2/alert/template/{id} | Remove Alert Template
[**StopAlert**](AlertsApi.md#stopalert) | **POST** /v2/alert/action/stop | Stop Alert

<a name="changealerttemplate"></a>
# **ChangeAlertTemplate**
> AlertTemplateResponse ChangeAlertTemplate (string id, AlertTemplateRequest body = null)

Change Single Alert Template

This method will change information about the template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ChangeAlertTemplateExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKey
            Configuration.Default.AddApiKey("ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("ApiKey", "Bearer");

            var apiInstance = new AlertsApi();
            var id = id_example;  // string | The id of the Alert Template to edit
            var body = new AlertTemplateRequest(); // AlertTemplateRequest |  (optional) 

            try
            {
                // Change Single Alert Template
                AlertTemplateResponse result = apiInstance.ChangeAlertTemplate(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertsApi.ChangeAlertTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the Alert Template to edit | 
 **body** | [**AlertTemplateRequest**](AlertTemplateRequest.md)|  | [optional] 

### Return type

[**AlertTemplateResponse**](AlertTemplateResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createalerttemplate"></a>
# **CreateAlertTemplate**
> AlertTemplateIdResponse CreateAlertTemplate (AlertTemplateRequest body = null)

Create Alert Template

This method will create and add an alert template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateAlertTemplateExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKey
            Configuration.Default.AddApiKey("ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("ApiKey", "Bearer");

            var apiInstance = new AlertsApi();
            var body = new AlertTemplateRequest(); // AlertTemplateRequest |  (optional) 

            try
            {
                // Create Alert Template
                AlertTemplateIdResponse result = apiInstance.CreateAlertTemplate(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertsApi.CreateAlertTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AlertTemplateRequest**](AlertTemplateRequest.md)|  | [optional] 

### Return type

[**AlertTemplateIdResponse**](AlertTemplateIdResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="executeemailalert"></a>
# **ExecuteEmailAlert**
> AlertIdResponse ExecuteEmailAlert (Body body = null)

Execute Alert

This method executes an alert flow , using a pre-created alert template.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExecuteEmailAlertExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKey
            Configuration.Default.AddApiKey("ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("ApiKey", "Bearer");

            var apiInstance = new AlertsApi();
            var body = new Body(); // Body | default response (optional) 

            try
            {
                // Execute Alert
                AlertIdResponse result = apiInstance.ExecuteEmailAlert(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertsApi.ExecuteEmailAlert: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body**](Body.md)| default response | [optional] 

### Return type

[**AlertIdResponse**](AlertIdResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listmultichannel"></a>
# **ListMultiChannel**
> AlertTemplateResponse ListMultiChannel (string id)

Get Single Alert Template

This method returns the Alert Template wih the id in the path

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListMultiChannelExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKey
            Configuration.Default.AddApiKey("ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("ApiKey", "Bearer");

            var apiInstance = new AlertsApi();
            var id = id_example;  // string | The id of the Alert Template

            try
            {
                // Get Single Alert Template
                AlertTemplateResponse result = apiInstance.ListMultiChannel(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertsApi.ListMultiChannel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the Alert Template | 

### Return type

[**AlertTemplateResponse**](AlertTemplateResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listmultichannel1"></a>
# **ListMultiChannel1**
> List<AlertTemplateResponse> ListMultiChannel1 ()

Get All Alert Template

This method returns all the Alert Templates

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListMultiChannel1Example
    {
        public void main()
        {
            // Configure API key authorization: ApiKey
            Configuration.Default.AddApiKey("ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("ApiKey", "Bearer");

            var apiInstance = new AlertsApi();

            try
            {
                // Get All Alert Template
                List&lt;AlertTemplateResponse&gt; result = apiInstance.ListMultiChannel1();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertsApi.ListMultiChannel1: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<AlertTemplateResponse>**](AlertTemplateResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="removealerttemplate"></a>
# **RemoveAlertTemplate**
> void RemoveAlertTemplate (string id)

Remove Alert Template

This method removes an Alert Template from the system

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RemoveAlertTemplateExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKey
            Configuration.Default.AddApiKey("ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("ApiKey", "Bearer");

            var apiInstance = new AlertsApi();
            var id = id_example;  // string | The id of the Alert Template to remove

            try
            {
                // Remove Alert Template
                apiInstance.RemoveAlertTemplate(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertsApi.RemoveAlertTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the Alert Template to remove | 

### Return type

void (empty response body)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="stopalert"></a>
# **StopAlert**
> AlertIdResponse StopAlert (CancelAlertRequest body = null)

Stop Alert

This method will stop any alerts that are being processed

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StopAlertExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKey
            Configuration.Default.AddApiKey("ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("ApiKey", "Bearer");

            var apiInstance = new AlertsApi();
            var body = new CancelAlertRequest(); // CancelAlertRequest |  (optional) 

            try
            {
                // Stop Alert
                AlertIdResponse result = apiInstance.StopAlert(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlertsApi.StopAlert: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CancelAlertRequest**](CancelAlertRequest.md)|  | [optional] 

### Return type

[**AlertIdResponse**](AlertIdResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
