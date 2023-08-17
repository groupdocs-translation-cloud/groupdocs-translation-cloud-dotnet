# GroupDocs.Translation.Cloud.Sdk.Api.TransportApi

All URIs are relative to *https://api.groupdocs.cloud/v2.0/translation*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AutoPost**](TransportApi.md#autopost) | **POST** /auto | Translate any supported file |
| [**CsvPost**](TransportApi.md#csvpost) | **POST** /csv | Translate CSV and TSV files |
| [**DocumentPost**](TransportApi.md#documentpost) | **POST** /document | Translate Microsoft Word documents, rtf, txt, odt |
| [**DocumentRequestIdGet**](TransportApi.md#documentrequestidget) | **GET** /document/{requestId} | Return document translation status.  Also return URLs for downloading of translated document if translation was successful |
| [**HcGet**](TransportApi.md#hcget) | **GET** /hc | Health check for all services. |
| [**HtmlPost**](TransportApi.md#htmlpost) | **POST** /html | Translate HTML files |
| [**HugoGet**](TransportApi.md#hugoget) | **GET** /hugo | Get hugo syntax structure from markdown file |
| [**HugoPost**](TransportApi.md#hugopost) | **POST** /hugo | Run hugo syntax structure analyzing from markdown file |
| [**ImageToFilePost**](TransportApi.md#imagetofilepost) | **POST** /image-to-file | Translate image or scanned pdf and return file |
| [**ImageToTextPost**](TransportApi.md#imagetotextpost) | **POST** /image-to-text | Translate text on image or scanned pdf |
| [**LanguagesGet**](TransportApi.md#languagesget) | **GET** /languages | Return list of available language pairs |
| [**MarkdownPost**](TransportApi.md#markdownpost) | **POST** /markdown | Translate Markdown files |
| [**PdfPost**](TransportApi.md#pdfpost) | **POST** /pdf | Translate pdf files |
| [**PresentationPost**](TransportApi.md#presentationpost) | **POST** /presentation | Translate Microsoft PowerPoint presentations, odp |
| [**ResxPost**](TransportApi.md#resxpost) | **POST** /resx | Translate RESX files |
| [**SpreadsheetsPost**](TransportApi.md#spreadsheetspost) | **POST** /spreadsheets | Translate Microsoft Excel workbooks, ods |
| [**TextPost**](TransportApi.md#textpost) | **POST** /text | Translate text |
| [**TextRequestIdGet**](TransportApi.md#textrequestidget) | **GET** /text/{requestId} | Return text translation status.  Also return translated text if translation was successful |

<a id="autopost"></a>
# **AutoPost**
> StatusResponse AutoPost (AutoPostRequest autoPostRequest = null)

Translate any supported file

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Translation.Cloud.Sdk.Api;
using GroupDocs.Translation.Cloud.Sdk.Client;
using GroupDocs.Translation.Cloud.Sdk.Model;

namespace Example
{
    public class AutoPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.groupdocs.cloud/v2.0/translation";
            // Configure OAuth2 access token for authorization: JWT
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransportApi(config);
            var autoPostRequest = new AutoPostRequest(); // AutoPostRequest |  (optional) 

            try
            {
                // Translate any supported file
                StatusResponse result = apiInstance.AutoPost(autoPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransportApi.AutoPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AutoPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Translate any supported file
    ApiResponse<StatusResponse> response = apiInstance.AutoPostWithHttpInfo(autoPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransportApi.AutoPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **autoPostRequest** | [**AutoPostRequest**](AutoPostRequest.md) |  | [optional]  |

### Return type

[**StatusResponse**](StatusResponse.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="csvpost"></a>
# **CsvPost**
> StatusResponse CsvPost (CsvFileRequest csvFileRequest = null)

Translate CSV and TSV files

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Translation.Cloud.Sdk.Api;
using GroupDocs.Translation.Cloud.Sdk.Client;
using GroupDocs.Translation.Cloud.Sdk.Model;

namespace Example
{
    public class CsvPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.groupdocs.cloud/v2.0/translation";
            // Configure OAuth2 access token for authorization: JWT
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransportApi(config);
            var csvFileRequest = new CsvFileRequest(); // CsvFileRequest | String in body of request, containing JSON with parameters for translation. (optional) 

            try
            {
                // Translate CSV and TSV files
                StatusResponse result = apiInstance.CsvPost(csvFileRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransportApi.CsvPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CsvPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Translate CSV and TSV files
    ApiResponse<StatusResponse> response = apiInstance.CsvPostWithHttpInfo(csvFileRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransportApi.CsvPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **csvFileRequest** | [**CsvFileRequest**](CsvFileRequest.md) | String in body of request, containing JSON with parameters for translation. | [optional]  |

### Return type

[**StatusResponse**](StatusResponse.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="documentpost"></a>
# **DocumentPost**
> StatusResponse DocumentPost (TextDocumentFileRequest textDocumentFileRequest = null)

Translate Microsoft Word documents, rtf, txt, odt

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Translation.Cloud.Sdk.Api;
using GroupDocs.Translation.Cloud.Sdk.Client;
using GroupDocs.Translation.Cloud.Sdk.Model;

namespace Example
{
    public class DocumentPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.groupdocs.cloud/v2.0/translation";
            // Configure OAuth2 access token for authorization: JWT
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransportApi(config);
            var textDocumentFileRequest = new TextDocumentFileRequest(); // TextDocumentFileRequest | String in body of request, containing JSON with parameters for translation. (optional) 

            try
            {
                // Translate Microsoft Word documents, rtf, txt, odt
                StatusResponse result = apiInstance.DocumentPost(textDocumentFileRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransportApi.DocumentPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DocumentPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Translate Microsoft Word documents, rtf, txt, odt
    ApiResponse<StatusResponse> response = apiInstance.DocumentPostWithHttpInfo(textDocumentFileRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransportApi.DocumentPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **textDocumentFileRequest** | [**TextDocumentFileRequest**](TextDocumentFileRequest.md) | String in body of request, containing JSON with parameters for translation. | [optional]  |

### Return type

[**StatusResponse**](StatusResponse.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="documentrequestidget"></a>
# **DocumentRequestIdGet**
> CloudFileResponse DocumentRequestIdGet (string requestId)

Return document translation status.  Also return URLs for downloading of translated document if translation was successful

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Translation.Cloud.Sdk.Api;
using GroupDocs.Translation.Cloud.Sdk.Client;
using GroupDocs.Translation.Cloud.Sdk.Model;

namespace Example
{
    public class DocumentRequestIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.groupdocs.cloud/v2.0/translation";
            // Configure OAuth2 access token for authorization: JWT
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransportApi(config);
            var requestId = "requestId_example";  // string | GUID which got from /v3/translation/document response

            try
            {
                // Return document translation status.  Also return URLs for downloading of translated document if translation was successful
                CloudFileResponse result = apiInstance.DocumentRequestIdGet(requestId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransportApi.DocumentRequestIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DocumentRequestIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Return document translation status.  Also return URLs for downloading of translated document if translation was successful
    ApiResponse<CloudFileResponse> response = apiInstance.DocumentRequestIdGetWithHttpInfo(requestId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransportApi.DocumentRequestIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestId** | **string** | GUID which got from /v3/translation/document response |  |

### Return type

[**CloudFileResponse**](CloudFileResponse.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="hcget"></a>
# **HcGet**
> HealthCheckStatus HcGet ()

Health check for all services.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Translation.Cloud.Sdk.Api;
using GroupDocs.Translation.Cloud.Sdk.Client;
using GroupDocs.Translation.Cloud.Sdk.Model;

namespace Example
{
    public class HcGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.groupdocs.cloud/v2.0/translation";
            // Configure OAuth2 access token for authorization: JWT
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransportApi(config);

            try
            {
                // Health check for all services.
                HealthCheckStatus result = apiInstance.HcGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransportApi.HcGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HcGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Health check for all services.
    ApiResponse<HealthCheckStatus> response = apiInstance.HcGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransportApi.HcGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**HealthCheckStatus**](HealthCheckStatus.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="htmlpost"></a>
# **HtmlPost**
> StatusResponse HtmlPost (string sourceLanguage = null, List<string> targetLanguages = null, byte[] file = null, string originalFileName = null, string url = null, string origin = null, string savingMode = null, string outputFormat = null)

Translate HTML files

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Translation.Cloud.Sdk.Api;
using GroupDocs.Translation.Cloud.Sdk.Client;
using GroupDocs.Translation.Cloud.Sdk.Model;

namespace Example
{
    public class HtmlPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.groupdocs.cloud/v2.0/translation";
            // Configure OAuth2 access token for authorization: JWT
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransportApi(config);
            var sourceLanguage = "\"en\"";  // string | Language of original file (optional)  (default to "en")
            var targetLanguages = new List<string>(); // List<string> | List of target languages (optional) 
            var file = System.Text.Encoding.ASCII.GetBytes("BYTE_ARRAY_DATA_HERE");  // byte[] | File as byte array (optional) 
            var originalFileName = "originalFileName_example";  // string | Type in the file name. If null will be as request ID. (optional) 
            var url = "url_example";  // string | Link to file for translation. Ignore, if \\\"file\\\" property not null (optional) 
            var origin = "origin_example";  // string | Url or name of application using this SDK. Not required. (optional) 
            var savingMode = "Files";  // string | Toggle file saving mode for storage.  Is Files by default. (optional) 
            var outputFormat = "outputFormat_example";  // string | output file format (optional) 

            try
            {
                // Translate HTML files
                StatusResponse result = apiInstance.HtmlPost(sourceLanguage, targetLanguages, file, originalFileName, url, origin, savingMode, outputFormat);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransportApi.HtmlPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HtmlPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Translate HTML files
    ApiResponse<StatusResponse> response = apiInstance.HtmlPostWithHttpInfo(sourceLanguage, targetLanguages, file, originalFileName, url, origin, savingMode, outputFormat);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransportApi.HtmlPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sourceLanguage** | **string** | Language of original file | [optional] [default to &quot;en&quot;] |
| **targetLanguages** | [**List&lt;string&gt;**](string.md) | List of target languages | [optional]  |
| **file** | **byte[]** | File as byte array | [optional]  |
| **originalFileName** | **string** | Type in the file name. If null will be as request ID. | [optional]  |
| **url** | **string** | Link to file for translation. Ignore, if \\\&quot;file\\\&quot; property not null | [optional]  |
| **origin** | **string** | Url or name of application using this SDK. Not required. | [optional]  |
| **savingMode** | **string** | Toggle file saving mode for storage.  Is Files by default. | [optional]  |
| **outputFormat** | **string** | output file format | [optional]  |

### Return type

[**StatusResponse**](StatusResponse.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="hugoget"></a>
# **HugoGet**
> CloudHugoResponse HugoGet (string id = null)

Get hugo syntax structure from markdown file

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Translation.Cloud.Sdk.Api;
using GroupDocs.Translation.Cloud.Sdk.Client;
using GroupDocs.Translation.Cloud.Sdk.Model;

namespace Example
{
    public class HugoGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.groupdocs.cloud/v2.0/translation";
            // Configure OAuth2 access token for authorization: JWT
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransportApi(config);
            var id = "id_example";  // string | id from PostHugo> (optional) 

            try
            {
                // Get hugo syntax structure from markdown file
                CloudHugoResponse result = apiInstance.HugoGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransportApi.HugoGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HugoGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get hugo syntax structure from markdown file
    ApiResponse<CloudHugoResponse> response = apiInstance.HugoGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransportApi.HugoGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | id from PostHugo&gt; | [optional]  |

### Return type

[**CloudHugoResponse**](CloudHugoResponse.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="hugopost"></a>
# **HugoPost**
> StatusResponse HugoPost (System.IO.Stream file, string url = null)

Run hugo syntax structure analyzing from markdown file

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Translation.Cloud.Sdk.Api;
using GroupDocs.Translation.Cloud.Sdk.Client;
using GroupDocs.Translation.Cloud.Sdk.Model;

namespace Example
{
    public class HugoPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.groupdocs.cloud/v2.0/translation";
            // Configure OAuth2 access token for authorization: JWT
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransportApi(config);
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | File as byte array
            var url = "url_example";  // string | Link to file for translation (optional) 

            try
            {
                // Run hugo syntax structure analyzing from markdown file
                StatusResponse result = apiInstance.HugoPost(file, url);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransportApi.HugoPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HugoPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Run hugo syntax structure analyzing from markdown file
    ApiResponse<StatusResponse> response = apiInstance.HugoPostWithHttpInfo(file, url);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransportApi.HugoPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **file** | **System.IO.Stream****System.IO.Stream** | File as byte array |  |
| **url** | **string** | Link to file for translation | [optional]  |

### Return type

[**StatusResponse**](StatusResponse.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Accepted |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="imagetofilepost"></a>
# **ImageToFilePost**
> StatusResponse ImageToFilePost (OcrFileRequest ocrFileRequest = null)

Translate image or scanned pdf and return file

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Translation.Cloud.Sdk.Api;
using GroupDocs.Translation.Cloud.Sdk.Client;
using GroupDocs.Translation.Cloud.Sdk.Model;

namespace Example
{
    public class ImageToFilePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.groupdocs.cloud/v2.0/translation";
            // Configure OAuth2 access token for authorization: JWT
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransportApi(config);
            var ocrFileRequest = new OcrFileRequest(); // OcrFileRequest | String in body of request, containing JSON with parameters for translation. (optional) 

            try
            {
                // Translate image or scanned pdf and return file
                StatusResponse result = apiInstance.ImageToFilePost(ocrFileRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransportApi.ImageToFilePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ImageToFilePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Translate image or scanned pdf and return file
    ApiResponse<StatusResponse> response = apiInstance.ImageToFilePostWithHttpInfo(ocrFileRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransportApi.ImageToFilePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ocrFileRequest** | [**OcrFileRequest**](OcrFileRequest.md) | String in body of request, containing JSON with parameters for translation. | [optional]  |

### Return type

[**StatusResponse**](StatusResponse.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="imagetotextpost"></a>
# **ImageToTextPost**
> StatusResponse ImageToTextPost (string source, List<string> targets, string format = null, string url = null, int? rotate = null, bool? isHandwritten = null, string origin = null, string route = null, System.IO.Stream file = null)

Translate text on image or scanned pdf

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Translation.Cloud.Sdk.Api;
using GroupDocs.Translation.Cloud.Sdk.Client;
using GroupDocs.Translation.Cloud.Sdk.Model;

namespace Example
{
    public class ImageToTextPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.groupdocs.cloud/v2.0/translation";
            // Configure OAuth2 access token for authorization: JWT
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransportApi(config);
            var source = "\"en\"";  // string | Language of original file (default to "en")
            var targets = new List<string>(); // List<string> | List of target languages
            var format = "Unknown";  // string | Originnal file format (optional)  (default to Unknown)
            var url = "url_example";  // string | Link to file for translation (optional) 
            var rotate = 56;  // int? | Left to write angle to rotate scanned image / pdf (optional) 
            var isHandwritten = true;  // bool? | is handwritten text (optional) 
            var origin = "origin_example";  // string | for analysis only (optional) 
            var route = "route_example";  // string | endpoints route (optional) 
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream |  (optional) 

            try
            {
                // Translate text on image or scanned pdf
                StatusResponse result = apiInstance.ImageToTextPost(source, targets, format, url, rotate, isHandwritten, origin, route, file);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransportApi.ImageToTextPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ImageToTextPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Translate text on image or scanned pdf
    ApiResponse<StatusResponse> response = apiInstance.ImageToTextPostWithHttpInfo(source, targets, format, url, rotate, isHandwritten, origin, route, file);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransportApi.ImageToTextPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **source** | **string** | Language of original file | [default to &quot;en&quot;] |
| **targets** | [**List&lt;string&gt;**](string.md) | List of target languages |  |
| **format** | **string** | Originnal file format | [optional] [default to Unknown] |
| **url** | **string** | Link to file for translation | [optional]  |
| **rotate** | **int?** | Left to write angle to rotate scanned image / pdf | [optional]  |
| **isHandwritten** | **bool?** | is handwritten text | [optional]  |
| **origin** | **string** | for analysis only | [optional]  |
| **route** | **string** | endpoints route | [optional]  |
| **file** | **System.IO.Stream****System.IO.Stream** |  | [optional]  |

### Return type

[**StatusResponse**](StatusResponse.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="languagesget"></a>
# **LanguagesGet**
> List&lt;LanguagePairData&gt; LanguagesGet ()

Return list of available language pairs

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Translation.Cloud.Sdk.Api;
using GroupDocs.Translation.Cloud.Sdk.Client;
using GroupDocs.Translation.Cloud.Sdk.Model;

namespace Example
{
    public class LanguagesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.groupdocs.cloud/v2.0/translation";
            // Configure OAuth2 access token for authorization: JWT
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransportApi(config);

            try
            {
                // Return list of available language pairs
                List<LanguagePairData> result = apiInstance.LanguagesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransportApi.LanguagesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LanguagesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Return list of available language pairs
    ApiResponse<List<LanguagePairData>> response = apiInstance.LanguagesGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransportApi.LanguagesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;LanguagePairData&gt;**](LanguagePairData.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="markdownpost"></a>
# **MarkdownPost**
> StatusResponse MarkdownPost (string sourceLanguage, List<string> targetLanguages, string outputFormat, byte[] file = null, string originalFileName = null, string url = null, string origin = null, string savingMode = null, List<List<string>> frontMatterList = null)

Translate Markdown files

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Translation.Cloud.Sdk.Api;
using GroupDocs.Translation.Cloud.Sdk.Client;
using GroupDocs.Translation.Cloud.Sdk.Model;

namespace Example
{
    public class MarkdownPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.groupdocs.cloud/v2.0/translation";
            // Configure OAuth2 access token for authorization: JWT
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransportApi(config);
            var sourceLanguage = "\"en\"";  // string | Language of original file (default to "en")
            var targetLanguages = new List<string>(); // List<string> | List of target languages
            var outputFormat = "outputFormat_example";  // string | output file format
            var file = System.Text.Encoding.ASCII.GetBytes("BYTE_ARRAY_DATA_HERE");  // byte[] | File as byte array (optional) 
            var originalFileName = "originalFileName_example";  // string | Type in the file name. If null will be as request ID. (optional) 
            var url = "url_example";  // string | Link to file for translation. Ignore, if \\\"file\\\" property not null (optional) 
            var origin = "origin_example";  // string | Url or name of application using this SDK. Not required. (optional) 
            var savingMode = "Files";  // string | Toggle file saving mode for storage.  Is Files by default. (optional) 
            var frontMatterList = new List<List<string>>(); // List<List<string>> | List of lists of frontmatter paths (optional) 

            try
            {
                // Translate Markdown files
                StatusResponse result = apiInstance.MarkdownPost(sourceLanguage, targetLanguages, outputFormat, file, originalFileName, url, origin, savingMode, frontMatterList);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransportApi.MarkdownPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MarkdownPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Translate Markdown files
    ApiResponse<StatusResponse> response = apiInstance.MarkdownPostWithHttpInfo(sourceLanguage, targetLanguages, outputFormat, file, originalFileName, url, origin, savingMode, frontMatterList);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransportApi.MarkdownPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sourceLanguage** | **string** | Language of original file | [default to &quot;en&quot;] |
| **targetLanguages** | [**List&lt;string&gt;**](string.md) | List of target languages |  |
| **outputFormat** | **string** | output file format |  |
| **file** | **byte[]** | File as byte array | [optional]  |
| **originalFileName** | **string** | Type in the file name. If null will be as request ID. | [optional]  |
| **url** | **string** | Link to file for translation. Ignore, if \\\&quot;file\\\&quot; property not null | [optional]  |
| **origin** | **string** | Url or name of application using this SDK. Not required. | [optional]  |
| **savingMode** | **string** | Toggle file saving mode for storage.  Is Files by default. | [optional]  |
| **frontMatterList** | [**List&lt;List&lt;string&gt;&gt;**](List&lt;string&gt;.md) | List of lists of frontmatter paths | [optional]  |

### Return type

[**StatusResponse**](StatusResponse.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="pdfpost"></a>
# **PdfPost**
> StatusResponse PdfPost (PdfFileRequest pdfFileRequest = null)

Translate pdf files

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Translation.Cloud.Sdk.Api;
using GroupDocs.Translation.Cloud.Sdk.Client;
using GroupDocs.Translation.Cloud.Sdk.Model;

namespace Example
{
    public class PdfPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.groupdocs.cloud/v2.0/translation";
            // Configure OAuth2 access token for authorization: JWT
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransportApi(config);
            var pdfFileRequest = new PdfFileRequest(); // PdfFileRequest | String in body of request, containing JSON with parameters for translation. (optional) 

            try
            {
                // Translate pdf files
                StatusResponse result = apiInstance.PdfPost(pdfFileRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransportApi.PdfPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PdfPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Translate pdf files
    ApiResponse<StatusResponse> response = apiInstance.PdfPostWithHttpInfo(pdfFileRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransportApi.PdfPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pdfFileRequest** | [**PdfFileRequest**](PdfFileRequest.md) | String in body of request, containing JSON with parameters for translation. | [optional]  |

### Return type

[**StatusResponse**](StatusResponse.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="presentationpost"></a>
# **PresentationPost**
> StatusResponse PresentationPost (PresentationFileRequest presentationFileRequest = null)

Translate Microsoft PowerPoint presentations, odp

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Translation.Cloud.Sdk.Api;
using GroupDocs.Translation.Cloud.Sdk.Client;
using GroupDocs.Translation.Cloud.Sdk.Model;

namespace Example
{
    public class PresentationPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.groupdocs.cloud/v2.0/translation";
            // Configure OAuth2 access token for authorization: JWT
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransportApi(config);
            var presentationFileRequest = new PresentationFileRequest(); // PresentationFileRequest | String in body of request, containing JSON with parameters for translation. (optional) 

            try
            {
                // Translate Microsoft PowerPoint presentations, odp
                StatusResponse result = apiInstance.PresentationPost(presentationFileRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransportApi.PresentationPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PresentationPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Translate Microsoft PowerPoint presentations, odp
    ApiResponse<StatusResponse> response = apiInstance.PresentationPostWithHttpInfo(presentationFileRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransportApi.PresentationPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **presentationFileRequest** | [**PresentationFileRequest**](PresentationFileRequest.md) | String in body of request, containing JSON with parameters for translation. | [optional]  |

### Return type

[**StatusResponse**](StatusResponse.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="resxpost"></a>
# **ResxPost**
> StatusResponse ResxPost (ResxFileRequest resxFileRequest = null)

Translate RESX files

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Translation.Cloud.Sdk.Api;
using GroupDocs.Translation.Cloud.Sdk.Client;
using GroupDocs.Translation.Cloud.Sdk.Model;

namespace Example
{
    public class ResxPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.groupdocs.cloud/v2.0/translation";
            // Configure OAuth2 access token for authorization: JWT
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransportApi(config);
            var resxFileRequest = new ResxFileRequest(); // ResxFileRequest | String in body of request, containing JSON with parameters for translation. (optional) 

            try
            {
                // Translate RESX files
                StatusResponse result = apiInstance.ResxPost(resxFileRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransportApi.ResxPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ResxPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Translate RESX files
    ApiResponse<StatusResponse> response = apiInstance.ResxPostWithHttpInfo(resxFileRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransportApi.ResxPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **resxFileRequest** | [**ResxFileRequest**](ResxFileRequest.md) | String in body of request, containing JSON with parameters for translation. | [optional]  |

### Return type

[**StatusResponse**](StatusResponse.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="spreadsheetspost"></a>
# **SpreadsheetsPost**
> StatusResponse SpreadsheetsPost (SpreadsheetFileRequest spreadsheetFileRequest = null)

Translate Microsoft Excel workbooks, ods

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Translation.Cloud.Sdk.Api;
using GroupDocs.Translation.Cloud.Sdk.Client;
using GroupDocs.Translation.Cloud.Sdk.Model;

namespace Example
{
    public class SpreadsheetsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.groupdocs.cloud/v2.0/translation";
            // Configure OAuth2 access token for authorization: JWT
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransportApi(config);
            var spreadsheetFileRequest = new SpreadsheetFileRequest(); // SpreadsheetFileRequest | String in body of request, containing JSON with parameters for translation. (optional) 

            try
            {
                // Translate Microsoft Excel workbooks, ods
                StatusResponse result = apiInstance.SpreadsheetsPost(spreadsheetFileRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransportApi.SpreadsheetsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SpreadsheetsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Translate Microsoft Excel workbooks, ods
    ApiResponse<StatusResponse> response = apiInstance.SpreadsheetsPostWithHttpInfo(spreadsheetFileRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransportApi.SpreadsheetsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **spreadsheetFileRequest** | [**SpreadsheetFileRequest**](SpreadsheetFileRequest.md) | String in body of request, containing JSON with parameters for translation. | [optional]  |

### Return type

[**StatusResponse**](StatusResponse.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="textpost"></a>
# **TextPost**
> StatusResponse TextPost (TextRequest textRequest = null)

Translate text

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Translation.Cloud.Sdk.Api;
using GroupDocs.Translation.Cloud.Sdk.Client;
using GroupDocs.Translation.Cloud.Sdk.Model;

namespace Example
{
    public class TextPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.groupdocs.cloud/v2.0/translation";
            // Configure OAuth2 access token for authorization: JWT
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransportApi(config);
            var textRequest = new TextRequest(); // TextRequest | String in body of request, containing JSON with parameters for translation. (optional) 

            try
            {
                // Translate text
                StatusResponse result = apiInstance.TextPost(textRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransportApi.TextPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TextPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Translate text
    ApiResponse<StatusResponse> response = apiInstance.TextPostWithHttpInfo(textRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransportApi.TextPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **textRequest** | [**TextRequest**](TextRequest.md) | String in body of request, containing JSON with parameters for translation. | [optional]  |

### Return type

[**StatusResponse**](StatusResponse.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="textrequestidget"></a>
# **TextRequestIdGet**
> CloudTextResponse TextRequestIdGet (string requestId)

Return text translation status.  Also return translated text if translation was successful

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Translation.Cloud.Sdk.Api;
using GroupDocs.Translation.Cloud.Sdk.Client;
using GroupDocs.Translation.Cloud.Sdk.Model;

namespace Example
{
    public class TextRequestIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.groupdocs.cloud/v2.0/translation";
            // Configure OAuth2 access token for authorization: JWT
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransportApi(config);
            var requestId = "requestId_example";  // string | GUID which got from /v3/translation/text response

            try
            {
                // Return text translation status.  Also return translated text if translation was successful
                CloudTextResponse result = apiInstance.TextRequestIdGet(requestId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransportApi.TextRequestIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TextRequestIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Return text translation status.  Also return translated text if translation was successful
    ApiResponse<CloudTextResponse> response = apiInstance.TextRequestIdGetWithHttpInfo(requestId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransportApi.TextRequestIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestId** | **string** | GUID which got from /v3/translation/text response |  |

### Return type

[**CloudTextResponse**](CloudTextResponse.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

