# IO.Swagger.Api.ReportsApi

All URIs are relative to *https://slingshot.egoiapp.com/api/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ProduceEmailReport**](ReportsApi.md#produceemailreport) | **GET** /v2/email/reports | Get Email Report
[**ProduceSmsReport**](ReportsApi.md#producesmsreport) | **GET** /v2/sms/reports | Get Sms Report

<a name="produceemailreport"></a>
# **ProduceEmailReport**
> List<EmailReportResponse> ProduceEmailReport (string group = null, string groupBy = null, string dateStart = null, string dateEnd = null)

Get Email Report

Retrieve Mail Reports and Statistics. Entries can be customizable

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ProduceEmailReportExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKey
            Configuration.Default.AddApiKey("ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("ApiKey", "Bearer");

            var apiInstance = new ReportsApi();
            var group = group_example;  // string | The name of the group to search (optional) 
            var groupBy = groupBy_example;  // string | The option to group the results. Can be either ``day`` or ``month``. Defaults to ``day`` if none are present (optional) 
            var dateStart = dateStart_example;  // string | The date to start the report. Date must be in format ``yyyy-MM-dd`` (optional) 
            var dateEnd = dateEnd_example;  // string | The date to end the report. Date should be in format ``yyyy-MM-dd`` (optional) 

            try
            {
                // Get Email Report
                List&lt;EmailReportResponse&gt; result = apiInstance.ProduceEmailReport(group, groupBy, dateStart, dateEnd);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.ProduceEmailReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **group** | **string**| The name of the group to search | [optional] 
 **groupBy** | **string**| The option to group the results. Can be either &#x60;&#x60;day&#x60;&#x60; or &#x60;&#x60;month&#x60;&#x60;. Defaults to &#x60;&#x60;day&#x60;&#x60; if none are present | [optional] 
 **dateStart** | **string**| The date to start the report. Date must be in format &#x60;&#x60;yyyy-MM-dd&#x60;&#x60; | [optional] 
 **dateEnd** | **string**| The date to end the report. Date should be in format &#x60;&#x60;yyyy-MM-dd&#x60;&#x60; | [optional] 

### Return type

[**List<EmailReportResponse>**](EmailReportResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="producesmsreport"></a>
# **ProduceSmsReport**
> List<SmsReportResponse> ProduceSmsReport (string group = null, string groupBy = null, string dateStart = null, string dateEnd = null)

Get Sms Report

Retrieve Sms Reports and Statistics. Entries can be customizable

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ProduceSmsReportExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKey
            Configuration.Default.AddApiKey("ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("ApiKey", "Bearer");

            var apiInstance = new ReportsApi();
            var group = group_example;  // string | The id of the group to search (optional) 
            var groupBy = groupBy_example;  // string | The option to group the results. Can be either ``day`` or ``month``. Defaults to ``day`` if none are present (optional) 
            var dateStart = dateStart_example;  // string | The date to start the report. Date must be in format ``yyyy-MM-dd`` (optional) 
            var dateEnd = dateEnd_example;  // string | The date to end the report. Date should be in format ``yyyy-MM-dd`` (optional) 

            try
            {
                // Get Sms Report
                List&lt;SmsReportResponse&gt; result = apiInstance.ProduceSmsReport(group, groupBy, dateStart, dateEnd);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.ProduceSmsReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **group** | **string**| The id of the group to search | [optional] 
 **groupBy** | **string**| The option to group the results. Can be either &#x60;&#x60;day&#x60;&#x60; or &#x60;&#x60;month&#x60;&#x60;. Defaults to &#x60;&#x60;day&#x60;&#x60; if none are present | [optional] 
 **dateStart** | **string**| The date to start the report. Date must be in format &#x60;&#x60;yyyy-MM-dd&#x60;&#x60; | [optional] 
 **dateEnd** | **string**| The date to end the report. Date should be in format &#x60;&#x60;yyyy-MM-dd&#x60;&#x60; | [optional] 

### Return type

[**List<SmsReportResponse>**](SmsReportResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
