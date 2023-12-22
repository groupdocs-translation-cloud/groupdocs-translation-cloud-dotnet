# GroupDocs.Translation.Cloud.Sdk.Model.FileRequest

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
**Format** | **string** | Input file format | [optional] [default to FormatEnum.Unknown]
**OutputFormat** | **string** | output file format | [optional] 
**Masters** | **bool** | If translate master slides | [optional] [default to false]
**Formatting** | **bool** | If document&#39;s formatting should be preserved, default true | [optional] [default to true]
**Route** | **string** | Endpoint route | [optional] 
**Separator** | **string** | Separator in files | [optional] 
**Elements** | **List&lt;int&gt;** | List of slides to translate (1-based index). If not present, translate all elements (page, slide, worksheet) | [optional] 
**Ranges** | [**Dictionary&lt;string, WorksheetData&gt;**](WorksheetData.md) | Dictionary of ranges in Excel workbooks | [optional] 
**Shortcodedict** | **Dictionary&lt;string, List&lt;string&gt;&gt;** | Dictionary of short code names and parameters names to translate | [optional] 
**FrontMatterList** | **List&lt;List&lt;string&gt;&gt;** | Dictionary where key is zero-based front matter index and value is list of lists of front matter paths | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

