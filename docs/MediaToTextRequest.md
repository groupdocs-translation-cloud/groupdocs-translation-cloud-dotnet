# GroupDocs.Translation.Cloud.Sdk.Model.MediaToTextRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SourceLanguage** | **string** | Language of original file | [default to "en"]
**TargetLanguages** | **List&lt;string&gt;** | List of target languages | 
**OriginalFileName** | **string** | Type in the file name. If null will be as request ID. | [optional] 
**Url** | **string** | Link to file for translation. Ignore, if \&quot;file\&quot; property not null | [optional] 
**Origin** | **string** | Url or name of application using this SDK. Not required. | [optional] 
**SavingMode** | **string** | Toggle file saving mode for storage.  Is Files by default. | [optional] 
**Source** | **string** | Language of original file | [default to "en"]
**Targets** | **List&lt;string&gt;** | List of target languages | 
**Format** | **string** | Input file format | [default to FormatEnum.Mp3]
**Fragments** | **List&lt;string&gt;** | Time fragments that require translation | [optional] 
**Route** | **string** | endpoints route | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

