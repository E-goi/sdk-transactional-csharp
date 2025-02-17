# IO.Swagger - the C# library for the Transactional API

# Introduction    This API is a service provided by [E-goi](www.e-goi.com) to send transactional messages.    Transactional Messaging is a 1-to-1 communication channel, usually from an organization directed to a specific consumer.   They can be triggered by:    * __Actions__ - The consumer interacts with the organization (ie.: online shopping);  * __Time__ - The consumer's actions are time-bounded by the organization (ie.: period of inactivity).    Because of the nature of these messages,   it is expected that the consumer is interested in the content of these messages.   Therefore, they have a different treatment from marketing messages, and have a higher acceptance and opening rate.    >DISCLAIMER  >  >Please notice that this platform is more delicate in regards to the nature and processing of its messages.  >  >It should NOT be used as a mean of mass marketing, scams, phishing or overall unruly behaviour.   >  >Failure to comply may lead to limitation of use and even termination of account.    ***

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: V2
- SDK version: 1.0.0
- Build package: io.swagger.codegen.v3.generators.dotnet.CSharpClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out IO.Swagger.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {
            // Configure API key authorization: ApiKey
            Configuration.Default.ApiKey.Add("ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("ApiKey", "Bearer");

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

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://slingshot.egoiapp.com/api/*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AlertsApi* | [**ChangeAlertTemplate**](docs/AlertsApi.md#changealerttemplate) | **PATCH** /v2/alert/template/{id} | Change Single Alert Template
*AlertsApi* | [**CreateAlertTemplate**](docs/AlertsApi.md#createalerttemplate) | **POST** /v2/alert/template | Create Alert Template
*AlertsApi* | [**ExecuteEmailAlert**](docs/AlertsApi.md#executeemailalert) | **POST** /v2/alert/action/execute | Execute Alert
*AlertsApi* | [**ListMultiChannel**](docs/AlertsApi.md#listmultichannel) | **GET** /v2/alert/template/{id} | Get Single Alert Template
*AlertsApi* | [**ListMultiChannel1**](docs/AlertsApi.md#listmultichannel1) | **GET** /v2/alert/template | Get All Alert Template
*AlertsApi* | [**RemoveAlertTemplate**](docs/AlertsApi.md#removealerttemplate) | **DELETE** /v2/alert/template/{id} | Remove Alert Template
*AlertsApi* | [**StopAlert**](docs/AlertsApi.md#stopalert) | **POST** /v2/alert/action/stop | Stop Alert
*DefaultApi* | [**RedocStyleDoc**](docs/DefaultApi.md#redocstyledoc) | **GET** /v2/redoc | 
*DomainsApi* | [**AddDomain**](docs/DomainsApi.md#adddomain) | **POST** /v2/domain | Create New Domain
*DomainsApi* | [**ChangeDefaultDomain**](docs/DomainsApi.md#changedefaultdomain) | **POST** /v2/domain/default | Change Default Domain
*DomainsApi* | [**ListDefaultDomain**](docs/DomainsApi.md#listdefaultdomain) | **GET** /v2/domain/default | Get Default Domain
*DomainsApi* | [**ListDomain**](docs/DomainsApi.md#listdomain) | **GET** /v2/domain/{id} | Get Single Domain
*DomainsApi* | [**ListDomains**](docs/DomainsApi.md#listdomains) | **GET** /v2/domain | Get All Domains
*DomainsApi* | [**ValidateDomain**](docs/DomainsApi.md#validatedomain) | **GET** /v2/domain/{id}/validate | Validate Single Domain
*EmailApi* | [**SendEmailMessages**](docs/EmailApi.md#sendemailmessages) | **POST** /v2/email/messages/action/send | Send an Email Message
*GroupsApi* | [**ListGroups**](docs/GroupsApi.md#listgroups) | **GET** /v2/groups | Get All Groups
*MessageInformationApi* | [**ListAllEmailMessages**](docs/MessageInformationApi.md#listallemailmessages) | **GET** /v2/email/messages | Get All Email Messages
*MessageInformationApi* | [**ListAllSmsMessages**](docs/MessageInformationApi.md#listallsmsmessages) | **GET** /v2/sms/messages | Get All Sms Messages
*MessageInformationApi* | [**ListSingleEmailMessage**](docs/MessageInformationApi.md#listsingleemailmessage) | **GET** /v2/email/messages/{id} | Get Single Email Messages
*MessageInformationApi* | [**ListSingleSmsMessage**](docs/MessageInformationApi.md#listsinglesmsmessage) | **GET** /v2/sms/messages/{id} | Get Single Sms Messages
*MultiChannelApi* | [**CreateMultiChannelFlow**](docs/MultiChannelApi.md#createmultichannelflow) | **POST** /v2/multi-channel/flow | Create Multi-Channel Flow
*MultiChannelApi* | [**ExecuteMultiChannel**](docs/MultiChannelApi.md#executemultichannel) | **POST** /v2/multi-channel/execute | Execute Multi-Channel
*MultiChannelApi* | [**ListMultiChannel2**](docs/MultiChannelApi.md#listmultichannel2) | **GET** /v2/multi-channel/flow/{id} | Get Single Multi-Channel Flow
*MultiChannelApi* | [**ListMultiChannels**](docs/MultiChannelApi.md#listmultichannels) | **GET** /v2/multi-channel/flow | Get All Multi-Channel Flows
*MultiChannelApi* | [**RemoveMultiChannel**](docs/MultiChannelApi.md#removemultichannel) | **DELETE** /v2/multi-channel/flow/{id} | Remove Single Multi-Channel
*PushApi* | [**AddApp**](docs/PushApi.md#addapp) | **POST** /v2/apps | Create App
*PushApi* | [**AddPushTemplate**](docs/PushApi.md#addpushtemplate) | **POST** /v2/push/templates | Create Push Template
*PushApi* | [**DeleteApp**](docs/PushApi.md#deleteapp) | **DELETE** /v2/apps/{id} | Remove App
*PushApi* | [**DeletePushTemplate**](docs/PushApi.md#deletepushtemplate) | **DELETE** /v2/push/templates/{id} | Remove Push Template
*PushApi* | [**ListApp**](docs/PushApi.md#listapp) | **GET** /v2/apps/{id} | Get an App
*PushApi* | [**ListApps**](docs/PushApi.md#listapps) | **GET** /v2/apps | Get All Apps
*PushApi* | [**ListPushTemplate**](docs/PushApi.md#listpushtemplate) | **GET** /v2/push/templates/{id} | Get an Push Template
*PushApi* | [**ListPushTemplates**](docs/PushApi.md#listpushtemplates) | **GET** /v2/push/templates | Get All Push Templates
*PushApi* | [**SendPushMessages**](docs/PushApi.md#sendpushmessages) | **POST** /v2/push/messages/action/send | Send a Push Message
*PushApi* | [**UpdateApp**](docs/PushApi.md#updateapp) | **PUT** /v2/apps/{id} | Update App
*PushApi* | [**UpdatePushTemplate**](docs/PushApi.md#updatepushtemplate) | **PATCH** /v2/push/templates/{id} | Update Push Template
*ReportsApi* | [**ProduceEmailReport**](docs/ReportsApi.md#produceemailreport) | **GET** /v2/email/reports | Get Email Report
*ReportsApi* | [**ProduceSmsReport**](docs/ReportsApi.md#producesmsreport) | **GET** /v2/sms/reports | Get Sms Report
*ScheduleApi* | [**CancelScheduledMessage**](docs/ScheduleApi.md#cancelscheduledmessage) | **POST** /v2/messages/{id}/action/send | Cancel a Scheduled Message
*SendersApi* | [**GetEmailSenders**](docs/SendersApi.md#getemailsenders) | **GET** /v2/email/senders | Get All Email Senders
*SendersApi* | [**GetSmsSenders**](docs/SendersApi.md#getsmssenders) | **GET** /v2/sms/senders | Get All Sms Senders
*SmsApi* | [**SendSmsMessages**](docs/SmsApi.md#sendsmsmessages) | **POST** /v2/sms/messages/action/send | Send an SMS Message
*UtilitiesApi* | [**EmailValidator**](docs/UtilitiesApi.md#emailvalidator) | **POST** /v2/emailValidator | Email Validator
*UtilitiesApi* | [**HtmlToPdf**](docs/UtilitiesApi.md#htmltopdf) | **POST** /v2/htmlToPdfConverter | HTML to PDF converter
*UtilitiesApi* | [**PingApi**](docs/UtilitiesApi.md#pingapi) | **GET** /v2/ping | Ping API
*UtilitiesApi* | [**SmsLengthCalculator**](docs/UtilitiesApi.md#smslengthcalculator) | **POST** /v2/smsLengthCalculator | SMS Length Calculator
*UtilitiesApi* | [**ValidatePhone**](docs/UtilitiesApi.md#validatephone) | **GET** /v2/validate-phone/{number} | Validate Phone
*VerifyApi* | [**CancelVerify**](docs/VerifyApi.md#cancelverify) | **POST** /v2/verify/{id}/cancel | Cancel Verify Request
*VerifyApi* | [**GetVerify**](docs/VerifyApi.md#getverify) | **GET** /v2/verify/{id} | Get Verify Request
*VerifyApi* | [**RequestVerify**](docs/VerifyApi.md#requestverify) | **POST** /v2/verify/request | Request Verify
*VerifyApi* | [**ResendVerify**](docs/VerifyApi.md#resendverify) | **POST** /v2/verify/{id}/resend | Resend Verify Code
*VerifyApi* | [**ValidateVerifyCode**](docs/VerifyApi.md#validateverifycode) | **POST** /v2/verify/{id}/validate | Validate Verify Code
*WebhooksApi* | [**AddWebHook**](docs/WebhooksApi.md#addwebhook) | **POST** /v2/webhooks | Create new Webhook
*WebhooksApi* | [**ListWebHooks**](docs/WebhooksApi.md#listwebhooks) | **GET** /v2/webhooks | Get All Webhooks
*WebhooksApi* | [**RemoveWebHook**](docs/WebhooksApi.md#removewebhook) | **DELETE** /v2/webhooks | Remove Webhook

<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AlertEmail](docs/AlertEmail.md)
 - [Model.AlertIdResponse](docs/AlertIdResponse.md)
 - [Model.AlertPush](docs/AlertPush.md)
 - [Model.AlertSms](docs/AlertSms.md)
 - [Model.AlertTemplateIdResponse](docs/AlertTemplateIdResponse.md)
 - [Model.AlertTemplateRequest](docs/AlertTemplateRequest.md)
 - [Model.AlertTemplateResponse](docs/AlertTemplateResponse.md)
 - [Model.AttachmentRequest](docs/AttachmentRequest.md)
 - [Model.Body](docs/Body.md)
 - [Model.Body1](docs/Body1.md)
 - [Model.CancelAlertRequest](docs/CancelAlertRequest.md)
 - [Model.CheckVerifyResponse](docs/CheckVerifyResponse.md)
 - [Model.CompleteEmailMessageResponse](docs/CompleteEmailMessageResponse.md)
 - [Model.CompleteSmsMessageResponse](docs/CompleteSmsMessageResponse.md)
 - [Model.DefaultDomainRequest](docs/DefaultDomainRequest.md)
 - [Model.DomainRequest](docs/DomainRequest.md)
 - [Model.DomainResponse](docs/DomainResponse.md)
 - [Model.EmailReportResponse](docs/EmailReportResponse.md)
 - [Model.EmailSenderResponse](docs/EmailSenderResponse.md)
 - [Model.EmailValidatorRequest](docs/EmailValidatorRequest.md)
 - [Model.EmailValidatorResponse](docs/EmailValidatorResponse.md)
 - [Model.Error400](docs/Error400.md)
 - [Model.Error401](docs/Error401.md)
 - [Model.Error403](docs/Error403.md)
 - [Model.Error404](docs/Error404.md)
 - [Model.Error500](docs/Error500.md)
 - [Model.ErrorGenericResponse](docs/ErrorGenericResponse.md)
 - [Model.ExecuteMultiChannelRequest](docs/ExecuteMultiChannelRequest.md)
 - [Model.GetWebhooksResponse](docs/GetWebhooksResponse.md)
 - [Model.GroupResponse](docs/GroupResponse.md)
 - [Model.HeaderOptionsRequest](docs/HeaderOptionsRequest.md)
 - [Model.HtmlToPdfRequest](docs/HtmlToPdfRequest.md)
 - [Model.HtmlToPdfResponse](docs/HtmlToPdfResponse.md)
 - [Model.JSONObject](docs/JSONObject.md)
 - [Model.ManualEmail](docs/ManualEmail.md)
 - [Model.ManualPush](docs/ManualPush.md)
 - [Model.ManualSMS](docs/ManualSMS.md)
 - [Model.MobileAppIdResponse](docs/MobileAppIdResponse.md)
 - [Model.MobileAppRequest](docs/MobileAppRequest.md)
 - [Model.MobileAppResponse](docs/MobileAppResponse.md)
 - [Model.MultiChannelFlowIdResponse](docs/MultiChannelFlowIdResponse.md)
 - [Model.MultiChannelFlowRequest](docs/MultiChannelFlowRequest.md)
 - [Model.MultiChannelFlowResponse](docs/MultiChannelFlowResponse.md)
 - [Model.MultiChannelIdResponse](docs/MultiChannelIdResponse.md)
 - [Model.MultiChannelMessageObject](docs/MultiChannelMessageObject.md)
 - [Model.OneOfbody](docs/OneOfbody.md)
 - [Model.OneOfbody1](docs/OneOfbody1.md)
 - [Model.PartialEmailMessageResponse](docs/PartialEmailMessageResponse.md)
 - [Model.PartialSmsMessageResponse](docs/PartialSmsMessageResponse.md)
 - [Model.PingResponse](docs/PingResponse.md)
 - [Model.PushTemplateRequest](docs/PushTemplateRequest.md)
 - [Model.SendMessageIdResponse](docs/SendMessageIdResponse.md)
 - [Model.SenderMultiChannelObject](docs/SenderMultiChannelObject.md)
 - [Model.SinglePushTemplateResponse](docs/SinglePushTemplateResponse.md)
 - [Model.SmsLengthCalculatorRequest](docs/SmsLengthCalculatorRequest.md)
 - [Model.SmsLengthCalculatorResponse](docs/SmsLengthCalculatorResponse.md)
 - [Model.SmsReportResponse](docs/SmsReportResponse.md)
 - [Model.SmsSenderResponse](docs/SmsSenderResponse.md)
 - [Model.TemplateEmail](docs/TemplateEmail.md)
 - [Model.TemplateIdResponse](docs/TemplateIdResponse.md)
 - [Model.TemplatePush](docs/TemplatePush.md)
 - [Model.TemplateSMS](docs/TemplateSMS.md)
 - [Model.ToEmailAlertObject](docs/ToEmailAlertObject.md)
 - [Model.ToMultiChannelObject](docs/ToMultiChannelObject.md)
 - [Model.ToPushAlertObject](docs/ToPushAlertObject.md)
 - [Model.ToPushAlertObjectMergeTags](docs/ToPushAlertObjectMergeTags.md)
 - [Model.ToSmsAlertObject](docs/ToSmsAlertObject.md)
 - [Model.ValidateCodeVerifyRequest](docs/ValidateCodeVerifyRequest.md)
 - [Model.ValidateDomainResponse](docs/ValidateDomainResponse.md)
 - [Model.ValidatePhoneResponse](docs/ValidatePhoneResponse.md)
 - [Model.VerifyIdResponse](docs/VerifyIdResponse.md)
 - [Model.VerifyRequest](docs/VerifyRequest.md)
 - [Model.WebhookEmail](docs/WebhookEmail.md)
 - [Model.WebhookIdResponse](docs/WebhookIdResponse.md)
 - [Model.WebhookPush](docs/WebhookPush.md)
 - [Model.WebhookSms](docs/WebhookSms.md)

<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="ApiKey"></a>
### ApiKey

- **Type**: API key
- **API key parameter name**: ApiKey
- **Location**: HTTP header

