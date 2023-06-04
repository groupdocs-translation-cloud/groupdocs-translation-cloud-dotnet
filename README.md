# GroupDocs.Translation.Api (.NET)

No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 1.0
- SDK version: 1.0.0
- Build package: org.openapitools.codegen.languages.CSharpNetCoreClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext

<a name="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.13.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 13.0.2 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 5.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742).
NOTE: RestSharp for .Net Core creates a new socket for each api call, which can lead to a socket exhaustion problem. See [RestSharp#1406](https://github.com/restsharp/RestSharp/issues/1406).

<a name="installation"></a>
## Installation
Generate the DLL using your preferred tool (e.g. `dotnet build`)

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using GroupDocs.Translation.Api.Api;
using GroupDocs.Translation.Api.Client;
using GroupDocs.Translation.Api.Model;
```
<a name="usage"></a>
## Usage

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

<a name="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using GroupDocs.Translation.Api.Api;
using GroupDocs.Translation.Api.Client;
using GroupDocs.Translation.Api.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration config = new Configuration();
            config.BasePath = "https://api.groupdocs.cloud/v2.0/translation";
            // Configure OAuth2 ClientId and ClientSecret: JWT
            config.OAuthClientId = "YOU_CLIENT_ID";
            config.OAuthClientSecret = "YOU_CLIENT_SECRET";

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
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TransportApi.AllFormatsPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.groupdocs.cloud/v2.0/translation*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*TransportApi* | [**AllFormatsPost**](docs\TransportApi.md#allformatspost) | **POST** /all-formats | Translate any supported file
*TransportApi* | [**AvailableLanguagesGet**](docs\TransportApi.md#availablelanguagesget) | **GET** /available-languages | Return list of available language pairs
*TransportApi* | [**CsvPost**](docs\TransportApi.md#csvpost) | **POST** /csv | Translate CSV and TSV files
*TransportApi* | [**DocumentPost**](docs\TransportApi.md#documentpost) | **POST** /document | Translate Microsoft Word documents, rtf, txt, odt
*TransportApi* | [**DocumentRequestIdGet**](docs\TransportApi.md#documentrequestidget) | **GET** /document/{requestId} | Return document translation status.  Also return URLs for downloading of translated document if translation was successful
*TransportApi* | [**HcGet**](docs\TransportApi.md#hcget) | **GET** /hc | Health check for all services.
*TransportApi* | [**HtmlPost**](docs\TransportApi.md#htmlpost) | **POST** /html | Translate HTML files
*TransportApi* | [**HugoPost**](docs\TransportApi.md#hugopost) | **POST** /hugo | Get hugo syntax structure from markdown file
*TransportApi* | [**MarkdownPost**](docs\TransportApi.md#markdownpost) | **POST** /markdown | Translate Markdown files
*TransportApi* | [**OcrFilePost**](docs\TransportApi.md#ocrfilepost) | **POST** /ocr-file | Translate image or scanned pdf and return file
*TransportApi* | [**OcrTextPost**](docs\TransportApi.md#ocrtextpost) | **POST** /ocr-text | Translate text on image or scanned pdf
*TransportApi* | [**PdfPost**](docs\TransportApi.md#pdfpost) | **POST** /pdf | Translate pdf files
*TransportApi* | [**PresentationPost**](docs\TransportApi.md#presentationpost) | **POST** /presentation | Translate Microsoft PowerPoint presentations, odp
*TransportApi* | [**ResourcesPost**](docs\TransportApi.md#resourcespost) | **POST** /resources | Translate RESX files
*TransportApi* | [**SpreadsheetsPost**](docs\TransportApi.md#spreadsheetspost) | **POST** /spreadsheets | Translate Microsoft Excel workbooks, ods
*TransportApi* | [**TextPost**](docs\TransportApi.md#textpost) | **POST** /text | Translate text
*TransportApi* | [**TextRequestIdGet**](docs\TransportApi.md#textrequestidget) | **GET** /text/{requestId} | Return text translation status.  Also return translated text if translation was successful


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.CloudFileResponse](docs\CloudFileResponse.md)
 - [Model.CloudHugoResponse](docs\CloudHugoResponse.md)
 - [Model.CloudTextResponse](docs\CloudTextResponse.md)
 - [Model.HealthCheckStatus](docs\HealthCheckStatus.md)
 - [Model.StatusResponse](docs\StatusResponse.md)
 - [Model.UrlFileInfo](docs\UrlFileInfo.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="JWT"></a>
### JWT

- **Type**: OAuth
- **Flow**: application
- **Authorization URL**: 
- **Scopes**: N/A

