# GroupDocs.Translation.Cloud.Sdk.Model.TextDocumentFileRequest
Request for files with textual content (doc, docx, docm, rtf, odt, txt

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SourceLanguage** | **string** | Language of original file | [default to "en"]
**TargetLanguages** | **List&lt;string&gt;** | List of target languages | 
**File** | **byte[]** | File as byte array | [optional] 
**OriginalFileName** | **string** | Type in the file name. If null will be as request ID. | [optional] 
**Url** | **string** | Link to file for translation. Ignore, if \&quot;file\&quot; property not null | [optional] 
**SavingMode** | **string** | Toggle file saving mode for storage.  Is Files by default. | [optional] 
**Format** | **string** | Input file format | [default to FormatEnum.Docx]
**OutputFormat** | **string** | output file format | 
**PreserveFormatting** | **bool** | If document&#39;s formatting should be preserved, default true | [optional] [default to true]
**Origin** | **string** | for analysis only | [optional] 
**Pages** | **List&lt;int&gt;** | Choose pages for translation (1-based index). If not present, translate all pages | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

