# GroupDocs.Translation.Cloud.Sdk.Api.SwaggerApi

All URIs are relative to *https://api.groupdocs.cloud/v2.0/translation*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SwaggerSpecGet**](SwaggerApi.md#swaggerspecget) | **GET** /swagger/spec |  |

<a id="swaggerspecget"></a>
# **SwaggerSpecGet**
> void SwaggerSpecGet (bool? isYaml = null, bool? serialaizeAsV2 = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Translation.Cloud.Sdk.Api;
using GroupDocs.Translation.Cloud.Sdk.Client;
using GroupDocs.Translation.Cloud.Sdk.Model;

namespace Example
{
    public class SwaggerSpecGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.groupdocs.cloud/v2.0/translation";
            // Configure OAuth2 access token for authorization: JWT
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SwaggerApi(config);
            var isYaml = false;  // bool? |  (optional)  (default to false)
            var serialaizeAsV2 = false;  // bool? |  (optional)  (default to false)

            try
            {
                apiInstance.SwaggerSpecGet(isYaml, serialaizeAsV2);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SwaggerApi.SwaggerSpecGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SwaggerSpecGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.SwaggerSpecGetWithHttpInfo(isYaml, serialaizeAsV2);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SwaggerApi.SwaggerSpecGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **isYaml** | **bool?** |  | [optional] [default to false] |
| **serialaizeAsV2** | **bool?** |  | [optional] [default to false] |

### Return type

void (empty response body)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

