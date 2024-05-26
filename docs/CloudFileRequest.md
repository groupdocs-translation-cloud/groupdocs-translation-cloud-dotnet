# GroupDocs.Translation.Cloud.Sdk.Model.CloudFileRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Format** | **string** | \&quot;doc(x|m)\&quot; if Word document, \&quot;xls(x|m)\&quot; if Excel workbook | [optional] 
**OutFormat** | **string** | output file format | [optional] 
**RequestId** | **string** | id of request | [optional] 
**Ids** | **List&lt;int&gt;** | Language pairs to translate | [optional] 
**Url** | **string** | Link to file for translation | [optional] 
**Size** | **long** | File size | [optional] 
**Masters** | **bool** | If translate master slides | [optional] 
**Formatting** | **bool** | If document&#39;s formatting should be preserved, default true | [optional] 
**Origin** | **string** | for analysis only | [optional] 
**Elements** | **List&lt;int&gt;** | List of slides to translate | [optional] 
**Ranges** | [**Dictionary&lt;string, WorksheetData&gt;**](WorksheetData.md) | Dictionary of ranges in Excel workbooks | [optional] 
**ShortCodeDict** | **Dictionary&lt;string, List&lt;string&gt;&gt;** | Dictiory of short code names and parameters names to translate | [optional] 
**FrontMatterList** | **List&lt;List&lt;string&gt;&gt;** | Dictionary where key is zero-based front matter index and value is list of lists of front matter paths | [optional] 
**OriginalFileName** | **string** | Original name of file | [optional] 
**Separator** | **string** | Separator in files | [optional] 
**IsPaid** | **bool** | Set true if paid user | [optional] 
**SavingMode** | **string** | Toggle files saving mode | [optional] 
**Details** | **Dictionary&lt;string, string&gt;** | Details of the requests. Using for e2e tracking | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

