# IO.Swagger.Model.ManualSMS
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**To** | **string** | The contact of the recipient. format should be countryCode-phoneNumber. | 
**From** | **string** | The id of the sender. | 
**TextBody** | **string** | The content of the message. | 
**Encoding** | **string** | the encoding of the message. | [optional] 
**MaxCount** | **int?** | the maximum amount of messages to be sent (if the textBody is too big for a single message). | [optional] 
**MergeTags** | **List&lt;string&gt;** | A list of the merge tags to replace information gaps in the email. The format of each tag should be &#x60;&#x60;tagName:tagValue&#x60;&#x60; | [optional] 
**Priority** | **string** | The priority of the message. | [optional] [default to PriorityEnum.NonUrgent]
**CustomData** | **string** | Extra Data related to the campaign to be re-sent via WebHook. | [optional] 
**Registered** | **bool?** | option to register the message. Its an exclusive feature for senders that require it. | [optional] [default to false]
**Group** | **string** | The group of the message. | [optional] [default to "default"]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

