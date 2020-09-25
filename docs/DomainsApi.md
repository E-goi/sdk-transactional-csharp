# IO.Swagger.Api.DomainsApi

All URIs are relative to *https://slingshot.egoiapp.com/api/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddDomain**](DomainsApi.md#adddomain) | **POST** /v2/domain | Create New Domain
[**ChangeDefaultDomain**](DomainsApi.md#changedefaultdomain) | **POST** /v2/domain/default | Change Default Domain
[**ListDefaultDomain**](DomainsApi.md#listdefaultdomain) | **GET** /v2/domain/default | Get Default Domain
[**ListDomain**](DomainsApi.md#listdomain) | **GET** /v2/domain/{id} | Get Single Domain
[**ListDomains**](DomainsApi.md#listdomains) | **GET** /v2/domain | Get All Domains
[**ValidateDomain**](DomainsApi.md#validatedomain) | **GET** /v2/domain/{id}/validate | Validate Single Domain

<a name="adddomain"></a>
# **AddDomain**
> DomainResponse AddDomain (DomainRequest body = null)

Create New Domain

Add a new Domain to the list of available Domains for the sender to the recipient.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddDomainExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKey
            Configuration.Default.AddApiKey("ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("ApiKey", "Bearer");

            var apiInstance = new DomainsApi();
            var body = new DomainRequest(); // DomainRequest |  (optional) 

            try
            {
                // Create New Domain
                DomainResponse result = apiInstance.AddDomain(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DomainsApi.AddDomain: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DomainRequest**](DomainRequest.md)|  | [optional] 

### Return type

[**DomainResponse**](DomainResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="changedefaultdomain"></a>
# **ChangeDefaultDomain**
> DomainResponse ChangeDefaultDomain (DefaultDomainRequest body = null)

Change Default Domain

Change the currently configured default Domain

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ChangeDefaultDomainExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKey
            Configuration.Default.AddApiKey("ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("ApiKey", "Bearer");

            var apiInstance = new DomainsApi();
            var body = new DefaultDomainRequest(); // DefaultDomainRequest |  (optional) 

            try
            {
                // Change Default Domain
                DomainResponse result = apiInstance.ChangeDefaultDomain(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DomainsApi.ChangeDefaultDomain: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DefaultDomainRequest**](DefaultDomainRequest.md)|  | [optional] 

### Return type

[**DomainResponse**](DomainResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listdefaultdomain"></a>
# **ListDefaultDomain**
> DomainResponse ListDefaultDomain ()

Get Default Domain

Retrieve the currently configured default Domain. If no default domain is set, the list will be empty.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListDefaultDomainExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKey
            Configuration.Default.AddApiKey("ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("ApiKey", "Bearer");

            var apiInstance = new DomainsApi();

            try
            {
                // Get Default Domain
                DomainResponse result = apiInstance.ListDefaultDomain();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DomainsApi.ListDefaultDomain: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**DomainResponse**](DomainResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listdomain"></a>
# **ListDomain**
> DomainResponse ListDomain (string id)

Get Single Domain

Retrieve the Domain with the id in the path.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListDomainExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKey
            Configuration.Default.AddApiKey("ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("ApiKey", "Bearer");

            var apiInstance = new DomainsApi();
            var id = id_example;  // string | The id of the Verify Request

            try
            {
                // Get Single Domain
                DomainResponse result = apiInstance.ListDomain(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DomainsApi.ListDomain: " + e.Message );
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

[**DomainResponse**](DomainResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listdomains"></a>
# **ListDomains**
> List<DomainResponse> ListDomains ()

Get All Domains

Retrieve the list of all Domains available for the sender to the recipients.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListDomainsExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKey
            Configuration.Default.AddApiKey("ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("ApiKey", "Bearer");

            var apiInstance = new DomainsApi();

            try
            {
                // Get All Domains
                List&lt;DomainResponse&gt; result = apiInstance.ListDomains();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DomainsApi.ListDomains: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<DomainResponse>**](DomainResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="validatedomain"></a>
# **ValidateDomain**
> ValidateDomainResponse ValidateDomain (string id)

Validate Single Domain

Clears the validation cache and validates the supplied configured Domain.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ValidateDomainExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKey
            Configuration.Default.AddApiKey("ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("ApiKey", "Bearer");

            var apiInstance = new DomainsApi();
            var id = id_example;  // string | The id of the Domain

            try
            {
                // Validate Single Domain
                ValidateDomainResponse result = apiInstance.ValidateDomain(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DomainsApi.ValidateDomain: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the Domain | 

### Return type

[**ValidateDomainResponse**](ValidateDomainResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
