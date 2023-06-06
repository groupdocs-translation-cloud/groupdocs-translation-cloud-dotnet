# GroupDocs.Translation.Api.Api.TransportApi

All URIs are relative to *https://api.groupdocs.cloud/v2.0/translation*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AllFormatsPost**](TransportApi.md#allformatspost) | **POST** /all-formats | Translate any supported file |
| [**AvailableLanguagesGet**](TransportApi.md#availablelanguagesget) | **GET** /available-languages | Return list of available language pairs |
| [**CsvPost**](TransportApi.md#csvpost) | **POST** /csv | Translate CSV and TSV files |
| [**DocumentPost**](TransportApi.md#documentpost) | **POST** /document | Translate Microsoft Word documents, rtf, txt, odt |
| [**DocumentRequestIdGet**](TransportApi.md#documentrequestidget) | **GET** /document/{requestId} | Return document translation status.  Also return URLs for downloading of translated document if translation was successful |
| [**HcGet**](TransportApi.md#hcget) | **GET** /hc | Health check for all services. |
| [**HtmlPost**](TransportApi.md#htmlpost) | **POST** /html | Translate HTML files |
| [**HugoGet**](TransportApi.md#hugoget) | **GET** /hugo | Get hugo syntax structure from markdown file |
| [**HugoPost**](TransportApi.md#hugopost) | **POST** /hugo | Run hugo syntax structure analyzing from markdown file |
| [**MarkdownPost**](TransportApi.md#markdownpost) | **POST** /markdown | Translate Markdown files |
| [**OcrFilePost**](TransportApi.md#ocrfilepost) | **POST** /ocr-file | Translate image or scanned pdf and return file |
| [**OcrTextPost**](TransportApi.md#ocrtextpost) | **POST** /ocr-text | Translate text on image or scanned pdf |
| [**PdfPost**](TransportApi.md#pdfpost) | **POST** /pdf | Translate pdf files |
| [**PresentationPost**](TransportApi.md#presentationpost) | **POST** /presentation | Translate Microsoft PowerPoint presentations, odp |
| [**ResourcesPost**](TransportApi.md#resourcespost) | **POST** /resources | Translate RESX files |
| [**SpreadsheetsPost**](TransportApi.md#spreadsheetspost) | **POST** /spreadsheets | Translate Microsoft Excel workbooks, ods |
| [**TextPost**](TransportApi.md#textpost) | **POST** /text | Translate text |
| [**TextRequestIdGet**](TransportApi.md#textrequestidget) | **GET** /text/{requestId} | Return text translation status.  Also return translated text if translation was successful |

<a name="allformatspost"></a>
# **AllFormatsPost**
> StatusResponse AllFormatsPost (string format, string outFormat, string source, List<string> targets, System.IO.Stream file, string url = null, bool? masters = null, bool? formatting = null, string origin = null, string route = null, string separator = null, List<int> elements = null, string savingMode = null)

Translate any supported file

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Translation.Api.Api;
using GroupDocs.Translation.Api.Client;
using GroupDocs.Translation.Api.Model;

namespace Example
{
    public class AllFormatsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.groupdocs.cloud/v2.0/translation";
            // Configure OAuth2 access token for authorization: JWT
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransportApi(config);
            var format = "Unknown";  // string | Input file format (default to Unknown)
            var outFormat = "outFormat_example";  // string | output file format
            var source = "\"en\"";  // string | Language of original file (default to "en")
            var targets = new List<string>(); // List<string> | List of target languages
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | File as byte array
            var url = "url_example";  // string | Link to file for translation (optional) 
            var masters = false;  // bool? | If translate master slides (optional)  (default to false)
            var formatting = true;  // bool? | If document's formatting should be preserved, default true (optional)  (default to true)
            var origin = "origin_example";  // string | for analysis only (optional) 
            var route = "route_example";  // string | endpoints route (optional) 
            var separator = "separator_example";  // string | Separator in files (optional) 
            var elements = new List<int>(); // List<int> | List of slides to translate (optional) 
            var savingMode = "Files";  // string | Toggle file saving mode for storage.  Is Files by default. (optional) 

            try
            {
                // Translate any supported file
                StatusResponse result = apiInstance.AllFormatsPost(format, outFormat, source, targets, file, url, masters, formatting, origin, route, separator, elements, savingMode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransportApi.AllFormatsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AllFormatsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Translate any supported file
    ApiResponse<StatusResponse> response = apiInstance.AllFormatsPostWithHttpInfo(format, outFormat, source, targets, file, url, masters, formatting, origin, route, separator, elements, savingMode);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransportApi.AllFormatsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **format** | **string** | Input file format | [default to Unknown] |
| **outFormat** | **string** | output file format |  |
| **source** | **string** | Language of original file | [default to &quot;en&quot;] |
| **targets** | [**List&lt;string&gt;**](string.md) | List of target languages |  |
| **file** | **System.IO.Stream****System.IO.Stream** | File as byte array |  |
| **url** | **string** | Link to file for translation | [optional]  |
| **masters** | **bool?** | If translate master slides | [optional] [default to false] |
| **formatting** | **bool?** | If document&#39;s formatting should be preserved, default true | [optional] [default to true] |
| **origin** | **string** | for analysis only | [optional]  |
| **route** | **string** | endpoints route | [optional]  |
| **separator** | **string** | Separator in files | [optional]  |
| **elements** | [**List&lt;int&gt;**](int.md) | List of slides to translate | [optional]  |
| **savingMode** | **string** | Toggle file saving mode for storage.  Is Files by default. | [optional]  |

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

<a name="availablelanguagesget"></a>
# **AvailableLanguagesGet**
> string AvailableLanguagesGet ()

Return list of available language pairs

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Translation.Api.Api;
using GroupDocs.Translation.Api.Client;
using GroupDocs.Translation.Api.Model;

namespace Example
{
    public class AvailableLanguagesGetExample
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
                string result = apiInstance.AvailableLanguagesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransportApi.AvailableLanguagesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AvailableLanguagesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Return list of available language pairs
    ApiResponse<string> response = apiInstance.AvailableLanguagesGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransportApi.AvailableLanguagesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**string**

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

<a name="csvpost"></a>
# **CsvPost**
> StatusResponse CsvPost (string outFormat, string source, List<string> targets, System.IO.Stream file, string format = null, string url = null, string origin = null, string separator = null, string savingMode = null)

Translate CSV and TSV files

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Translation.Api.Api;
using GroupDocs.Translation.Api.Client;
using GroupDocs.Translation.Api.Model;

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
            var outFormat = "outFormat_example";  // string | output file format
            var source = "\"en\"";  // string | Language of original file (default to "en")
            var targets = new List<string>(); // List<string> | List of target languages
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | File as byte array
            var format = "Unknown";  // string | Input file format (optional)  (default to Csv)
            var url = "url_example";  // string | Link to file for translation (optional) 
            var origin = "origin_example";  // string | for analysis only (optional) 
            var separator = "separator_example";  // string | Separator in files (optional) 
            var savingMode = "Files";  // string | Toggle file saving mode for storage.  Is Files by default. (optional) 

            try
            {
                // Translate CSV and TSV files
                StatusResponse result = apiInstance.CsvPost(outFormat, source, targets, file, format, url, origin, separator, savingMode);
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
    ApiResponse<StatusResponse> response = apiInstance.CsvPostWithHttpInfo(outFormat, source, targets, file, format, url, origin, separator, savingMode);
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
| **outFormat** | **string** | output file format |  |
| **source** | **string** | Language of original file | [default to &quot;en&quot;] |
| **targets** | [**List&lt;string&gt;**](string.md) | List of target languages |  |
| **file** | **System.IO.Stream****System.IO.Stream** | File as byte array |  |
| **format** | **string** | Input file format | [optional] [default to Csv] |
| **url** | **string** | Link to file for translation | [optional]  |
| **origin** | **string** | for analysis only | [optional]  |
| **separator** | **string** | Separator in files | [optional]  |
| **savingMode** | **string** | Toggle file saving mode for storage.  Is Files by default. | [optional]  |

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

<a name="documentpost"></a>
# **DocumentPost**
> StatusResponse DocumentPost (string format, string outFormat, string source, List<string> targets, System.IO.Stream file, string url = null, bool? formatting = null, string origin = null, string savingMode = null)

Translate Microsoft Word documents, rtf, txt, odt

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Translation.Api.Api;
using GroupDocs.Translation.Api.Client;
using GroupDocs.Translation.Api.Model;

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
            var format = "Unknown";  // string | Input file format (default to Docx)
            var outFormat = "outFormat_example";  // string | output file format
            var source = "\"en\"";  // string | Language of original file (default to "en")
            var targets = new List<string>(); // List<string> | List of target languages
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | File as byte array
            var url = "url_example";  // string | Link to file for translation (optional) 
            var formatting = true;  // bool? | If document's formatting should be preserved, default true (optional)  (default to true)
            var origin = "origin_example";  // string | for analysis only (optional) 
            var savingMode = "Files";  // string | Toggle file saving mode for storage.  Is Files by default. (optional) 

            try
            {
                // Translate Microsoft Word documents, rtf, txt, odt
                StatusResponse result = apiInstance.DocumentPost(format, outFormat, source, targets, file, url, formatting, origin, savingMode);
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
    ApiResponse<StatusResponse> response = apiInstance.DocumentPostWithHttpInfo(format, outFormat, source, targets, file, url, formatting, origin, savingMode);
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
| **format** | **string** | Input file format | [default to Docx] |
| **outFormat** | **string** | output file format |  |
| **source** | **string** | Language of original file | [default to &quot;en&quot;] |
| **targets** | [**List&lt;string&gt;**](string.md) | List of target languages |  |
| **file** | **System.IO.Stream****System.IO.Stream** | File as byte array |  |
| **url** | **string** | Link to file for translation | [optional]  |
| **formatting** | **bool?** | If document&#39;s formatting should be preserved, default true | [optional] [default to true] |
| **origin** | **string** | for analysis only | [optional]  |
| **savingMode** | **string** | Toggle file saving mode for storage.  Is Files by default. | [optional]  |

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

<a name="documentrequestidget"></a>
# **DocumentRequestIdGet**
> CloudFileResponse DocumentRequestIdGet (string requestId)

Return document translation status.  Also return URLs for downloading of translated document if translation was successful

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Translation.Api.Api;
using GroupDocs.Translation.Api.Client;
using GroupDocs.Translation.Api.Model;

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

<a name="hcget"></a>
# **HcGet**
> HealthCheckStatus HcGet ()

Health check for all services.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Translation.Api.Api;
using GroupDocs.Translation.Api.Client;
using GroupDocs.Translation.Api.Model;

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

<a name="htmlpost"></a>
# **HtmlPost**
> StatusResponse HtmlPost (string outFormat, string source, List<string> targets, System.IO.Stream file, string url = null, string origin = null, string savingMode = null)

Translate HTML files

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Translation.Api.Api;
using GroupDocs.Translation.Api.Client;
using GroupDocs.Translation.Api.Model;

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
            var outFormat = "outFormat_example";  // string | output file format
            var source = "\"en\"";  // string | Language of original file (default to "en")
            var targets = new List<string>(); // List<string> | List of target languages
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | File as byte array
            var url = "url_example";  // string | Link to file for translation (optional) 
            var origin = "origin_example";  // string | for analysis only (optional) 
            var savingMode = "Files";  // string | Toggle file saving mode for storage.  Is Files by default. (optional) 

            try
            {
                // Translate HTML files
                StatusResponse result = apiInstance.HtmlPost(outFormat, source, targets, file, url, origin, savingMode);
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
    ApiResponse<StatusResponse> response = apiInstance.HtmlPostWithHttpInfo(outFormat, source, targets, file, url, origin, savingMode);
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
| **outFormat** | **string** | output file format |  |
| **source** | **string** | Language of original file | [default to &quot;en&quot;] |
| **targets** | [**List&lt;string&gt;**](string.md) | List of target languages |  |
| **file** | **System.IO.Stream****System.IO.Stream** | File as byte array |  |
| **url** | **string** | Link to file for translation | [optional]  |
| **origin** | **string** | for analysis only | [optional]  |
| **savingMode** | **string** | Toggle file saving mode for storage.  Is Files by default. | [optional]  |

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

<a name="hugoget"></a>
# **HugoGet**
> CloudHugoResponse HugoGet (string id = null)

Get hugo syntax structure from markdown file

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Translation.Api.Api;
using GroupDocs.Translation.Api.Client;
using GroupDocs.Translation.Api.Model;

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

<a name="hugopost"></a>
# **HugoPost**
> StatusResponse HugoPost (System.IO.Stream file, string url = null)

Run hugo syntax structure analyzing from markdown file

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Translation.Api.Api;
using GroupDocs.Translation.Api.Client;
using GroupDocs.Translation.Api.Model;

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

<a name="markdownpost"></a>
# **MarkdownPost**
> StatusResponse MarkdownPost (string outFormat, string source, List<string> targets, System.IO.Stream file, string url = null, string origin = null, string savingMode = null)

Translate Markdown files

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Translation.Api.Api;
using GroupDocs.Translation.Api.Client;
using GroupDocs.Translation.Api.Model;

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
            var outFormat = "outFormat_example";  // string | output file format
            var source = "\"en\"";  // string | Language of original file (default to "en")
            var targets = new List<string>(); // List<string> | List of target languages
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | File as byte array
            var url = "url_example";  // string | Link to file for translation (optional) 
            var origin = "origin_example";  // string | for analysis only (optional) 
            var savingMode = "Files";  // string | Toggle file saving mode for storage.  Is Files by default. (optional) 

            try
            {
                // Translate Markdown files
                StatusResponse result = apiInstance.MarkdownPost(outFormat, source, targets, file, url, origin, savingMode);
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
    ApiResponse<StatusResponse> response = apiInstance.MarkdownPostWithHttpInfo(outFormat, source, targets, file, url, origin, savingMode);
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
| **outFormat** | **string** | output file format |  |
| **source** | **string** | Language of original file | [default to &quot;en&quot;] |
| **targets** | [**List&lt;string&gt;**](string.md) | List of target languages |  |
| **file** | **System.IO.Stream****System.IO.Stream** | File as byte array |  |
| **url** | **string** | Link to file for translation | [optional]  |
| **origin** | **string** | for analysis only | [optional]  |
| **savingMode** | **string** | Toggle file saving mode for storage.  Is Files by default. | [optional]  |

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

<a name="ocrfilepost"></a>
# **OcrFilePost**
> StatusResponse OcrFilePost (string ocrFormat, string outFormat, string source, List<string> targets, System.IO.Stream file, string format = null, string url = null, int? rotate = null, bool? formatting = null, string origin = null, string route = null, List<int> pages = null, string savingMode = null)

Translate image or scanned pdf and return file

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Translation.Api.Api;
using GroupDocs.Translation.Api.Client;
using GroupDocs.Translation.Api.Model;

namespace Example
{
    public class OcrFilePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.groupdocs.cloud/v2.0/translation";
            // Configure OAuth2 access token for authorization: JWT
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransportApi(config);
            var ocrFormat = "Pdf";  // string | File format after recognition (default to Pdf)
            var outFormat = "outFormat_example";  // string | output file format
            var source = "\"en\"";  // string | Language of original file (default to "en")
            var targets = new List<string>(); // List<string> | List of target languages
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | File as byte array
            var format = "Unknown";  // string | Original file format (optional)  (default to Unknown)
            var url = "url_example";  // string | Link to file for translation (optional) 
            var rotate = 56;  // int? | Left to write angle to rotate scanned image / pdf (optional) 
            var formatting = true;  // bool? | If document's formatting should be preserved, default true (optional)  (default to true)
            var origin = "origin_example";  // string | for analysis only (optional) 
            var route = "route_example";  // string | endpoints route (optional) 
            var pages = new List<int>(); // List<int> | List of pages to translate for scanned pdf (optional) 
            var savingMode = "Files";  // string | Toggle file saving mode for storage.  Is Files by default. (optional) 

            try
            {
                // Translate image or scanned pdf and return file
                StatusResponse result = apiInstance.OcrFilePost(ocrFormat, outFormat, source, targets, file, format, url, rotate, formatting, origin, route, pages, savingMode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransportApi.OcrFilePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OcrFilePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Translate image or scanned pdf and return file
    ApiResponse<StatusResponse> response = apiInstance.OcrFilePostWithHttpInfo(ocrFormat, outFormat, source, targets, file, format, url, rotate, formatting, origin, route, pages, savingMode);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransportApi.OcrFilePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ocrFormat** | **string** | File format after recognition | [default to Pdf] |
| **outFormat** | **string** | output file format |  |
| **source** | **string** | Language of original file | [default to &quot;en&quot;] |
| **targets** | [**List&lt;string&gt;**](string.md) | List of target languages |  |
| **file** | **System.IO.Stream****System.IO.Stream** | File as byte array |  |
| **format** | **string** | Original file format | [optional] [default to Unknown] |
| **url** | **string** | Link to file for translation | [optional]  |
| **rotate** | **int?** | Left to write angle to rotate scanned image / pdf | [optional]  |
| **formatting** | **bool?** | If document&#39;s formatting should be preserved, default true | [optional] [default to true] |
| **origin** | **string** | for analysis only | [optional]  |
| **route** | **string** | endpoints route | [optional]  |
| **pages** | [**List&lt;int&gt;**](int.md) | List of pages to translate for scanned pdf | [optional]  |
| **savingMode** | **string** | Toggle file saving mode for storage.  Is Files by default. | [optional]  |

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

<a name="ocrtextpost"></a>
# **OcrTextPost**
> StatusResponse OcrTextPost (string source, List<string> targets, System.IO.Stream file, string format = null, string url = null, int? rotate = null, bool? isHandwritten = null, string origin = null, string route = null)

Translate text on image or scanned pdf

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Translation.Api.Api;
using GroupDocs.Translation.Api.Client;
using GroupDocs.Translation.Api.Model;

namespace Example
{
    public class OcrTextPostExample
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
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | File as byte array
            var format = "Unknown";  // string | Originnal file format (optional)  (default to Unknown)
            var url = "url_example";  // string | Link to file for translation (optional) 
            var rotate = 56;  // int? | Left to write angle to rotate scanned image / pdf (optional) 
            var isHandwritten = true;  // bool? | is handwritten text (optional) 
            var origin = "origin_example";  // string | for analysis only (optional) 
            var route = "route_example";  // string | endpoints route (optional) 

            try
            {
                // Translate text on image or scanned pdf
                StatusResponse result = apiInstance.OcrTextPost(source, targets, file, format, url, rotate, isHandwritten, origin, route);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransportApi.OcrTextPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OcrTextPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Translate text on image or scanned pdf
    ApiResponse<StatusResponse> response = apiInstance.OcrTextPostWithHttpInfo(source, targets, file, format, url, rotate, isHandwritten, origin, route);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransportApi.OcrTextPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **source** | **string** | Language of original file | [default to &quot;en&quot;] |
| **targets** | [**List&lt;string&gt;**](string.md) | List of target languages |  |
| **file** | **System.IO.Stream****System.IO.Stream** | File as byte array |  |
| **format** | **string** | Originnal file format | [optional] [default to Unknown] |
| **url** | **string** | Link to file for translation | [optional]  |
| **rotate** | **int?** | Left to write angle to rotate scanned image / pdf | [optional]  |
| **isHandwritten** | **bool?** | is handwritten text | [optional]  |
| **origin** | **string** | for analysis only | [optional]  |
| **route** | **string** | endpoints route | [optional]  |

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

<a name="pdfpost"></a>
# **PdfPost**
> StatusResponse PdfPost (string outFormat, string source, List<string> targets, System.IO.Stream file, string url = null, bool? formatting = null, string origin = null, List<int> pages = null, string savingMode = null)

Translate pdf files

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Translation.Api.Api;
using GroupDocs.Translation.Api.Client;
using GroupDocs.Translation.Api.Model;

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
            var outFormat = "outFormat_example";  // string | output file format
            var source = "\"en\"";  // string | Language of original file (default to "en")
            var targets = new List<string>(); // List<string> | List of target languages
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | File as byte array
            var url = "url_example";  // string | Link to file for translation (optional) 
            var formatting = true;  // bool? | If document's formatting should be preserved, default true (optional)  (default to true)
            var origin = "origin_example";  // string | for analysis only (optional) 
            var pages = new List<int>(); // List<int> | List of pages to translate (optional) 
            var savingMode = "Files";  // string | Toggle file saving mode for storage.  Is Files by default. (optional) 

            try
            {
                // Translate pdf files
                StatusResponse result = apiInstance.PdfPost(outFormat, source, targets, file, url, formatting, origin, pages, savingMode);
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
    ApiResponse<StatusResponse> response = apiInstance.PdfPostWithHttpInfo(outFormat, source, targets, file, url, formatting, origin, pages, savingMode);
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
| **outFormat** | **string** | output file format |  |
| **source** | **string** | Language of original file | [default to &quot;en&quot;] |
| **targets** | [**List&lt;string&gt;**](string.md) | List of target languages |  |
| **file** | **System.IO.Stream****System.IO.Stream** | File as byte array |  |
| **url** | **string** | Link to file for translation | [optional]  |
| **formatting** | **bool?** | If document&#39;s formatting should be preserved, default true | [optional] [default to true] |
| **origin** | **string** | for analysis only | [optional]  |
| **pages** | [**List&lt;int&gt;**](int.md) | List of pages to translate | [optional]  |
| **savingMode** | **string** | Toggle file saving mode for storage.  Is Files by default. | [optional]  |

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

<a name="presentationpost"></a>
# **PresentationPost**
> StatusResponse PresentationPost (string format, string outFormat, string source, List<string> targets, System.IO.Stream file, string url = null, bool? masters = null, string origin = null, List<int> slides = null, string savingMode = null)

Translate Microsoft PowerPoint presentations, odp

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Translation.Api.Api;
using GroupDocs.Translation.Api.Client;
using GroupDocs.Translation.Api.Model;

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
            var format = "Unknown";  // string | Input file format (default to Pptx)
            var outFormat = "outFormat_example";  // string | output file format
            var source = "\"en\"";  // string | Language of original file (default to "en")
            var targets = new List<string>(); // List<string> | List of target languages
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | File as byte array
            var url = "url_example";  // string | Link to file for translation (optional) 
            var masters = false;  // bool? | If translate master slides (optional)  (default to false)
            var origin = "origin_example";  // string | for analysis only (optional) 
            var slides = new List<int>(); // List<int> | List of slides to translate (optional) 
            var savingMode = "Files";  // string | Toggle file saving mode for storage.  Is Files by default. (optional) 

            try
            {
                // Translate Microsoft PowerPoint presentations, odp
                StatusResponse result = apiInstance.PresentationPost(format, outFormat, source, targets, file, url, masters, origin, slides, savingMode);
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
    ApiResponse<StatusResponse> response = apiInstance.PresentationPostWithHttpInfo(format, outFormat, source, targets, file, url, masters, origin, slides, savingMode);
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
| **format** | **string** | Input file format | [default to Pptx] |
| **outFormat** | **string** | output file format |  |
| **source** | **string** | Language of original file | [default to &quot;en&quot;] |
| **targets** | [**List&lt;string&gt;**](string.md) | List of target languages |  |
| **file** | **System.IO.Stream****System.IO.Stream** | File as byte array |  |
| **url** | **string** | Link to file for translation | [optional]  |
| **masters** | **bool?** | If translate master slides | [optional] [default to false] |
| **origin** | **string** | for analysis only | [optional]  |
| **slides** | [**List&lt;int&gt;**](int.md) | List of slides to translate | [optional]  |
| **savingMode** | **string** | Toggle file saving mode for storage.  Is Files by default. | [optional]  |

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

<a name="resourcespost"></a>
# **ResourcesPost**
> StatusResponse ResourcesPost (string outFormat, string source, List<string> targets, System.IO.Stream file, string url = null, string origin = null, string savingMode = null)

Translate RESX files

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Translation.Api.Api;
using GroupDocs.Translation.Api.Client;
using GroupDocs.Translation.Api.Model;

namespace Example
{
    public class ResourcesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.groupdocs.cloud/v2.0/translation";
            // Configure OAuth2 access token for authorization: JWT
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransportApi(config);
            var outFormat = "outFormat_example";  // string | output file format
            var source = "\"en\"";  // string | Language of original file (default to "en")
            var targets = new List<string>(); // List<string> | List of target languages
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | File as byte array
            var url = "url_example";  // string | Link to file for translation (optional) 
            var origin = "origin_example";  // string | for analysis only (optional) 
            var savingMode = "Files";  // string | Toggle file saving mode for storage.  Is Files by default. (optional) 

            try
            {
                // Translate RESX files
                StatusResponse result = apiInstance.ResourcesPost(outFormat, source, targets, file, url, origin, savingMode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransportApi.ResourcesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ResourcesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Translate RESX files
    ApiResponse<StatusResponse> response = apiInstance.ResourcesPostWithHttpInfo(outFormat, source, targets, file, url, origin, savingMode);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransportApi.ResourcesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **outFormat** | **string** | output file format |  |
| **source** | **string** | Language of original file | [default to &quot;en&quot;] |
| **targets** | [**List&lt;string&gt;**](string.md) | List of target languages |  |
| **file** | **System.IO.Stream****System.IO.Stream** | File as byte array |  |
| **url** | **string** | Link to file for translation | [optional]  |
| **origin** | **string** | for analysis only | [optional]  |
| **savingMode** | **string** | Toggle file saving mode for storage.  Is Files by default. | [optional]  |

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

<a name="spreadsheetspost"></a>
# **SpreadsheetsPost**
> StatusResponse SpreadsheetsPost (string format, string outFormat, string source, List<string> targets, System.IO.Stream file, string url = null, string origin = null, List<int> worksheets = null, string savingMode = null)

Translate Microsoft Excel workbooks, ods

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Translation.Api.Api;
using GroupDocs.Translation.Api.Client;
using GroupDocs.Translation.Api.Model;

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
            var format = "Unknown";  // string | Input file format (default to Xlsx)
            var outFormat = "outFormat_example";  // string | output file format
            var source = "\"en\"";  // string | Language of original file (default to "en")
            var targets = new List<string>(); // List<string> | List of target languages
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | File as byte array
            var url = "url_example";  // string | Link to file for translation (optional) 
            var origin = "origin_example";  // string | for analysis only (optional) 
            var worksheets = new List<int>(); // List<int> | List of Worksheets to translate (optional) 
            var savingMode = "Files";  // string | Toggle file saving mode for storage.  Is Files by default. (optional) 

            try
            {
                // Translate Microsoft Excel workbooks, ods
                StatusResponse result = apiInstance.SpreadsheetsPost(format, outFormat, source, targets, file, url, origin, worksheets, savingMode);
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
    ApiResponse<StatusResponse> response = apiInstance.SpreadsheetsPostWithHttpInfo(format, outFormat, source, targets, file, url, origin, worksheets, savingMode);
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
| **format** | **string** | Input file format | [default to Xlsx] |
| **outFormat** | **string** | output file format |  |
| **source** | **string** | Language of original file | [default to &quot;en&quot;] |
| **targets** | [**List&lt;string&gt;**](string.md) | List of target languages |  |
| **file** | **System.IO.Stream****System.IO.Stream** | File as byte array |  |
| **url** | **string** | Link to file for translation | [optional]  |
| **origin** | **string** | for analysis only | [optional]  |
| **worksheets** | [**List&lt;int&gt;**](int.md) | List of Worksheets to translate | [optional]  |
| **savingMode** | **string** | Toggle file saving mode for storage.  Is Files by default. | [optional]  |

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

<a name="textpost"></a>
# **TextPost**
> StatusResponse TextPost (string source = null, List<string> targets = null, string text = null, List<string> texts = null, string origin = null)

Translate text

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Translation.Api.Api;
using GroupDocs.Translation.Api.Client;
using GroupDocs.Translation.Api.Model;

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
            var source = "source_example";  // string | Language of original text (optional) 
            var targets = new List<string>(); // List<string> | List of target languages (optional) 
            var text = "text_example";  // string | Text to translate (optional) 
            var texts = new List<string>(); // List<string> | Text array to translate (optional) 
            var origin = "origin_example";  // string | For analysis only (optional) 

            try
            {
                // Translate text
                StatusResponse result = apiInstance.TextPost(source, targets, text, texts, origin);
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
    ApiResponse<StatusResponse> response = apiInstance.TextPostWithHttpInfo(source, targets, text, texts, origin);
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
| **source** | **string** | Language of original text | [optional]  |
| **targets** | [**List&lt;string&gt;**](string.md) | List of target languages | [optional]  |
| **text** | **string** | Text to translate | [optional]  |
| **texts** | [**List&lt;string&gt;**](string.md) | Text array to translate | [optional]  |
| **origin** | **string** | For analysis only | [optional]  |

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

<a name="textrequestidget"></a>
# **TextRequestIdGet**
> CloudTextResponse TextRequestIdGet (string requestId)

Return text translation status.  Also return translated text if translation was successful

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Translation.Api.Api;
using GroupDocs.Translation.Api.Client;
using GroupDocs.Translation.Api.Model;

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

