# GroupDocs.Translation.Cloud.Sdk.Api.TransportApi

All URIs are relative to *https://api.groupdocs.cloud/v2.0/translation*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AutoPost**](TransportApi.md#autopost) | **POST** /auto |  |
| [**CsvPost**](TransportApi.md#csvpost) | **POST** /csv |  |
| [**DocumentPost**](TransportApi.md#documentpost) | **POST** /document |  |
| [**DocumentRequestIdGet**](TransportApi.md#documentrequestidget) | **GET** /document/{requestId} |  |
| [**HcGet**](TransportApi.md#hcget) | **GET** /hc |  |
| [**HtmlPost**](TransportApi.md#htmlpost) | **POST** /html |  |
| [**HugoGet**](TransportApi.md#hugoget) | **GET** /hugo |  |
| [**HugoPost**](TransportApi.md#hugopost) | **POST** /hugo |  |
| [**ImageToFilePost**](TransportApi.md#imagetofilepost) | **POST** /image-to-file |  |
| [**ImageToTextPost**](TransportApi.md#imagetotextpost) | **POST** /image-to-text |  |
| [**LanguagesGet**](TransportApi.md#languagesget) | **GET** /languages |  |
| [**MarkdownPost**](TransportApi.md#markdownpost) | **POST** /markdown |  |
| [**PdfPost**](TransportApi.md#pdfpost) | **POST** /pdf |  |
| [**PresentationPost**](TransportApi.md#presentationpost) | **POST** /presentation |  |
| [**ResxPost**](TransportApi.md#resxpost) | **POST** /resx |  |
| [**SpreadsheetsPost**](TransportApi.md#spreadsheetspost) | **POST** /spreadsheets |  |
| [**TextPost**](TransportApi.md#textpost) | **POST** /text |  |
| [**TextRequestIdGet**](TransportApi.md#textrequestidget) | **GET** /text/{requestId} |  |

<a id="autopost"></a>
# **AutoPost**
> StatusResponse AutoPost (AutoPostRequest autoPostRequest = null)



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
            var csvFileRequest = new CsvFileRequest(); // CsvFileRequest |  (optional) 

            try
            {
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
| **csvFileRequest** | [**CsvFileRequest**](CsvFileRequest.md) |  | [optional]  |

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
            var textDocumentFileRequest = new TextDocumentFileRequest(); // TextDocumentFileRequest |  (optional) 

            try
            {
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
| **textDocumentFileRequest** | [**TextDocumentFileRequest**](TextDocumentFileRequest.md) |  | [optional]  |

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
            var requestId = "requestId_example";  // string | 

            try
            {
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
| **requestId** | **string** |  |  |

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
> StatusResponse HtmlPost (HtmlFileRequest htmlFileRequest = null)



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
            var htmlFileRequest = new HtmlFileRequest(); // HtmlFileRequest |  (optional) 

            try
            {
                StatusResponse result = apiInstance.HtmlPost(htmlFileRequest);
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
    ApiResponse<StatusResponse> response = apiInstance.HtmlPostWithHttpInfo(htmlFileRequest);
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
| **htmlFileRequest** | [**HtmlFileRequest**](HtmlFileRequest.md) |  | [optional]  |

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
> CloudHugoResponse HugoGet (string id = null)



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
            var id = "id_example";  // string |  (optional) 

            try
            {
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
| **id** | **string** |  | [optional]  |

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
> StatusResponse HugoPost (HugoRequest hugoRequest = null)



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
            var hugoRequest = new HugoRequest(); // HugoRequest |  (optional) 

            try
            {
                StatusResponse result = apiInstance.HugoPost(hugoRequest);
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
    ApiResponse<StatusResponse> response = apiInstance.HugoPostWithHttpInfo(hugoRequest);
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
| **hugoRequest** | [**HugoRequest**](HugoRequest.md) |  | [optional]  |

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
> StatusResponse ImageToFilePost (OcrFileRequest ocrFileRequest = null)



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
            var ocrFileRequest = new OcrFileRequest(); // OcrFileRequest |  (optional) 

            try
            {
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
| **ocrFileRequest** | [**OcrFileRequest**](OcrFileRequest.md) |  | [optional]  |

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
> StatusResponse ImageToTextPost (OcrTextRequest ocrTextRequest = null)



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
            var ocrTextRequest = new OcrTextRequest(); // OcrTextRequest |  (optional) 

            try
            {
                StatusResponse result = apiInstance.ImageToTextPost(ocrTextRequest);
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
    ApiResponse<StatusResponse> response = apiInstance.ImageToTextPostWithHttpInfo(ocrTextRequest);
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
| **ocrTextRequest** | [**OcrTextRequest**](OcrTextRequest.md) |  | [optional]  |

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
> StatusResponse MarkdownPost (MarkdownFileRequest markdownFileRequest = null)



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
            var markdownFileRequest = new MarkdownFileRequest(); // MarkdownFileRequest |  (optional) 

            try
            {
                StatusResponse result = apiInstance.MarkdownPost(markdownFileRequest);
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
    ApiResponse<StatusResponse> response = apiInstance.MarkdownPostWithHttpInfo(markdownFileRequest);
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
| **markdownFileRequest** | [**MarkdownFileRequest**](MarkdownFileRequest.md) |  | [optional]  |

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
> StatusResponse PdfPost (PdfFileRequest pdfFileRequest = null)



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
            var pdfFileRequest = new PdfFileRequest(); // PdfFileRequest |  (optional) 

            try
            {
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
| **pdfFileRequest** | [**PdfFileRequest**](PdfFileRequest.md) |  | [optional]  |

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
            var presentationFileRequest = new PresentationFileRequest(); // PresentationFileRequest |  (optional) 

            try
            {
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
| **presentationFileRequest** | [**PresentationFileRequest**](PresentationFileRequest.md) |  | [optional]  |

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
            var resxFileRequest = new ResxFileRequest(); // ResxFileRequest |  (optional) 

            try
            {
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
| **resxFileRequest** | [**ResxFileRequest**](ResxFileRequest.md) |  | [optional]  |

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
            var spreadsheetFileRequest = new SpreadsheetFileRequest(); // SpreadsheetFileRequest |  (optional) 

            try
            {
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
| **spreadsheetFileRequest** | [**SpreadsheetFileRequest**](SpreadsheetFileRequest.md) |  | [optional]  |

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
            var textRequest = new TextRequest(); // TextRequest |  (optional) 

            try
            {
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
| **textRequest** | [**TextRequest**](TextRequest.md) |  | [optional]  |

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
            var requestId = "requestId_example";  // string | 

            try
            {
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
| **requestId** | **string** |  |  |

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

