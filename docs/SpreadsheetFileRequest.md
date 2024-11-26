# GroupDocs.Translation.Cloud.Sdk.Model.SpreadsheetFileRequest
Request for spreadsheet files, like xls, xlsx, xlsm, ods

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SourceLanguage** | **string** | Language of original file | [default to "en"]
**TargetLanguages** | **List&lt;string&gt;** | List of target languages | 
**OriginalFileName** | **string** | Type in the file name. If null will be as request ID. | [optional] 
**Url** | **string** | Link to file for translation. Ignore, if \&quot;file\&quot; property not null | [optional] 
**Origin** | **string** | Url or name of application using this SDK. Not required. | [optional] 
**SavingMode** | **string** | Toggle file saving mode for storage.  Is Files by default. | [optional] 
**Format** | **string** | Input file format | [default to FormatEnum.Xlsx]
**OutputFormat** | **string** | output file format | 
**Worksheets** | **List&lt;int&gt;** | List of Worksheets to translate by sequence number (1-based index). If not present, translate all worksheets | [optional] 
**Ranges** | [**Dictionary&lt;string, WorksheetData&gt;**](WorksheetData.md) | Dictionary of ranges in Excel workbooks | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

