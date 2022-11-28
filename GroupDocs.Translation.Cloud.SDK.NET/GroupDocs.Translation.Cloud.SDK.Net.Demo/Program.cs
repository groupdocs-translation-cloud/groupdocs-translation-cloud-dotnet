using System;
using System.Collections.Generic;
using System.IO;
using GroupDocs.Translation.Cloud.SDK.NET;
using GroupDocs.Translation.Cloud.SDK.NET.Model;
using GroupDocs.Translation.Cloud.SDK.NET.Model.Requests;
using Aspose.Words;
using System.Web;
using Newtonsoft.Json;
namespace GroupDocs.Translation.Cloud.SDK.Net.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // add your ClientId and ClientSecret
            Configuration conf = new Configuration();
            conf.ClientId = "";
            conf.ClientSecret = "";

            if (string.IsNullOrEmpty(conf.ClientId) || string.IsNullOrEmpty(conf.ClientSecret))
                throw new Exception("Please, get and set your ClientId and ClientSecret. https://dashboard.groupdocs.cloud/#/");


            TranslationResponse hcResponse = new TranslationResponse();
            TextResponse textResponse = new TextResponse();
            NET.Model.FileInfo fileInfo = new NET.Model.FileInfo();
            TextInfo textInfo = new TextInfo();
            Dictionary<string, string[]> pairs = new Dictionary<string, string[]>();

            Console.WriteLine("Example #1:\nDocument translation of file in GroupDocs Storage");
            TranslateDocument(conf);


            Console.WriteLine("Example #2:\nText translation");
            textResponse = TranslateText(conf);
            Console.WriteLine(textResponse);

            Console.WriteLine("Example #3:\nHealth check");
            hcResponse = HealthCheck(conf);
            Console.WriteLine(hcResponse);

            Console.WriteLine("Example #4:\nGet structure of document request");
            fileInfo = GetDocRequest(conf);
            Console.WriteLine(fileInfo.ToString());

            Console.WriteLine("Example #5:\nGet structure of text request");
            textInfo = GetTextRequest(conf);
            Console.WriteLine(textInfo.ToString());

            Console.WriteLine("Example #6:\nGet language pairs");
            pairs = GetLanguagePairs(conf);
            foreach (var key in pairs.Keys)
            {
                Console.WriteLine(key + ": ");
                foreach (var value in pairs[key])
                {
                    Console.WriteLine("- " + value);
                }
            }
            Console.WriteLine("Example #7:\n Check number of characters");
            CheckCharacters(conf);
        }

        static void CheckCharacters(Configuration conf)
        {
            string name = "test.docx";
            string folder = "";
            string format = "docx";
            string storage = "First Storage";
            List<int> elements = new List<int>();
            //elements.Add(0);

            string uploadPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName + "/" + name;
            Stream stream = File.Open(uploadPath, FileMode.Open);
            //Document document = new Document(stream);
            //Console.WriteLine("Number of chars: " + document.BuiltInDocumentProperties.Characters);
            TranslationApi api = new TranslationApi(conf);

            CheckCharactersNumberRequest request = api.CreateCheckRequest(name, folder, format, storage, stream, elements);
            CheckResponse response = api.RunCheckTask(request);
            Console.WriteLine(response);
        }

        static void TranslateDocument(Configuration conf)
        {
            // request parameters for translation
            string name = "test.docx";
            string uploadName = "test.docx";
            string folder = "";
            string pair = "en-fr";
            string format = "docx";
            string outformat = "docx";
            string storage = "First Storage";
            string saveFile = "test-fr.docx";
            string savePath = "";
            bool isValid = false;
            bool masters = false;
            bool optimizePdf = false;
            string origin = ".NET";
            bool details = false;
            List<List<string>> firstFrontLists = new List<List<string>>();
            Dictionary<int, List<List<string>>> frontMatterDict = new Dictionary<int, List<List<string>>>();
            List<int> elements = new List<int>();

            // local paths to upload and download files
            string uploadPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName + "/" + name;
            string downloadPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName + "/" + saveFile;

            TranslationApi api = new TranslationApi(conf);
            FileApi fileApi = new FileApi(conf);

            
            Stream stream = File.Open(uploadPath, FileMode.Open);

            UploadFileRequest uploadRequest= new UploadFileRequest { File = stream, path = uploadName, storageName = storage };
            FilesUploadResult uploadResult = fileApi.UploadFile(uploadRequest);
            Console.WriteLine("Files uploaded: " + uploadResult.Uploaded.Count);
                        
            TranslateDocumentRequest request = api.CreateDocumentRequest(uploadName, folder, pair, format, outformat, storage, saveFile, savePath, masters, elements, isValid, origin, details, optimizePdf, ",", null, frontMatterDict);
            TranslationResponse response = api.RunTranslationTask(request);
            Console.WriteLine(response.Message);
            foreach (var key in response.Details.Keys)
            {
                Console.WriteLine(key + ": " + response.Details[key]);
            }

            DownloadFileRequest downloadRequest = new DownloadFileRequest { storageName = storage, path = saveFile };
            Stream result = fileApi.DownloadFile(downloadRequest);
            Console.WriteLine("Translated file downloaded");
            
            using (FileStream file = new FileStream(downloadPath, FileMode.Create, FileAccess.Write))
            {
                result.CopyTo(file);
            }
            Console.WriteLine("Translated file saved");
        }

        static TextResponse TranslateText(Configuration conf)
        {
            // add text for translation and language pair
            string pair = "en-fr";
            string text = $"Welcome to Paris";
            string type = "text";
            text = HttpUtility.JavaScriptStringEncode(text);
            Console.WriteLine(text);
            TranslationApi api = new TranslationApi(conf);
            TranslateTextRequest request = api.CreateTextRequest(pair, text, type);
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

        static Dictionary<string, string[]> GetLanguagePairs(Configuration conf)
        {
            TranslationApi api = new TranslationApi(conf);
            Dictionary<string, string[]> response = api.GetLanguagePairs();
            return response;
        }
    }
}
