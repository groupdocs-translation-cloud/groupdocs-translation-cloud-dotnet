# GroupDocs.Translation.Cloud.Sdk.Model.XmlFileRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SourceLanguage** | **string** | Language of original file | [default to "en"]
**TargetLanguages** | **List&lt;string&gt;** | List of target languages | 
**File** | **byte[]** | File as byte array | [optional] 
**OriginalFileName** | **string** | Type in the file name. If null will be as request ID. | [optional] 
**Url** | **string** | Link to file for translation. Ignore, if \&quot;file\&quot; property not null | [optional] 
**Origin** | **string** | Url or name of application using this SDK. Not required. | [optional] 
**SavingMode** | **string** | Toggle file saving mode for storage.  Is Files by default. | [optional] 
**IgnoreList** | **List&lt;string&gt;** | List of elements for Xml, Json and Yaml formats. Determines which items should be blacklisted or whitelisted for processing depending on GroupDocs.Translation.ApiGateway.DTO.XmlFileRequest.IsWhiteList. | [optional] 
**IsWhiteList** | **bool** | Determines to which list the items in GroupDocs.Translation.ApiGateway.DTO.XmlFileRequest.IgnoreList should be allocated. The default is the black list. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

