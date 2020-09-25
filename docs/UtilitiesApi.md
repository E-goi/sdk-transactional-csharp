# IO.Swagger.Api.UtilitiesApi

All URIs are relative to *https://slingshot.egoiapp.com/api/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EmailValidator**](UtilitiesApi.md#emailvalidator) | **POST** /v2/emailValidator | Email Validator
[**HtmlToPdf**](UtilitiesApi.md#htmltopdf) | **POST** /v2/htmlToPdfConverter | HTML to PDF converter
[**PingApi**](UtilitiesApi.md#pingapi) | **GET** /v2/ping | Ping API
[**SmsLengthCalculator**](UtilitiesApi.md#smslengthcalculator) | **POST** /v2/smsLengthCalculator | SMS Length Calculator
[**ValidatePhone**](UtilitiesApi.md#validatephone) | **GET** /v2/validate-phone/{number} | Validate Phone

<a name="emailvalidator"></a>
# **EmailValidator**
> EmailValidatorResponse EmailValidator (EmailValidatorRequest body = null)

Email Validator

Validates status and heath of the email address

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EmailValidatorExample
    {
        public void main()
        {
            var apiInstance = new UtilitiesApi();
            var body = new EmailValidatorRequest(); // EmailValidatorRequest |  (optional) 

            try
            {
                // Email Validator
                EmailValidatorResponse result = apiInstance.EmailValidator(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UtilitiesApi.EmailValidator: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EmailValidatorRequest**](EmailValidatorRequest.md)|  | [optional] 

### Return type

[**EmailValidatorResponse**](EmailValidatorResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="htmltopdf"></a>
# **HtmlToPdf**
> HtmlToPdfResponse HtmlToPdf (HtmlToPdfRequest body = null)

HTML to PDF converter

Converts an HTML input (either via html string or url) to a PDF returned at base 64. Before using, please validate if your HTML content isdone accordingly to the best standards [HERE](https://validator.w3.org/)

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class HtmlToPdfExample
    {
        public void main()
        {
            var apiInstance = new UtilitiesApi();
            var body = new HtmlToPdfRequest(); // HtmlToPdfRequest |  (optional) 

            try
            {
                // HTML to PDF converter
                HtmlToPdfResponse result = apiInstance.HtmlToPdf(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UtilitiesApi.HtmlToPdf: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**HtmlToPdfRequest**](HtmlToPdfRequest.md)|  | [optional] 

### Return type

[**HtmlToPdfResponse**](HtmlToPdfResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="pingapi"></a>
# **PingApi**
> PingResponse PingApi ()

Ping API

Send an innocuous request to the API, in order to confirm its working as intended 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PingApiExample
    {
        public void main()
        {
            var apiInstance = new UtilitiesApi();

            try
            {
                // Ping API
                PingResponse result = apiInstance.PingApi();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UtilitiesApi.PingApi: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**PingResponse**](PingResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="smslengthcalculator"></a>
# **SmsLengthCalculator**
> SmsLengthCalculatorResponse SmsLengthCalculator (SmsLengthCalculatorRequest body = null)

SMS Length Calculator

Calculates the sizes of an SMS text

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SmsLengthCalculatorExample
    {
        public void main()
        {
            var apiInstance = new UtilitiesApi();
            var body = new SmsLengthCalculatorRequest(); // SmsLengthCalculatorRequest |  (optional) 

            try
            {
                // SMS Length Calculator
                SmsLengthCalculatorResponse result = apiInstance.SmsLengthCalculator(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UtilitiesApi.SmsLengthCalculator: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SmsLengthCalculatorRequest**](SmsLengthCalculatorRequest.md)|  | [optional] 

### Return type

[**SmsLengthCalculatorResponse**](SmsLengthCalculatorResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="validatephone"></a>
# **ValidatePhone**
> ValidatePhoneResponse ValidatePhone (string number)

Validate Phone

Checks if a phone number is valid. Can be either land line or mobile

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ValidatePhoneExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKey
            Configuration.Default.AddApiKey("ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("ApiKey", "Bearer");

            var apiInstance = new UtilitiesApi();
            var number = number_example;  // string | The phone number to validate. must be in format ``countryCode-mobileNumber``

            try
            {
                // Validate Phone
                ValidatePhoneResponse result = apiInstance.ValidatePhone(number);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UtilitiesApi.ValidatePhone: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **number** | **string**| The phone number to validate. must be in format &#x60;&#x60;countryCode-mobileNumber&#x60;&#x60; | 

### Return type

[**ValidatePhoneResponse**](ValidatePhoneResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
