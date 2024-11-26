# GroupDocs.Translation.Cloud.Sdk.Model.ImageToFileRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SourceLanguage** | **string** | Language of original file | [default to "en"]
**TargetLanguages** | **List&lt;string&gt;** | List of target languages | 
**OriginalFileName** | **string** | Type in the file name. If null will be as request ID. | [optional] 
**Url** | **string** | Link to file for translation. Ignore, if \&quot;file\&quot; property not null | [optional] 
**Origin** | **string** | Url or name of application using this SDK. Not required. | [optional] 
**SavingMode** | **string** | Toggle file saving mode for storage.  Is Files by default. | [optional] 
**Format** | **string** | Original file format | [optional] [default to FormatEnum.Unknown]
**Ocrformat** | **string** | File format after recognition | [default to OcrformatEnum.Pdf]
**OutputFormat** | **string** | output file format | 
**RotationAngle** | **int** | Left to write angle to rotate scanned image / pdf | [optional] 
**Formatting** | **bool** | If document&#39;s formatting should be preserved, default true | [optional] [default to true]
**Route** | **string** | endpoints route | [optional] 
**Pages** | **List&lt;int&gt;** | List of pages to translate for scanned pdf | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

