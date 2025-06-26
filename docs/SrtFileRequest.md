# GroupDocs.Translation.Cloud.Sdk.Model.SrtFileRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SourceLanguage** | **string** | Language of original file | [default to "en"]
**TargetLanguages** | **List&lt;string&gt;** | List of target languages | 
**OriginalFileName** | **string** | Type in the file name. If null will be as request ID. | [optional] 
**Url** | **string** | Link to file for translation. Ignore, if \&quot;file\&quot; property not null | 
**Origin** | **string** | Url or name of the application using this SDK. Not required. | [optional] 
**IsNeedAlignment** | **bool** | Do result formating like the source. This option needs more expensive requests. | [optional] 
**TranslationDictionary** | **Dictionary&lt;string, string&gt;** | Set a specific translation between source and target words. | [optional] 
**SavingMode** | **string** | Toggle file saving mode for storage.  Is Files by default. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

