# GroupDocs.Translation.Cloud.Sdk.Api.TranslationApi

All URIs are relative to *https://api.groupdocs.cloud/v2.0/translation*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AutoPost**](TranslationApi.md#autopost) | **POST** /auto | Translate any supported file |
| [**CsvPost**](TranslationApi.md#csvpost) | **POST** /csv | Translate CSV and TSV files |
| [**DocumentPost**](TranslationApi.md#documentpost) | **POST** /document | Translate Microsoft Word documents, rtf, txt, odt |
| [**DocumentRequestIdGet**](TranslationApi.md#documentrequestidget) | **GET** /document/{requestId} | Return document translation status.  Also return URLs for downloading of translated document if translation was successful |
| [**DocumentTrialGet**](TranslationApi.md#documenttrialget) | **GET** /document/trial | Return document translation status for trial request.  Also return URLs for downloading of translated document if translation was successful |
| [**DocumentTrialPost**](TranslationApi.md#documenttrialpost) | **POST** /document/trial | Trial translate Microsoft Word documents, rtf, txt, odt without conversation. Translate only first page or 1000 symbols. |
| [**HcGet**](TranslationApi.md#hcget) | **GET** /hc | Health check for all services. |
| [**HtmlPost**](TranslationApi.md#htmlpost) | **POST** /html | Translate HTML files |
| [**HugoGet**](TranslationApi.md#hugoget) | **GET** /hugo | Get hugo syntax structure from markdown file |
| [**HugoPost**](TranslationApi.md#hugopost) | **POST** /hugo | Run hugo syntax structure analyzing from markdown file |
| [**ImageToFilePost**](TranslationApi.md#imagetofilepost) | **POST** /image-to-file | Translate image or scanned pdf and return file |
| [**ImageToTextPost**](TranslationApi.md#imagetotextpost) | **POST** /image-to-text | Translate text on image or scanned pdf |
| [**LanguagesGet**](TranslationApi.md#languagesget) | **GET** /languages | Return list of available language pairs |
| [**MarkdownPost**](TranslationApi.md#markdownpost) | **POST** /markdown | Translate Markdown files |
| [**MediaToFilePost**](TranslationApi.md#mediatofilepost) | **POST** /media-to-file | Translate audio or video and return file as a result |
| [**MediaToTextPost**](TranslationApi.md#mediatotextpost) | **POST** /media-to-text | Translate audio or video and return text as a result |
| [**PdfPost**](TranslationApi.md#pdfpost) | **POST** /pdf | Translate pdf files |
| [**PdfTrialPost**](TranslationApi.md#pdftrialpost) | **POST** /pdf/trial | Trial pdf translation. Translate only first page without conversion to another format. |
| [**PresentationPost**](TranslationApi.md#presentationpost) | **POST** /presentation | Translate Microsoft PowerPoint presentations, odp |
| [**ResxPost**](TranslationApi.md#resxpost) | **POST** /resx | Translate Resx files |
| [**SpreadsheetPost**](TranslationApi.md#spreadsheetpost) | **POST** /spreadsheet | Translate Microsoft Excel workbooks, ods |
| [**SrtPost**](TranslationApi.md#srtpost) | **POST** /srt | Translate Srt files |
| [**TextPost**](TranslationApi.md#textpost) | **POST** /text | Translate text |
| [**TextRequestIdGet**](TranslationApi.md#textrequestidget) | **GET** /text/{requestId} | Return text translation status.  Also return translated text if translation was successful |
| [**TextTrialGet**](TranslationApi.md#texttrialget) | **GET** /text/trial | Return text translation status for trial requests.  Also return translated text if translation was successful |
| [**TextTrialPost**](TranslationApi.md#texttrialpost) | **POST** /text/trial | Trial translate text. Translate only 1000 symbols. |
| [**XmlPost**](TranslationApi.md#xmlpost) | **POST** /xml | Translate XML files |

<a id="autopost"></a>
# **AutoPost**
> StatusResponse AutoPost (FileRequest? fileRequest = null)

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

            var apiInstance = new TranslationApi(config);
            var fileRequest = new FileRequest?(); // FileRequest? | String in body of request, containing JSON with parameters for translation. (optional) 

            try
            {
                // Translate any supported file
                StatusResponse result = apiInstance.AutoPost(fileRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TranslationApi.AutoPost: " + e.Message);
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
    ApiResponse<StatusResponse> response = apiInstance.AutoPostWithHttpInfo(fileRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TranslationApi.AutoPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fileRequest** | [**FileRequest?**](FileRequest?.md) | String in body of request, containing JSON with parameters for translation. | [optional]  |

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
> StatusResponse CsvPost (CsvFileRequest? csvFileRequest = null)

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

            var apiInstance = new TranslationApi(config);
            var csvFileRequest = new CsvFileRequest?(); // CsvFileRequest? | String in body of request, containing JSON with parameters for translation. (optional) 

            try
            {
                // Translate CSV and TSV files
                StatusResponse result = apiInstance.CsvPost(csvFileRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TranslationApi.CsvPost: " + e.Message);
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
    Debug.Print("Exception when calling TranslationApi.CsvPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **csvFileRequest** | [**CsvFileRequest?**](CsvFileRequest?.md) | String in body of request, containing JSON with parameters for translation. | [optional]  |

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
> StatusResponse DocumentPost (TextDocumentFileRequest? textDocumentFileRequest = null)

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

            var apiInstance = new TranslationApi(config);
            var textDocumentFileRequest = new TextDocumentFileRequest?(); // TextDocumentFileRequest? | String in body of request, containing JSON with parameters for translation. (optional) 

            try
            {
                // Translate Microsoft Word documents, rtf, txt, odt
                StatusResponse result = apiInstance.DocumentPost(textDocumentFileRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TranslationApi.DocumentPost: " + e.Message);
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
    Debug.Print("Exception when calling TranslationApi.DocumentPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **textDocumentFileRequest** | [**TextDocumentFileRequest?**](TextDocumentFileRequest?.md) | String in body of request, containing JSON with parameters for translation. | [optional]  |

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

            var apiInstance = new TranslationApi(config);
            var requestId = "requestId_example";  // string | GUID which got from /translation/document response

            try
            {
                // Return document translation status.  Also return URLs for downloading of translated document if translation was successful
                CloudFileResponse result = apiInstance.DocumentRequestIdGet(requestId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TranslationApi.DocumentRequestIdGet: " + e.Message);
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
    Debug.Print("Exception when calling TranslationApi.DocumentRequestIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestId** | **string** | GUID which got from /translation/document response |  |

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
| **102** | Information |  -  |
| **202** | Accepted |  -  |
| **404** | Not Found |  -  |
| **206** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="documenttrialget"></a>
# **DocumentTrialGet**
> CloudFileResponse DocumentTrialGet (string? requestId = null)

Return document translation status for trial request.  Also return URLs for downloading of translated document if translation was successful

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Translation.Cloud.Sdk.Api;
using GroupDocs.Translation.Cloud.Sdk.Client;
using GroupDocs.Translation.Cloud.Sdk.Model;

namespace Example
{
    public class DocumentTrialGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.groupdocs.cloud/v2.0/translation";
            // Configure OAuth2 access token for authorization: JWT
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TranslationApi(config);
            var requestId = "requestId_example";  // string? | GUID which got from /v3/translation/document response (optional) 

            try
            {
                // Return document translation status for trial request.  Also return URLs for downloading of translated document if translation was successful
                CloudFileResponse result = apiInstance.DocumentTrialGet(requestId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TranslationApi.DocumentTrialGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DocumentTrialGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Return document translation status for trial request.  Also return URLs for downloading of translated document if translation was successful
    ApiResponse<CloudFileResponse> response = apiInstance.DocumentTrialGetWithHttpInfo(requestId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TranslationApi.DocumentTrialGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestId** | **string?** | GUID which got from /v3/translation/document response | [optional]  |

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

<a id="documenttrialpost"></a>
# **DocumentTrialPost**
> StatusResponse DocumentTrialPost (TextDocumentFileRequest? textDocumentFileRequest = null)

Trial translate Microsoft Word documents, rtf, txt, odt without conversation. Translate only first page or 1000 symbols.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Translation.Cloud.Sdk.Api;
using GroupDocs.Translation.Cloud.Sdk.Client;
using GroupDocs.Translation.Cloud.Sdk.Model;

namespace Example
{
    public class DocumentTrialPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.groupdocs.cloud/v2.0/translation";
            // Configure OAuth2 access token for authorization: JWT
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TranslationApi(config);
            var textDocumentFileRequest = new TextDocumentFileRequest?(); // TextDocumentFileRequest? | String in body of request, containing JSON with parameters for translation. (optional) 

            try
            {
                // Trial translate Microsoft Word documents, rtf, txt, odt without conversation. Translate only first page or 1000 symbols.
                StatusResponse result = apiInstance.DocumentTrialPost(textDocumentFileRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TranslationApi.DocumentTrialPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DocumentTrialPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Trial translate Microsoft Word documents, rtf, txt, odt without conversation. Translate only first page or 1000 symbols.
    ApiResponse<StatusResponse> response = apiInstance.DocumentTrialPostWithHttpInfo(textDocumentFileRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TranslationApi.DocumentTrialPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **textDocumentFileRequest** | [**TextDocumentFileRequest?**](TextDocumentFileRequest?.md) | String in body of request, containing JSON with parameters for translation. | [optional]  |

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

            var apiInstance = new TranslationApi(config);

            try
            {
                // Health check for all services.
                HealthCheckStatus result = apiInstance.HcGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TranslationApi.HcGet: " + e.Message);
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
    Debug.Print("Exception when calling TranslationApi.HcGetWithHttpInfo: " + e.Message);
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
> StatusResponse HtmlPost (HtmlFileRequest? htmlFileRequest = null)

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

            var apiInstance = new TranslationApi(config);
            var htmlFileRequest = new HtmlFileRequest?(); // HtmlFileRequest? | String in body of request, containing JSON with parameters for translation. (optional) 

            try
            {
                // Translate HTML files
                StatusResponse result = apiInstance.HtmlPost(htmlFileRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TranslationApi.HtmlPost: " + e.Message);
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
    ApiResponse<StatusResponse> response = apiInstance.HtmlPostWithHttpInfo(htmlFileRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TranslationApi.HtmlPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **htmlFileRequest** | [**HtmlFileRequest?**](HtmlFileRequest?.md) | String in body of request, containing JSON with parameters for translation. | [optional]  |

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

<a id="hugoget"></a>
# **HugoGet**
> CloudHugoResponse HugoGet (string? id = null)

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

            var apiInstance = new TranslationApi(config);
            var id = "id_example";  // string? | id from PostHugo> (optional) 

            try
            {
                // Get hugo syntax structure from markdown file
                CloudHugoResponse result = apiInstance.HugoGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TranslationApi.HugoGet: " + e.Message);
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
    Debug.Print("Exception when calling TranslationApi.HugoGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string?** | id from PostHugo&gt; | [optional]  |

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
> StatusResponse HugoPost (HugoRequest? hugoRequest = null)

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

            var apiInstance = new TranslationApi(config);
            var hugoRequest = new HugoRequest?(); // HugoRequest? |  (optional) 

            try
            {
                // Run hugo syntax structure analyzing from markdown file
                StatusResponse result = apiInstance.HugoPost(hugoRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TranslationApi.HugoPost: " + e.Message);
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
    ApiResponse<StatusResponse> response = apiInstance.HugoPostWithHttpInfo(hugoRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TranslationApi.HugoPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **hugoRequest** | [**HugoRequest?**](HugoRequest?.md) |  | [optional]  |

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
| **202** | Accepted |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="imagetofilepost"></a>
# **ImageToFilePost**
> StatusResponse ImageToFilePost (ImageToFileRequest? imageToFileRequest = null)

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

            var apiInstance = new TranslationApi(config);
            var imageToFileRequest = new ImageToFileRequest?(); // ImageToFileRequest? | String in body of request, containing JSON with parameters for translation. (optional) 

            try
            {
                // Translate image or scanned pdf and return file
                StatusResponse result = apiInstance.ImageToFilePost(imageToFileRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TranslationApi.ImageToFilePost: " + e.Message);
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
    ApiResponse<StatusResponse> response = apiInstance.ImageToFilePostWithHttpInfo(imageToFileRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TranslationApi.ImageToFilePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **imageToFileRequest** | [**ImageToFileRequest?**](ImageToFileRequest?.md) | String in body of request, containing JSON with parameters for translation. | [optional]  |

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
> StatusResponse ImageToTextPost (ImageToTextRequest? imageToTextRequest = null)

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

            var apiInstance = new TranslationApi(config);
            var imageToTextRequest = new ImageToTextRequest?(); // ImageToTextRequest? | String in body of request, containing JSON with parameters for translation. (optional) 

            try
            {
                // Translate text on image or scanned pdf
                StatusResponse result = apiInstance.ImageToTextPost(imageToTextRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TranslationApi.ImageToTextPost: " + e.Message);
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
    ApiResponse<StatusResponse> response = apiInstance.ImageToTextPostWithHttpInfo(imageToTextRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TranslationApi.ImageToTextPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **imageToTextRequest** | [**ImageToTextRequest?**](ImageToTextRequest?.md) | String in body of request, containing JSON with parameters for translation. | [optional]  |

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

            var apiInstance = new TranslationApi(config);

            try
            {
                // Return list of available language pairs
                List<LanguagePairData> result = apiInstance.LanguagesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TranslationApi.LanguagesGet: " + e.Message);
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
    Debug.Print("Exception when calling TranslationApi.LanguagesGetWithHttpInfo: " + e.Message);
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
> StatusResponse MarkdownPost (MarkdownFileRequest? markdownFileRequest = null)

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

            var apiInstance = new TranslationApi(config);
            var markdownFileRequest = new MarkdownFileRequest?(); // MarkdownFileRequest? | String in body of request, containing JSON with parameters for translation. (optional) 

            try
            {
                // Translate Markdown files
                StatusResponse result = apiInstance.MarkdownPost(markdownFileRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TranslationApi.MarkdownPost: " + e.Message);
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
    ApiResponse<StatusResponse> response = apiInstance.MarkdownPostWithHttpInfo(markdownFileRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TranslationApi.MarkdownPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **markdownFileRequest** | [**MarkdownFileRequest?**](MarkdownFileRequest?.md) | String in body of request, containing JSON with parameters for translation. | [optional]  |

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

<a id="mediatofilepost"></a>
# **MediaToFilePost**
> StatusResponse MediaToFilePost (MediaToFileRequest? mediaToFileRequest = null)

Translate audio or video and return file as a result

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Translation.Cloud.Sdk.Api;
using GroupDocs.Translation.Cloud.Sdk.Client;
using GroupDocs.Translation.Cloud.Sdk.Model;

namespace Example
{
    public class MediaToFilePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.groupdocs.cloud/v2.0/translation";
            // Configure OAuth2 access token for authorization: JWT
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TranslationApi(config);
            var mediaToFileRequest = new MediaToFileRequest?(); // MediaToFileRequest? | String in body of request, containing JSON with parameters for translation. (optional) 

            try
            {
                // Translate audio or video and return file as a result
                StatusResponse result = apiInstance.MediaToFilePost(mediaToFileRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TranslationApi.MediaToFilePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MediaToFilePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Translate audio or video and return file as a result
    ApiResponse<StatusResponse> response = apiInstance.MediaToFilePostWithHttpInfo(mediaToFileRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TranslationApi.MediaToFilePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **mediaToFileRequest** | [**MediaToFileRequest?**](MediaToFileRequest?.md) | String in body of request, containing JSON with parameters for translation. | [optional]  |

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

<a id="mediatotextpost"></a>
# **MediaToTextPost**
> StatusResponse MediaToTextPost (MediaToTextRequest? mediaToTextRequest = null)

Translate audio or video and return text as a result

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Translation.Cloud.Sdk.Api;
using GroupDocs.Translation.Cloud.Sdk.Client;
using GroupDocs.Translation.Cloud.Sdk.Model;

namespace Example
{
    public class MediaToTextPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.groupdocs.cloud/v2.0/translation";
            // Configure OAuth2 access token for authorization: JWT
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TranslationApi(config);
            var mediaToTextRequest = new MediaToTextRequest?(); // MediaToTextRequest? | String in body of request, containing JSON with parameters for translation. (optional) 

            try
            {
                // Translate audio or video and return text as a result
                StatusResponse result = apiInstance.MediaToTextPost(mediaToTextRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TranslationApi.MediaToTextPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MediaToTextPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Translate audio or video and return text as a result
    ApiResponse<StatusResponse> response = apiInstance.MediaToTextPostWithHttpInfo(mediaToTextRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TranslationApi.MediaToTextPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **mediaToTextRequest** | [**MediaToTextRequest?**](MediaToTextRequest?.md) | String in body of request, containing JSON with parameters for translation. | [optional]  |

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

<a id="pdfpost"></a>
# **PdfPost**
> StatusResponse PdfPost (PdfFileRequest? pdfFileRequest = null)

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

            var apiInstance = new TranslationApi(config);
            var pdfFileRequest = new PdfFileRequest?(); // PdfFileRequest? | String in body of request, containing JSON with parameters for translation. (optional) 

            try
            {
                // Translate pdf files
                StatusResponse result = apiInstance.PdfPost(pdfFileRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TranslationApi.PdfPost: " + e.Message);
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
    Debug.Print("Exception when calling TranslationApi.PdfPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pdfFileRequest** | [**PdfFileRequest?**](PdfFileRequest?.md) | String in body of request, containing JSON with parameters for translation. | [optional]  |

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

<a id="pdftrialpost"></a>
# **PdfTrialPost**
> StatusResponse PdfTrialPost (PdfFileRequest? pdfFileRequest = null)

Trial pdf translation. Translate only first page without conversion to another format.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Translation.Cloud.Sdk.Api;
using GroupDocs.Translation.Cloud.Sdk.Client;
using GroupDocs.Translation.Cloud.Sdk.Model;

namespace Example
{
    public class PdfTrialPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.groupdocs.cloud/v2.0/translation";
            // Configure OAuth2 access token for authorization: JWT
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TranslationApi(config);
            var pdfFileRequest = new PdfFileRequest?(); // PdfFileRequest? | String in body of request, containing JSON with parameters for translation. (optional) 

            try
            {
                // Trial pdf translation. Translate only first page without conversion to another format.
                StatusResponse result = apiInstance.PdfTrialPost(pdfFileRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TranslationApi.PdfTrialPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PdfTrialPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Trial pdf translation. Translate only first page without conversion to another format.
    ApiResponse<StatusResponse> response = apiInstance.PdfTrialPostWithHttpInfo(pdfFileRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TranslationApi.PdfTrialPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pdfFileRequest** | [**PdfFileRequest?**](PdfFileRequest?.md) | String in body of request, containing JSON with parameters for translation. | [optional]  |

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
> StatusResponse PresentationPost (PresentationFileRequest? presentationFileRequest = null)

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

            var apiInstance = new TranslationApi(config);
            var presentationFileRequest = new PresentationFileRequest?(); // PresentationFileRequest? | String in body of request, containing JSON with parameters for translation. (optional) 

            try
            {
                // Translate Microsoft PowerPoint presentations, odp
                StatusResponse result = apiInstance.PresentationPost(presentationFileRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TranslationApi.PresentationPost: " + e.Message);
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
    Debug.Print("Exception when calling TranslationApi.PresentationPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **presentationFileRequest** | [**PresentationFileRequest?**](PresentationFileRequest?.md) | String in body of request, containing JSON with parameters for translation. | [optional]  |

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
> StatusResponse ResxPost (SrtFileRequest? srtFileRequest = null)

Translate Resx files

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

            var apiInstance = new TranslationApi(config);
            var srtFileRequest = new SrtFileRequest?(); // SrtFileRequest? | String in body of request, containing JSON with parameters for translation. (optional) 

            try
            {
                // Translate Resx files
                StatusResponse result = apiInstance.ResxPost(srtFileRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TranslationApi.ResxPost: " + e.Message);
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
    // Translate Resx files
    ApiResponse<StatusResponse> response = apiInstance.ResxPostWithHttpInfo(srtFileRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TranslationApi.ResxPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **srtFileRequest** | [**SrtFileRequest?**](SrtFileRequest?.md) | String in body of request, containing JSON with parameters for translation. | [optional]  |

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

<a id="spreadsheetpost"></a>
# **SpreadsheetPost**
> StatusResponse SpreadsheetPost (SpreadsheetFileRequest? spreadsheetFileRequest = null)

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
    public class SpreadsheetPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.groupdocs.cloud/v2.0/translation";
            // Configure OAuth2 access token for authorization: JWT
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TranslationApi(config);
            var spreadsheetFileRequest = new SpreadsheetFileRequest?(); // SpreadsheetFileRequest? | String in body of request, containing JSON with parameters for translation. (optional) 

            try
            {
                // Translate Microsoft Excel workbooks, ods
                StatusResponse result = apiInstance.SpreadsheetPost(spreadsheetFileRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TranslationApi.SpreadsheetPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SpreadsheetPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Translate Microsoft Excel workbooks, ods
    ApiResponse<StatusResponse> response = apiInstance.SpreadsheetPostWithHttpInfo(spreadsheetFileRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TranslationApi.SpreadsheetPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **spreadsheetFileRequest** | [**SpreadsheetFileRequest?**](SpreadsheetFileRequest?.md) | String in body of request, containing JSON with parameters for translation. | [optional]  |

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

<a id="srtpost"></a>
# **SrtPost**
> StatusResponse SrtPost (SrtFileRequest? srtFileRequest = null)

Translate Srt files

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Translation.Cloud.Sdk.Api;
using GroupDocs.Translation.Cloud.Sdk.Client;
using GroupDocs.Translation.Cloud.Sdk.Model;

namespace Example
{
    public class SrtPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.groupdocs.cloud/v2.0/translation";
            // Configure OAuth2 access token for authorization: JWT
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TranslationApi(config);
            var srtFileRequest = new SrtFileRequest?(); // SrtFileRequest? | String in body of request, containing JSON with parameters for translation. (optional) 

            try
            {
                // Translate Srt files
                StatusResponse result = apiInstance.SrtPost(srtFileRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TranslationApi.SrtPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SrtPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Translate Srt files
    ApiResponse<StatusResponse> response = apiInstance.SrtPostWithHttpInfo(srtFileRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TranslationApi.SrtPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **srtFileRequest** | [**SrtFileRequest?**](SrtFileRequest?.md) | String in body of request, containing JSON with parameters for translation. | [optional]  |

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
> StatusResponse TextPost (TextRequest? textRequest = null)

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

            var apiInstance = new TranslationApi(config);
            var textRequest = new TextRequest?(); // TextRequest? | String in body of request, containing JSON with parameters for translation. (optional) 

            try
            {
                // Translate text
                StatusResponse result = apiInstance.TextPost(textRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TranslationApi.TextPost: " + e.Message);
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
    Debug.Print("Exception when calling TranslationApi.TextPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **textRequest** | [**TextRequest?**](TextRequest?.md) | String in body of request, containing JSON with parameters for translation. | [optional]  |

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

            var apiInstance = new TranslationApi(config);
            var requestId = "requestId_example";  // string | GUID which got from /v3/translation/text response

            try
            {
                // Return text translation status.  Also return translated text if translation was successful
                CloudTextResponse result = apiInstance.TextRequestIdGet(requestId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TranslationApi.TextRequestIdGet: " + e.Message);
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
    Debug.Print("Exception when calling TranslationApi.TextRequestIdGetWithHttpInfo: " + e.Message);
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
| **202** | Accepted |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="texttrialget"></a>
# **TextTrialGet**
> CloudTextResponse TextTrialGet (string? requestId = null)

Return text translation status for trial requests.  Also return translated text if translation was successful

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Translation.Cloud.Sdk.Api;
using GroupDocs.Translation.Cloud.Sdk.Client;
using GroupDocs.Translation.Cloud.Sdk.Model;

namespace Example
{
    public class TextTrialGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.groupdocs.cloud/v2.0/translation";
            // Configure OAuth2 access token for authorization: JWT
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TranslationApi(config);
            var requestId = "requestId_example";  // string? | GUID which got from /v3/translation/text response (optional) 

            try
            {
                // Return text translation status for trial requests.  Also return translated text if translation was successful
                CloudTextResponse result = apiInstance.TextTrialGet(requestId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TranslationApi.TextTrialGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TextTrialGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Return text translation status for trial requests.  Also return translated text if translation was successful
    ApiResponse<CloudTextResponse> response = apiInstance.TextTrialGetWithHttpInfo(requestId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TranslationApi.TextTrialGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestId** | **string?** | GUID which got from /v3/translation/text response | [optional]  |

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

<a id="texttrialpost"></a>
# **TextTrialPost**
> StatusResponse TextTrialPost (TextRequest? textRequest = null)

Trial translate text. Translate only 1000 symbols.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Translation.Cloud.Sdk.Api;
using GroupDocs.Translation.Cloud.Sdk.Client;
using GroupDocs.Translation.Cloud.Sdk.Model;

namespace Example
{
    public class TextTrialPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.groupdocs.cloud/v2.0/translation";
            // Configure OAuth2 access token for authorization: JWT
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TranslationApi(config);
            var textRequest = new TextRequest?(); // TextRequest? | String in body of request, containing JSON with parameters for translation. (optional) 

            try
            {
                // Trial translate text. Translate only 1000 symbols.
                StatusResponse result = apiInstance.TextTrialPost(textRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TranslationApi.TextTrialPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TextTrialPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Trial translate text. Translate only 1000 symbols.
    ApiResponse<StatusResponse> response = apiInstance.TextTrialPostWithHttpInfo(textRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TranslationApi.TextTrialPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **textRequest** | [**TextRequest?**](TextRequest?.md) | String in body of request, containing JSON with parameters for translation. | [optional]  |

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

<a id="xmlpost"></a>
# **XmlPost**
> StatusResponse XmlPost (XmlFileRequest? xmlFileRequest = null)

Translate XML files

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Translation.Cloud.Sdk.Api;
using GroupDocs.Translation.Cloud.Sdk.Client;
using GroupDocs.Translation.Cloud.Sdk.Model;

namespace Example
{
    public class XmlPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.groupdocs.cloud/v2.0/translation";
            // Configure OAuth2 access token for authorization: JWT
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TranslationApi(config);
            var xmlFileRequest = new XmlFileRequest?(); // XmlFileRequest? | String in body of request, containing JSON with parameters for translation. (optional) 

            try
            {
                // Translate XML files
                StatusResponse result = apiInstance.XmlPost(xmlFileRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TranslationApi.XmlPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the XmlPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Translate XML files
    ApiResponse<StatusResponse> response = apiInstance.XmlPostWithHttpInfo(xmlFileRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TranslationApi.XmlPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xmlFileRequest** | [**XmlFileRequest?**](XmlFileRequest?.md) | String in body of request, containing JSON with parameters for translation. | [optional]  |

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

