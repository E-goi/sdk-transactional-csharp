# IO.Swagger.Model.TemplateEmail
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Domain** | **string** | the Domain to de used in the sender email. | [optional] 
**SenderId** | **string** | The code identification of the sender profile to be used. | 
**SenderName** | **string** | The name to be associated with the Domain to form the email. | [optional] 
**To** | **List&lt;string&gt;** | The To field in the email. | 
**Cc** | **List&lt;string&gt;** | The Cc field in the email. | [optional] 
**Bcc** | **List&lt;string&gt;** | The Bcc field in the email. | [optional] 
**ReplyToId** | **string** | The email id for if/when the recipient responds to the email. | [optional] 
**TemplateId** | **string** | The id of the template to use. | 
**Attachment** | [**List&lt;AttachmentRequest&gt;**](AttachmentRequest.md) | A list of files to be attached to the emails | [optional] 
**MergeTags** | **List&lt;string&gt;** | A list of the merge tags to replace information gaps in the email. The format of each tag should be &#x60;&#x60;tagName:tagValue&#x60;&#x60; | [optional] 
**CustomData** | **string** | Extra Data related to the campaign to be re-sent via WebHook. | [optional] 
**Priority** | **string** | The priority of the message. | [optional] [default to PriorityEnum.NonUrgent]
**Registered** | **bool?** | option to register the message. Its an exclusive feature for senders that require it. | [optional] [default to false]
**Header** | [**HeaderOptionsRequest**](HeaderOptionsRequest.md) |  | [optional] 
**Group** | **string** | The group of the message. | [optional] [default to "default"]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

