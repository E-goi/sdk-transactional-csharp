# IO.Swagger.Api.PushApi

All URIs are relative to *https://slingshot.egoiapp.com/api/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddApp**](PushApi.md#addapp) | **POST** /v2/apps | Create App
[**AddPushTemplate**](PushApi.md#addpushtemplate) | **POST** /v2/push/templates | Create Push Template
[**DeleteApp**](PushApi.md#deleteapp) | **DELETE** /v2/apps/{id} | Remove App
[**DeletePushTemplate**](PushApi.md#deletepushtemplate) | **DELETE** /v2/push/templates/{id} | Remove Push Template
[**ListApp**](PushApi.md#listapp) | **GET** /v2/apps/{id} | Get an App
[**ListApps**](PushApi.md#listapps) | **GET** /v2/apps | Get All Apps
[**ListPushTemplate**](PushApi.md#listpushtemplate) | **GET** /v2/push/templates/{id} | Get an Push Template
[**ListPushTemplates**](PushApi.md#listpushtemplates) | **GET** /v2/push/templates | Get All Push Templates
[**SendPushMessages**](PushApi.md#sendpushmessages) | **POST** /v2/push/messages/action/send | Send a Push Message
[**UpdateApp**](PushApi.md#updateapp) | **PUT** /v2/apps/{id} | Update App
[**UpdatePushTemplate**](PushApi.md#updatepushtemplate) | **PATCH** /v2/push/templates/{id} | Update Push Template

<a name="addapp"></a>
# **AddApp**
> TemplateIdResponse AddApp (MobileAppRequest body = null)

Create App

Creates a new App

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddAppExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKey
            Configuration.Default.AddApiKey("ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("ApiKey", "Bearer");

            var apiInstance = new PushApi();
            var body = new MobileAppRequest(); // MobileAppRequest |  (optional) 

            try
            {
                // Create App
                TemplateIdResponse result = apiInstance.AddApp(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PushApi.AddApp: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MobileAppRequest**](MobileAppRequest.md)|  | [optional] 

### Return type

[**TemplateIdResponse**](TemplateIdResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="addpushtemplate"></a>
# **AddPushTemplate**
> TemplateIdResponse AddPushTemplate (PushTemplateRequest body = null)

Create Push Template

Creates a new template record for Push

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddPushTemplateExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKey
            Configuration.Default.AddApiKey("ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("ApiKey", "Bearer");

            var apiInstance = new PushApi();
            var body = new PushTemplateRequest(); // PushTemplateRequest |  (optional) 

            try
            {
                // Create Push Template
                TemplateIdResponse result = apiInstance.AddPushTemplate(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PushApi.AddPushTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PushTemplateRequest**](PushTemplateRequest.md)|  | [optional] 

### Return type

[**TemplateIdResponse**](TemplateIdResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteapp"></a>
# **DeleteApp**
> void DeleteApp (string id)

Remove App

Remove App

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteAppExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKey
            Configuration.Default.AddApiKey("ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("ApiKey", "Bearer");

            var apiInstance = new PushApi();
            var id = id_example;  // string | Id of the app. Cannot be empty.

            try
            {
                // Remove App
                apiInstance.DeleteApp(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PushApi.DeleteApp: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Id of the app. Cannot be empty. | 

### Return type

void (empty response body)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletepushtemplate"></a>
# **DeletePushTemplate**
> void DeletePushTemplate (string id)

Remove Push Template

Remove Push Template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeletePushTemplateExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKey
            Configuration.Default.AddApiKey("ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("ApiKey", "Bearer");

            var apiInstance = new PushApi();
            var id = id_example;  // string | Id of the Push Template. Cannot be empty.

            try
            {
                // Remove Push Template
                apiInstance.DeletePushTemplate(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PushApi.DeletePushTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Id of the Push Template. Cannot be empty. | 

### Return type

void (empty response body)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listapp"></a>
# **ListApp**
> MobileAppIdResponse ListApp (string id)

Get an App

Gets an App

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListAppExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKey
            Configuration.Default.AddApiKey("ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("ApiKey", "Bearer");

            var apiInstance = new PushApi();
            var id = id_example;  // string | Id of the App. Cannot be empty.

            try
            {
                // Get an App
                MobileAppIdResponse result = apiInstance.ListApp(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PushApi.ListApp: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Id of the App. Cannot be empty. | 

### Return type

[**MobileAppIdResponse**](MobileAppIdResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listapps"></a>
# **ListApps**
> List<MobileAppResponse> ListApps ()

Get All Apps

Obtains all the Apps

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListAppsExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKey
            Configuration.Default.AddApiKey("ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("ApiKey", "Bearer");

            var apiInstance = new PushApi();

            try
            {
                // Get All Apps
                List&lt;MobileAppResponse&gt; result = apiInstance.ListApps();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PushApi.ListApps: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<MobileAppResponse>**](MobileAppResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listpushtemplate"></a>
# **ListPushTemplate**
> SinglePushTemplateResponse ListPushTemplate (string id)

Get an Push Template

Gets an Push Template

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListPushTemplateExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKey
            Configuration.Default.AddApiKey("ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("ApiKey", "Bearer");

            var apiInstance = new PushApi();
            var id = id_example;  // string | Id of the Push Template. Cannot be empty.

            try
            {
                // Get an Push Template
                SinglePushTemplateResponse result = apiInstance.ListPushTemplate(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PushApi.ListPushTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Id of the Push Template. Cannot be empty. | 

### Return type

[**SinglePushTemplateResponse**](SinglePushTemplateResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listpushtemplates"></a>
# **ListPushTemplates**
> List<SinglePushTemplateResponse> ListPushTemplates ()

Get All Push Templates

Obtains all the Push templates

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListPushTemplatesExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKey
            Configuration.Default.AddApiKey("ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("ApiKey", "Bearer");

            var apiInstance = new PushApi();

            try
            {
                // Get All Push Templates
                List&lt;SinglePushTemplateResponse&gt; result = apiInstance.ListPushTemplates();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PushApi.ListPushTemplates: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<SinglePushTemplateResponse>**](SinglePushTemplateResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="sendpushmessages"></a>
# **SendPushMessages**
> List<SendMessageIdResponse> SendPushMessages (List<Object> body = null)

Send a Push Message

Send an push message to a recipient

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SendPushMessagesExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKey
            Configuration.Default.AddApiKey("ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("ApiKey", "Bearer");

            var apiInstance = new PushApi();
            var body = new List<Object>(); // List<Object> | default response (optional) 

            try
            {
                // Send a Push Message
                List&lt;SendMessageIdResponse&gt; result = apiInstance.SendPushMessages(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PushApi.SendPushMessages: " + e.Message );
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
<a name="updateapp"></a>
# **UpdateApp**
> MobileAppIdResponse UpdateApp (string id, MobileAppRequest body = null)

Update App

Updates an App, given a template id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateAppExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKey
            Configuration.Default.AddApiKey("ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("ApiKey", "Bearer");

            var apiInstance = new PushApi();
            var id = id_example;  // string | Id of the Push Template. Cannot be empty.
            var body = new MobileAppRequest(); // MobileAppRequest |  (optional) 

            try
            {
                // Update App
                MobileAppIdResponse result = apiInstance.UpdateApp(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PushApi.UpdateApp: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Id of the Push Template. Cannot be empty. | 
 **body** | [**MobileAppRequest**](MobileAppRequest.md)|  | [optional] 

### Return type

[**MobileAppIdResponse**](MobileAppIdResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatepushtemplate"></a>
# **UpdatePushTemplate**
> SinglePushTemplateResponse UpdatePushTemplate (string id, PushTemplateRequest body = null)

Update Push Template

Updates an Push template, given a template id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdatePushTemplateExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKey
            Configuration.Default.AddApiKey("ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("ApiKey", "Bearer");

            var apiInstance = new PushApi();
            var id = id_example;  // string | Id of the Push Template. Cannot be empty.
            var body = new PushTemplateRequest(); // PushTemplateRequest |  (optional) 

            try
            {
                // Update Push Template
                SinglePushTemplateResponse result = apiInstance.UpdatePushTemplate(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PushApi.UpdatePushTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Id of the Push Template. Cannot be empty. | 
 **body** | [**PushTemplateRequest**](PushTemplateRequest.md)|  | [optional] 

### Return type

[**SinglePushTemplateResponse**](SinglePushTemplateResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
