# GroupDocs.Translation.Cloud.Sdk.Model.AutoPostRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Format** | **string** | Input file format | [default to FormatEnum.Unknown]
**OutputFormat** | **string** | output file format | 
**Masters** | **bool** | If translate master slides | [optional] [default to false]
**Formatting** | **bool** | If document&#39;s formatting should be preserved, default true | [optional] [default to true]
**Route** | **string** | Endpoint route | [optional] 
**Separator** | **string** | Separator in files | [optional] 
**Elements** | **List&lt;int&gt;** | List of slides to translate | [optional] 
**Ranges** | [**Dictionary&lt;string, WorksheetData&gt;**](WorksheetData.md) | Dictionary of ranges in Excel workbooks | [optional] 
**ShortCodeList** | **Dictionary&lt;string, List&lt;List&lt;string&gt;&gt;&gt;** | Dictionary of short code names and parameters names to translate | [optional] 
**FrontMatterList** | **List&lt;List&lt;string&gt;&gt;** | Dictionary where key is zero-based front matter index and value is list of lists of front matter paths | [optional] 
**SourceLanguage** | **string** | Language of original file | [default to "en"]
**TargetLanguages** | **List&lt;string&gt;** | List of target languages | 
**File** | **byte[]** | File as byte array | [optional] 
**OriginalFileName** | **string** | Type in the file name. If null will be as request ID. | [optional] 
**Url** | **string** | Link to file for translation. Ignore, if \&quot;file\&quot; property not null | [optional] 
**Origin** | **string** | Url or name of application using this SDK. Not required. | [optional] 
**SavingMode** | **string** | Toggle file saving mode for storage.  Is Files by default. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

