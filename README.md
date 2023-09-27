# GroupDocs.Translation.Cloud.Sdk (.NET)

No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 23.9.4
- SDK version: 1.0.0
- Build package: org.openapitools.codegen.languages.CSharpNetCoreClientCodegen
    For more information, please visit [https://products.groupdocs.cloud/translation/](https://products.groupdocs.cloud/translation/)

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
using GroupDocs.Translation.Cloud.Sdk.Api;
using GroupDocs.Translation.Cloud.Sdk.Client;
using GroupDocs.Translation.Cloud.Sdk.Model;
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
using GroupDocs.Translation.Cloud.Sdk.Api;
using GroupDocs.Translation.Cloud.Sdk.Client;
using GroupDocs.Translation.Cloud.Sdk.Model;

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
            config.OAuthFlow = OAuthFlow.APPLICATION;

            var apiInstance = new TranslationApi(config);
            var fileRequest = new FileRequest(); // FileRequest | String in body of request, containing JSON with parameters for translation. (optional) 

            try
            {
                // Translate any supported file
                StatusResponse result = apiInstance.AutoPost(fileRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TranslationApi.AutoPost: " + e.Message );
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
*TranslationApi* | [**AutoPost**](docs\TranslationApi.md#autopost) | **POST** /auto | Translate any supported file
*TranslationApi* | [**CsvPost**](docs\TranslationApi.md#csvpost) | **POST** /csv | Translate CSV and TSV files
*TranslationApi* | [**DocumentPost**](docs\TranslationApi.md#documentpost) | **POST** /document | Translate Microsoft Word documents, rtf, txt, odt
*TranslationApi* | [**DocumentRequestIdGet**](docs\TranslationApi.md#documentrequestidget) | **GET** /document/{requestId} | Return document translation status.  Also return URLs for downloading of translated document if translation was successful
*TranslationApi* | [**DocumentTrialPost**](docs\TranslationApi.md#documenttrialpost) | **POST** /document/trial | Trial translate Microsoft Word documents, rtf, txt, odt without conversation. Translate only first page or 1000 symbols.
*TranslationApi* | [**HcGet**](docs\TranslationApi.md#hcget) | **GET** /hc | Health check for all services.
*TranslationApi* | [**HtmlPost**](docs\TranslationApi.md#htmlpost) | **POST** /html | Translate HTML files
*TranslationApi* | [**HugoGet**](docs\TranslationApi.md#hugoget) | **GET** /hugo | Get hugo syntax structure from markdown file
*TranslationApi* | [**HugoPost**](docs\TranslationApi.md#hugopost) | **POST** /hugo | Run hugo syntax structure analyzing from markdown file
*TranslationApi* | [**ImageToFilePost**](docs\TranslationApi.md#imagetofilepost) | **POST** /image-to-file | Translate image or scanned pdf and return file
*TranslationApi* | [**ImageToTextPost**](docs\TranslationApi.md#imagetotextpost) | **POST** /image-to-text | Translate text on image or scanned pdf
*TranslationApi* | [**LanguagesGet**](docs\TranslationApi.md#languagesget) | **GET** /languages | Return list of available language pairs
*TranslationApi* | [**MarkdownPost**](docs\TranslationApi.md#markdownpost) | **POST** /markdown | Translate Markdown files
*TranslationApi* | [**PdfPost**](docs\TranslationApi.md#pdfpost) | **POST** /pdf | Translate pdf files
*TranslationApi* | [**PdfTrialPost**](docs\TranslationApi.md#pdftrialpost) | **POST** /pdf/trial | Trial pdf translation. Translate only first page without conversion to another format.
*TranslationApi* | [**PresentationPost**](docs\TranslationApi.md#presentationpost) | **POST** /presentation | Translate Microsoft PowerPoint presentations, odp
*TranslationApi* | [**ResxPost**](docs\TranslationApi.md#resxpost) | **POST** /resx | Translate RESX files
*TranslationApi* | [**SpreadsheetPost**](docs\TranslationApi.md#spreadsheetpost) | **POST** /spreadsheet | Translate Microsoft Excel workbooks, ods
*TranslationApi* | [**TextPost**](docs\TranslationApi.md#textpost) | **POST** /text | Translate text
*TranslationApi* | [**TextRequestIdGet**](docs\TranslationApi.md#textrequestidget) | **GET** /text/{requestId} | Return text translation status.  Also return translated text if translation was successful
*TranslationApi* | [**TextTrialPost**](docs\TranslationApi.md#texttrialpost) | **POST** /text/trial | Trial translate text. Translate only 1000 symbols.


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.CloudFileResponse](docs\CloudFileResponse.md)
 - [Model.CloudHugoResponse](docs\CloudHugoResponse.md)
 - [Model.CloudTextResponse](docs\CloudTextResponse.md)
 - [Model.CsvFileRequest](docs\CsvFileRequest.md)
 - [Model.FileRequest](docs\FileRequest.md)
 - [Model.HealthCheckStatus](docs\HealthCheckStatus.md)
 - [Model.HtmlFileRequest](docs\HtmlFileRequest.md)
 - [Model.HttpStatusCode](docs\HttpStatusCode.md)
 - [Model.HugoRequest](docs\HugoRequest.md)
 - [Model.ImageToFileRequest](docs\ImageToFileRequest.md)
 - [Model.ImageToTextRequest](docs\ImageToTextRequest.md)
 - [Model.LanguagePairData](docs\LanguagePairData.md)
 - [Model.MarkdownFileRequest](docs\MarkdownFileRequest.md)
 - [Model.PdfFileRequest](docs\PdfFileRequest.md)
 - [Model.PresentationFileRequest](docs\PresentationFileRequest.md)
 - [Model.ResxFileRequest](docs\ResxFileRequest.md)
 - [Model.SpreadsheetFileRequest](docs\SpreadsheetFileRequest.md)
 - [Model.StatusResponse](docs\StatusResponse.md)
 - [Model.StringStringTuple](docs\StringStringTuple.md)
 - [Model.TextDocumentFileRequest](docs\TextDocumentFileRequest.md)
 - [Model.TextRequest](docs\TextRequest.md)
 - [Model.UrlFileInfo](docs\UrlFileInfo.md)
 - [Model.WorksheetData](docs\WorksheetData.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="JWT"></a>
### JWT

- **Type**: OAuth
- **Flow**: application
- **Authorization URL**: https://id.groupdocs.cloud/
- **Scopes**: N/A

