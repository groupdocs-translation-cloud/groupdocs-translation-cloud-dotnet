# GroupDocs.Translation.Cloud.Sdk.Model.PresentationFileRequest
Request for presentation files like ppt, pptx, pptm, odp

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SourceLanguage** | **string** | Language of original file | [optional] [default to "en"]
**TargetLanguages** | **List&lt;string&gt;** | List of target languages | [optional] 
**File** | **byte[]** | File as byte array | [optional] 
**OriginalFileName** | **string** | Type in the file name. If null will be as request ID. | [optional] 
**Url** | **string** | Link to file for translation. Ignore, if \&quot;file\&quot; property not null | [optional] 
**Origin** | **string** | Url or name of application using this SDK. Not required. | [optional] 
**SavingMode** | **string** | Toggle file saving mode for storage.  Is Files by default. | [optional] 
**Format** | **string** | Input file format | [optional] [default to FormatEnum.Pptx]
**OutputFormat** | **string** | Output file format | [optional] 
**Masters** | **bool** | If translate master slides | [optional] [default to false]
**Slides** | **List&lt;int&gt;** | List of slides to translate | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

