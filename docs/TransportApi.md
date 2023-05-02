# GroupDocs.Translation.Api.Api.TransportApi

All URIs are relative to *https://api.groupdocs.cloud/v2.0/translation*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DocumentPost**](TransportApi.md#documentpost) | **POST** /document | Translate document |
| [**DocumentRequestIdGet**](TransportApi.md#documentrequestidget) | **GET** /document/{requestId} | Return document translation status.  Also return URLs for downloading of translated document if translation was successful |
| [**ListOfAvailableLanguagesGet**](TransportApi.md#listofavailablelanguagesget) | **GET** /listOfAvailableLanguages | Return list of available language pairs |
| [**TextPost**](TransportApi.md#textpost) | **POST** /text | Translate text |
| [**TextRequestIdGet**](TransportApi.md#textrequestidget) | **GET** /text/{requestId} | Return text translation status.  Also return translated text if translation was successful |

<a name="documentpost"></a>
# **DocumentPost**
> StatusResponse DocumentPost (string outFormat, string source, List<string> targets, System.IO.Stream file, string format = null, string url = null, bool? masters = null, string origin = null, List<int> elements = null, string savingMode = null)

Translate document

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
            var outFormat = "outFormat_example";  // string | output file format
            var source = "\"en\"";  // string | Language of original file (default to "en")
            var targets = new List<string>(); // List<string> | List of target languages
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | File as byte array
            var format = "Unknown";  // string | Input file format (optional)  (default to Unknown)
            var url = "url_example";  // string | Link to file for translation (optional) 
            var masters = false;  // bool? | If translate master slides (optional)  (default to false)
            var origin = "origin_example";  // string | for analysis only (optional) 
            var elements = new List<int>(); // List<int> | List of slides to translate (optional) 
            var savingMode = "Files";  // string | Toggle file saving mode for storage.  Is Files by default. (optional) 

            try
            {
                // Translate document
                StatusResponse result = apiInstance.DocumentPost(outFormat, source, targets, file, format, url, masters, origin, elements, savingMode);
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
    // Translate document
    ApiResponse<StatusResponse> response = apiInstance.DocumentPostWithHttpInfo(outFormat, source, targets, file, format, url, masters, origin, elements, savingMode);
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
| **outFormat** | **string** | output file format |  |
| **source** | **string** | Language of original file | [default to &quot;en&quot;] |
| **targets** | [**List&lt;string&gt;**](string.md) | List of target languages |  |
| **file** | **System.IO.Stream****System.IO.Stream** | File as byte array |  |
| **format** | **string** | Input file format | [optional] [default to Unknown] |
| **url** | **string** | Link to file for translation | [optional]  |
| **masters** | **bool?** | If translate master slides | [optional] [default to false] |
| **origin** | **string** | for analysis only | [optional]  |
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
| **207** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listofavailablelanguagesget"></a>
# **ListOfAvailableLanguagesGet**
> List&lt;LanguagePairData&gt; ListOfAvailableLanguagesGet ()

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
    public class ListOfAvailableLanguagesGetExample
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
                List<LanguagePairData> result = apiInstance.ListOfAvailableLanguagesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransportApi.ListOfAvailableLanguagesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListOfAvailableLanguagesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Return list of available language pairs
    ApiResponse<List<LanguagePairData>> response = apiInstance.ListOfAvailableLanguagesGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransportApi.ListOfAvailableLanguagesGetWithHttpInfo: " + e.Message);
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

