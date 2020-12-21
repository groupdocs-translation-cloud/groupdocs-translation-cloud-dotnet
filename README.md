# GroupDocs.Translation Cloud

[GroupDocs.Translation Cloud](https://products.groupdocs.cloud/translation) is Cloud API to translate Word, Excel and PowerPoint files as well as plain text. 

For convenience of our .NET customers we introduce a simple SDK used to add translation of Microsoft Word documents, Microsoft Excel workbooks, Microsoft PowerPoint presentations and plain text to your app with merely a few lines of code.

In detail, it's a set of SDKs for document and plain text translation in our Cloud. It supports translaton of .doc, .docx, .docm, .xls, .xlsx, .xlsm, .ppt, .pptx, .pptm files. Just pass a specific file or text to the GroupDocs.Translation Cloud API, and it will translate and save translated file in our Cloud or will return translated text.

It is easy to get started with GroupDocs.Translation Cloud, and there is nothing to install. Create an account at [GroupDocs Cloud](https://dashboard.groupdocs.cloud/#/) and get your application information, then you are ready to use [SDKs](https://github.com/groupdocs-translation-cloud)

## Release 20.12
- Conversion of translated files to other formats is added

## Release 20.10
- Microsoft PowerPoint presentations translation
- French-Italian language pair support

## Release 20.9
- French-German language pair support

## Release 20.8
- GroupDocs.Translation Cloud SDK for [Java](https://github.com/groupdocs-translation-cloud/groupdocs-translation-cloud-java) and [Python](https://github.com/groupdocs-translation-cloud/groupdocs-translation-cloud-python) have been released

## Release 20.7
- English-Polish language pair support
- Translation API functionality extended, allowing easier creation of translation requests

## Release 20.6:
- Translation of plain text
- English-Arabic and English-Portuguese language pairs support 

## Features:
- Translation of Microsoft Word, Microsoft Excel and Microsoft PowerPoint documents
- [10 languages and 22 languages pairs support](https://docs.groupdocs.cloud/translation/supported-languages/)
- Translation of tables, headers, footers, footnotes / endnotes, image captions in Word documents
- Translation of cells, charts, tables, pivot tables in Excel documents
- Translation of text frames, tables, headers, footers, charts, comments in PowerPoint presentations
- Translation of plain text
- Conversion of translated files to other formats like pdf, tiff, xps, etc.
- API that allows you manage your files and folders in our Cloud

## How to use the SDK?

Our API is completely independent of your operating system, database system, or development language. You can use any language and platform that supports HTTP to interact with our API. However, manually writing client code can be difficult, error-prone, and time-consuming. Therefore, we have provided and support [SDKs](https://github.com/groupdocs-translation-cloud) in many development languages to make it easier to integrate with us.

## Example

```csharp
public TranslationResponse TranslateDocument(Configuration conf)
{    
    string name = "test.docx";
    string folder = "";
    string pair = "en-fr";
    string format = "docx";
    strting outFormat = "docx";
    string storage = "First Storage";
    string saveFile = "translation.docx";
    string savePath = "";
    bool masters = fasle;
    List<int> elements = new List<int>();
    
    TranslationApi api = new TranslationApi(conf);
    TranslateDocumentRequest request = api.CreateDocumentRequest(name, folder, pair, format, outFormat, storage, saveFile, savePath, masters, elements);
    TranslationResponse response = api.RunTranslationTask(request);
    return response;
}

public TextResponse TranslateText(Configuration conf)
{    
    string pair = "en-fr";
    string text = "Welcome to Paris";    
    
    TranslationApi api = new TranslationApi(conf);
    TranslateTextRequest request = api.CreateTextRequest(pair, text);
    TextResponse response = api.RunTranslationTextTask(request);
    return response;
}
```
_________________________

## Quickstart

Make your solution using [SDK](https://github.com/groupdocs-translation-cloud), follow these steps:

#### 1. Get API keys if you haven't

Make a personal account on [GroupDocs Cloud Dashboard](https://dashboard.groupdocs.cloud/#/) and click _Get Keys_. These keys are useful for all GroupDocs Cloud products. If you have any trouble, look at this [detailed manual](https://docs.groupdocs.cloud/total/creating-and-managing-application/).

#### 2. Run Demo
  * Checkout the SDK
  * Open .NET core demo project
  * Set Your ClientId & ClientSecret
  * Run

_________________________

## GroupDocs.Translation Cloud SDKs

||||||||
|--------------|----------|-------|-------|-------|---------|---------|
|[.NET](https://github.com/groupdocs-translation-cloud/groupdocs-translation-cloud-dotnet)|[Java](https://github.com/groupdocs-translation-cloud/groupdocs-translation-cloud-java)|PHP|Ruby|[Python](https://github.com/groupdocs-translation-cloud/groupdocs-translation-cloud-python)|Node.js|Android||

[Home](https://www.groupdocs.cloud/) | [Product Page](https://products.groupdocs.cloud/translation/net) | [Docs](https://docs.groupdocs.cloud/translation/) | [Demos](https://products.groupdocs.app/viewer/family) | [API Reference](https://apireference.groupdocs.cloud/translation/) | [Examples](https://github.com/groupdocs-translation-cloud/groupdocs-translation-cloud-dotnet) | [Blog](https://blog.groupdocs.cloud/category/translation/) | [Free Support](https://forum.groupdocs.cloud/c/translation) | [Free Trial](https://purchase.groupdocs.cloud/trial)
