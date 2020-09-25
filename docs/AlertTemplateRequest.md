# IO.Swagger.Model.AlertTemplateRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | the name to coloquially address the alert. | [optional] 
**Interval** | **int?** | The interval in seconds between messages to the recipient(s). Maximum interval is 86400 seconds (24 hours). | 
**MaxAttempts** | **int?** | The maximum amount of attempts to be made. | 
**TemplateId** | **string** | the id of the message template existent in the system. | [optional] 
**Subject** | **string** | the subject of the message. only used in email alerts. | [optional] 
**HtmlBody** | **string** | the html version of the body of the message. only used in email alerts. | [optional] 
**TextBody** | **string** | the text version of the message. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

