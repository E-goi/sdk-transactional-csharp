# IO.Swagger.Api.GroupsApi

All URIs are relative to *https://slingshot.egoiapp.com/api/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListGroups**](GroupsApi.md#listgroups) | **GET** /v2/groups | Get All Groups

<a name="listgroups"></a>
# **ListGroups**
> List<GroupResponse> ListGroups (string channel = null)

Get All Groups

Retrieve all groups to sort messages

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListGroupsExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKey
            Configuration.Default.AddApiKey("ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("ApiKey", "Bearer");

            var apiInstance = new GroupsApi();
            var channel = channel_example;  // string | The channel of the groups. Can be `email` or `sms`, otherwise returns all groups. (optional) 

            try
            {
                // Get All Groups
                List&lt;GroupResponse&gt; result = apiInstance.ListGroups(channel);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.ListGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **channel** | **string**| The channel of the groups. Can be &#x60;email&#x60; or &#x60;sms&#x60;, otherwise returns all groups. | [optional] 

### Return type

[**List<GroupResponse>**](GroupResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
