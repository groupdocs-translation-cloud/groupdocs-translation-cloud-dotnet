using System;
using GroupDocs.Translation.Cloud.SDK.NET;
using GroupDocs.Translation.Cloud.SDK.NET.Model;
using GroupDocs.Translation.Cloud.SDK.NET.Model.Requests;

namespace GroupDocs.Translation.Cloud.SDK.Net.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // add your AppKey and AppSid
            Configuration conf = new Configuration();
            conf.AppSid = "";
            conf.AppKey = "";

            

            if (string.IsNullOrEmpty(conf.AppSid) || string.IsNullOrEmpty(conf.AppKey))
                throw new Exception("Please, get and set your API keys. https://dashboard.groupdocs.cloud/#/");

            TranslationResponse response = new TranslationResponse();
            TranslationResponse hcResponse = new TranslationResponse();
            TextResponse textResponse = new TextResponse();
            NET.Model.FileInfo fileInfo = new NET.Model.FileInfo();
            TextInfo textInfo = new TextInfo();

            Console.WriteLine("Example #1:\nDocument translation of file in GroupDocs Storage");
            response = TranslateDocument(conf);
            Console.WriteLine(response.ToString());

            Console.WriteLine("Example #2:\nText translation");
            textResponse = TranslateText(conf);
            Console.WriteLine(textResponse);

            Console.WriteLine("Example #3:\nGet structure of document request");
            fileInfo = GetDocRequest(conf);
            Console.WriteLine(fileInfo.ToString());

            Console.WriteLine("Example #4:\nGet structure of text request");
            textInfo = GetTextRequest(conf);
            Console.WriteLine(textInfo.ToString());

            Console.WriteLine("Example #5:\nHealth check");
            hcResponse = HealthCheck(conf);
            Console.WriteLine(hcResponse);

        }

        static TranslationResponse TranslateDocument(Configuration conf)
        {
            // add necessary file info for translation here
            string name = "";
            string folder = "";
            string pair = "";
            string format = "";
            string storage = "";
            string saveFile = "";
            string savePath = "";

            TranslationApi api = new TranslationApi(conf);
            TranslateDocumentRequest request = api.CreateDocumentRequest(name, folder, pair, format, storage, saveFile, savePath);
            TranslationResponse response = api.RunTranslationTask(request);
            return response;
        }

        static TextResponse TranslateText(Configuration conf)
        {
            // add text for translation and language pair
            string pair = "";
            string text = "";

            TranslationApi api = new TranslationApi(conf);
            TranslateTextRequest request = api.CreateTextRequest(pair, text);
            TextResponse response = api.RunTranslationTextTask(request);
            return response;
        }

        static NET.Model.FileInfo GetDocRequest(Configuration conf)
        {
            TranslationApi api = new TranslationApi(conf);
            NET.Model.FileInfo info = api.GetDocumentRequestStructure();
            return info;
        }

        static TextInfo GetTextRequest(Configuration conf)
        {
            TranslationApi api = new TranslationApi(conf);
            TextInfo info = api.GetTextRequestStructure();
            return info;
        }

        static TranslationResponse HealthCheck(Configuration conf)
        {
            TranslationApi api = new TranslationApi(conf);
            TranslationResponse response = api.RunHealthCheck();
            return response;
        }
    }
}
