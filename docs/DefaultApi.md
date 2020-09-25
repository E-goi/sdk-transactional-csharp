# IO.Swagger.Api.DefaultApi

All URIs are relative to *https://slingshot.egoiapp.com/api/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RedocStyleDoc**](DefaultApi.md#redocstyledoc) | **GET** /v2/redoc | 

<a name="redocstyledoc"></a>
# **RedocStyleDoc**
> void RedocStyleDoc ()



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RedocStyleDocExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();

            try
            {
                apiInstance.RedocStyleDoc();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.RedocStyleDoc: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
