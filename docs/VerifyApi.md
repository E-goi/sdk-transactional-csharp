# IO.Swagger.Api.VerifyApi

All URIs are relative to *https://slingshot.egoiapp.com/api/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CancelVerify**](VerifyApi.md#cancelverify) | **POST** /v2/verify/{id}/cancel | Cancel Verify Request
[**GetVerify**](VerifyApi.md#getverify) | **GET** /v2/verify/{id} | Get Verify Request
[**RequestVerify**](VerifyApi.md#requestverify) | **POST** /v2/verify/request | Request Verify
[**ResendVerify**](VerifyApi.md#resendverify) | **POST** /v2/verify/{id}/resend | Resend Verify Code
[**ValidateVerifyCode**](VerifyApi.md#validateverifycode) | **POST** /v2/verify/{id}/validate | Validate Verify Code

<a name="cancelverify"></a>
# **CancelVerify**
> List<VerifyIdResponse> CancelVerify (string id)

Cancel Verify Request

This method will cancel the requested verify. No codes will be further generated or confirmed within the context of the id of the message

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CancelVerifyExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKey
            Configuration.Default.AddApiKey("ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("ApiKey", "Bearer");

            var apiInstance = new VerifyApi();
            var id = id_example;  // string | The id of the Verify Request

            try
            {
                // Cancel Verify Request
                List&lt;VerifyIdResponse&gt; result = apiInstance.CancelVerify(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VerifyApi.CancelVerify: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the Verify Request | 

### Return type

[**List<VerifyIdResponse>**](VerifyIdResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getverify"></a>
# **GetVerify**
> CheckVerifyResponse GetVerify (string id)

Get Verify Request

This method gets a verify requests, including status of it

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetVerifyExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKey
            Configuration.Default.AddApiKey("ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("ApiKey", "Bearer");

            var apiInstance = new VerifyApi();
            var id = id_example;  // string | The id of the Verify Request

            try
            {
                // Get Verify Request
                CheckVerifyResponse result = apiInstance.GetVerify(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VerifyApi.GetVerify: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the Verify Request | 

### Return type

[**CheckVerifyResponse**](CheckVerifyResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="requestverify"></a>
# **RequestVerify**
> VerifyIdResponse RequestVerify (VerifyRequest body = null)

Request Verify

This method will generate a code and send a message with it to a recipient

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RequestVerifyExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKey
            Configuration.Default.AddApiKey("ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("ApiKey", "Bearer");

            var apiInstance = new VerifyApi();
            var body = new VerifyRequest(); // VerifyRequest |  (optional) 

            try
            {
                // Request Verify
                VerifyIdResponse result = apiInstance.RequestVerify(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VerifyApi.RequestVerify: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**VerifyRequest**](VerifyRequest.md)|  | [optional] 

### Return type

[**VerifyIdResponse**](VerifyIdResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="resendverify"></a>
# **ResendVerify**
> List<VerifyIdResponse> ResendVerify (string id)

Resend Verify Code

This method will resend the requested verify. A new code will be generated and sent to the recipient

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ResendVerifyExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKey
            Configuration.Default.AddApiKey("ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("ApiKey", "Bearer");

            var apiInstance = new VerifyApi();
            var id = id_example;  // string | The id of the Verify Request

            try
            {
                // Resend Verify Code
                List&lt;VerifyIdResponse&gt; result = apiInstance.ResendVerify(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VerifyApi.ResendVerify: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the Verify Request | 

### Return type

[**List<VerifyIdResponse>**](VerifyIdResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="validateverifycode"></a>
# **ValidateVerifyCode**
> List<VerifyIdResponse> ValidateVerifyCode (string id, ValidateCodeVerifyRequest body = null)

Validate Verify Code

This method validates the code submitted by the recipient. This request should be made by the sender of the Verify request

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ValidateVerifyCodeExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKey
            Configuration.Default.AddApiKey("ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("ApiKey", "Bearer");

            var apiInstance = new VerifyApi();
            var id = id_example;  // string | The id of the Verify Request
            var body = new ValidateCodeVerifyRequest(); // ValidateCodeVerifyRequest |  (optional) 

            try
            {
                // Validate Verify Code
                List&lt;VerifyIdResponse&gt; result = apiInstance.ValidateVerifyCode(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VerifyApi.ValidateVerifyCode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the Verify Request | 
 **body** | [**ValidateCodeVerifyRequest**](ValidateCodeVerifyRequest.md)|  | [optional] 

### Return type

[**List<VerifyIdResponse>**](VerifyIdResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
