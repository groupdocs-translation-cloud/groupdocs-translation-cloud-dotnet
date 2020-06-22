# GroupDocs.Translation Cloud

[GroupDocs.Translation Cloud](https://products.groupdocs.cloud/translation) is a simple SDK used to add translation of Microsoft Word documents, Microsoft Excel workbooks and plain text to your app with merely a few lines of code.

In detail, it's a set of SDKs for document and plain text translation in our Cloud. It supports translaton of .doc, .docx, .docm, .xls, .xlsx, .xlsm files. Just pass a specific file or text to the GroupDocs.Translation Cloud API, and it will translate and save translated file in our Cloud or will return translated text.

It is easy to get started with GroupDocs.Translation Cloud, and there is nothing to install. Create an account at [GroupDocs Cloud](https://dashboard.aspose.cloud/#/) and get your application information, then you are ready to use [SDKs](#groupdocstranslation-cloud-sdks)

## Release 20.06:
- Translation of plain text
- English-Arabic and English-Portugal language pairs support 


## Features:
- Translation of Microsoft Word and Microsoft Excel documents
- 9 languages and 16 languages pairs support
- Translation of tables, headers, footers, footnotes / endnotes, image captions in Word documents
- Translation of cells, charts, tables, pivot tables in Excel documents
- Translation of plain text
- API that allows you manage your files and folders in our Cloud

## How to use the SDK?

Our API is completely independent of your operating system, database system, or development language. You can use any language and platform that supports HTTP to interact with our API. However, manually writing client code can be difficult, error-prone, and time-consuming. Therefore, we have provided and support [SDKs](#groupdocstranslation-cloud-sdks) in many development languages to make it easier to integrate with us.

## Example

```csharp
public TranslationResponse TranslateDocument(Configuration conf)
{
    // file to upload
    string fileName = "";

    // body of request to translate document
    string userRequest = @"[{""name"": """", ""folder"": """", ""storage"": """", ""format"": """", ""savepath"": """", ""savefile"": """", ""pair"": """"}]";

    TranslationApi api = new TranslationApi(conf);
    FileApi fileApi = new FileApi(conf);
    fileApi.UploadFile(new UploadFileRequest(fileName, File.OpenRead(fileName)));
    TranslateDocumentRequest request = new TranslateDocumentRequest(userRequest);
    TranslationResponse response = api.RunTranslationTask(request);
    return response;
}

public TextResponse TranslateText(Configuration conf)
{
    string userRequest = @"[{""pair"": ""en-fr"", ""src"": ""hello world""}]";
    TranslationApi api = new TranslationApi(conf);
    TranslateTextRequest request = new TranslateTextRequest(userRequest);
    TextResponse response = api.RunTranslationTextTask(request);
    return response;
        }
```
_________________________

## Quickstart

Make your solution using [SDK](groupdocstranslation-cloud-sdks), follow these steps:

#### 1. Get API keys if you haven't

Make a personal account on [GroupDocs Cloud Dashboard](https://dashboard.groupdocs.cloud/#/) and click _Get Keys_. These keys are useful for all GroupDocs Cloud products. If you have any trouble, look at this [detailed manual](https://wiki.groupdocs.cloud/translationcloud/getting-started/create-new-app-and-get-app-key-and-sid/).

#### 2. Run Demo
  * Checkout the SDK
  * Open .NET core demo project
  * Set Your AppSid & AppKey
  * Run

_________________________

## GroupDocs.Translation Cloud SDKs

||||||||||
|--------------|----------|-------|-------|-------|---------|---------|----------|-------|
|.NET|Java|PHP|Ruby|Python|Node.js|Android|Objective-C|Perl|

## Resources

- **Website:** [https://www.groupdocs.cloud](https://www.groupdocs.cloud)
- **Product Home:** [GroupDocs.Translation Cloud](https://products.groupdocs.cloud/translation)
- **Documentation:** [GroupDocs.Translation Cloud Documentation](https://wiki.groupdocs.cloud/translationcloud/)
- **Forum:** [GroupDocs.Translation Cloud Forum](https://forum.groupdocs.cloud/c/translation)
- **Blog:** [GroupDocs.Translation Cloud Blog](https://blog.groupdocs.cloud/category/translation/)
- **Pricing:** [GroupDocs Cloud Pricing](https://purchase.groupdocs.cloud/pricing)
