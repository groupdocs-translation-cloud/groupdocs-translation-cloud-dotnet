// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TranslationApi.cs">
//   Copyright (c) 2020 GroupDocs.Translation for Cloud
// </copyright>
// <summary>
//   Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GroupDocs.Translation.Cloud.SDK.NET
{
    using System;
    using System.IO;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Newtonsoft.Json;
    using GroupDocs.Translation.Cloud.SDK.NET.Model;
    using GroupDocs.Translation.Cloud.SDK.NET.Model.Requests;
    using GroupDocs.Translation.Cloud.SDK.NET.RequestHandlers;

    /// <summary>
    /// GroupDocs.Translation for Cloud API
    /// </summary>
    public class TranslationApi
    {
        private readonly ApiInvoker apiInvoker;
        private readonly Configuration configuration;

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationApi"/> class
        /// </summary>
        /// <param name="apiKey">
        /// The api Key
        /// </param>
        /// <param name="appSid">
        /// The app Sid
        /// </param>
        public TranslationApi(string apiKey, string appSid)
            : this (new Configuration { ClientSecret = apiKey, ClientId = appSid}) 
        {
        }

        public TranslationApi(string jwtToken)
            : this (new Configuration { JwtToken = jwtToken, ApiVersion = ApiVersion.V1, AuthType = AuthType.JWT})
        {
        }

        /// <summary>
        /// initializes a new instance of the <see cref="TranslationApi"/> class
        /// </summary>
        public TranslationApi(Configuration configuration)
        {
            this.configuration = configuration;
            var requestHandlers = new List<IRequestHandler>();

            switch (this.configuration.AuthType)
            {
                case AuthType.JWT:
                    requestHandlers.Add(new JwtRequestHandler(this.configuration));
                    break;
            }

            requestHandlers.Add(new DebugLogRequestHandler(this.configuration));
            requestHandlers.Add(new ApiExceptionRequestHandler());
            this.apiInvoker = new ApiInvoker(requestHandlers);
        }

        /// <summary>
        /// Create request to get hugo structure
        /// </summary>
        /// <param name="name"></param>
        /// <param name="folder"></param>
        /// <param name="storage"></param>
        /// <returns>"</returns>
        public GetHugoStructureRequest CreateHugoStructureRequest(string name, string folder, string storage)
        {
            HugoInfo hugoInfo = new HugoInfo();
            hugoInfo.Name = name;
            hugoInfo.Folder = folder;
            hugoInfo.Storage = storage;
            string userRequest = String.Format("'[{0}]'", JsonConvert.SerializeObject(hugoInfo));
            GetHugoStructureRequest request = new GetHugoStructureRequest(userRequest);
            return request;
        }

        /// <summary>
        /// Create request to check characters number
        /// </summary>
        /// <param name="name"></param>
        /// <param name="folder"></param>
        /// <param name="format"></param>
        /// <param name="storage"></param>
        /// <param name="file"></param>
        /// <param name="elements"></param>
        /// <param name="separator"></param>
        /// <returns></returns>
        public CheckCharactersNumberRequest CreateCheckRequest(string name,
                                                               string folder,
                                                               string format,
                                                               string storage,
                                                               Stream file,
                                                               List<int> elements,
                                                               string separator = ",")
        {
            CheckInfo checkInfo = new CheckInfo();
            checkInfo.Name = name;
            checkInfo.Folder = folder;
            checkInfo.Format = format;
            checkInfo.Storage = storage;
            checkInfo.Elements = elements;
            checkInfo.Separator = separator;
            byte[] document = new byte[file.Length];
            for (int copied = 0; copied < file.Length;)
            {
                copied += file.Read(document, copied, (int)(file.Length - copied));
            }
            checkInfo.File = document;
            string userRequest = String.Format("'[{0}]'", JsonConvert.SerializeObject(checkInfo));
            CheckCharactersNumberRequest request = new CheckCharactersNumberRequest(userRequest);
            return request;
        }
        
        /// <summary>
        /// Create request for document translation
        /// </summary>
        /// <param name="name"></param>
        /// <param name="folder"></param>
        /// <param name="pair"></param>
        /// <param name="format"></param>
        /// <param name="outformat"></param>
        /// <param name="storage"></param>
        /// <param name="savefile"></param>
        /// <param name="savepath"></param>
        /// <param name="masters"></param>
        /// <param name="elements"></param>
        /// <param name="isValid"></param>
        /// <param name="origin"></param>
        /// <param name="details"></param>
        /// <param name="optimizePdfFontSize"
        /// <param name="separator"></param>
        /// <param name="shortCodeDict"></param>
        /// <param name="frontMatterDict"></param>
        /// <returns></returns>
        public TranslateDocumentRequest CreateDocumentRequest(string name,
                                                              string folder,
                                                              string pair,
                                                              string format,
                                                              string outformat,
                                                              string storage,
                                                              string savefile,
                                                              string savepath,
                                                              bool masters,
                                                              List<int> elements,
                                                              bool isValid = false,
                                                              string origin = ".NET",
                                                              bool details = false,
                                                              bool optimizePdfFontSize = false,
                                                              string separator = ",",
                                                              Dictionary<int, List<string>> shortCodeDict = null,
                                                              Dictionary<int, List<List<string>>> frontMatterDict = null)
        {
            Model.FileInfo fileInfo = new Model.FileInfo();
            fileInfo.Folder = folder;
            fileInfo.Format = format;
            fileInfo.OutFormat = outformat;
            fileInfo.Name = name;
            fileInfo.Pair = pair;
            fileInfo.SaveFile = savefile;
            fileInfo.SavePath = savepath;
            fileInfo.Storage = storage;
            fileInfo.Masters = masters;
            fileInfo.Elements = elements;
            fileInfo.Origin = origin;
            fileInfo.Details = details;
            fileInfo.IsValid = isValid;
            fileInfo.Separator = separator;
            fileInfo.ShortCodeDict = shortCodeDict;
            fileInfo.FrontMatterDict = frontMatterDict;
            fileInfo.OptimizePdfFontSize = optimizePdfFontSize;
            string userRequest = String.Format("'[{0}]'", JsonConvert.SerializeObject(fileInfo));
            TranslateDocumentRequest request = new TranslateDocumentRequest(userRequest);
            return request;
        }

        /// <summary>
        /// Create request for document translation
        /// </summary>
        /// <param name="name"></param>
        /// <param name="folder"></param>
        /// <param name="language"></param>
        /// <param name="format"></param>
        /// <param name="storage"></param>
        /// <param name="savefile"></param>
        /// <param name="savepath"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        /*public SummarizeDocumentRequest CreateSummarizeDocumentRequest(string name,
                                                                       string folder,
                                                                       string language,
                                                                       string format,
                                                                       string outformat,
                                                                       string storage,
                                                                       string savefile,
                                                                       string savepath,
                                                                       int min,
                                                                       int max)
        {
            SummarizeFileInfo fileInfo = new SummarizeFileInfo();
            fileInfo.Folder = folder;
            fileInfo.Format = format;
            fileInfo.OutFormat = outformat;
            fileInfo.Name = name;
            fileInfo.Language = language;
            fileInfo.SaveFile = savefile;
            fileInfo.SavePath = savepath;
            fileInfo.Storage = storage;
            fileInfo.Min = min;
            fileInfo.Max = max;
            string userRequest = String.Format("'[{0}]'", JsonConvert.SerializeObject(fileInfo));
            SummarizeDocumentRequest request = new SummarizeDocumentRequest(userRequest);
            return request;
        }*/

        /// <summary>
        /// Create request for text translation
        /// </summary>
        /// <param name="pair"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        /*public SummarizeTextRequest CreateSummarizeTextRequest(string language, string text, int min, int max)
        {
            SummarizeTextInfo textInfo = new SummarizeTextInfo();
            textInfo.Language = language;
            textInfo.Text = text;
            textInfo.Min = min;
            textInfo.Max = max;
            string userRequest = String.Format("'[{0}]'", JsonConvert.SerializeObject(textInfo,
                                                                                      Formatting.None,
                                                                                      new JsonSerializerSettings { StringEscapeHandling = StringEscapeHandling.EscapeHtml }));
            SummarizeTextRequest request = new SummarizeTextRequest(userRequest);
            return request;
        }*/

        /// <summary>
        /// Create request for text translation
        /// </summary>
        /// <param name="pair"></param>
        /// <param name="text"></param>
        /// <param name="textType"></param>
        /// <param name="details"></param>
        /// <param name="origin"></param>
        /// <returns></returns>
        public TranslateTextRequest CreateTextRequest(string pair, string text, string textType = "text", bool details = false, string origin = ".NET")
        {
            TextInfo textInfo = new TextInfo();
            textInfo.Pair = pair;
            textInfo.Text = text;
            textInfo.Type = textType;
            textInfo.Origin = origin;
            textInfo.Details = details;
            string userRequest = String.Format("'[{0}]'", JsonConvert.SerializeObject(textInfo,
                                                                                      Formatting.None,
                                                                                      new JsonSerializerSettings { StringEscapeHandling = StringEscapeHandling.EscapeHtml }));
            TranslateTextRequest request = new TranslateTextRequest(userRequest);
            return request;
        }

        /// <summary>
        /// Get hugo structure in markdown file
        /// </summary>
        /// <param name="request"><see cref="GetHugoStructureRequest"/></param>
        /// <returns><see cref="HugoResponse"/></returns>
        public HugoResponse RunHugoStructureTask(GetHugoStructureRequest request)
        {
            if (request.UserRequest == null)
            {
                throw new ApiException(400, "Empty request");
            }

            var resourcePath = this.configuration.GetApiRootUrl() + "/hugo";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "POST",
                    request.UserRequest,
                    null,
                    null);
                if (response != null)
                {
                    return (HugoResponse)SerializationHelper.Deserialize(response, typeof(HugoResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.ErrorCode == 404)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Check limit of characters number
        /// </summary>
        /// <param name="request"><see cref="CheckCharactersNumberRequest"/></param>
        /// <returns><see cref="CheckResponse"/></returns>
        public CheckResponse RunCheckTask(CheckCharactersNumberRequest request)
        {
            if (request.UserRequest == null)
            {
                throw new ApiException(400, "Empty request");
            }

            var resourcePath = this.configuration.GetApiRootUrl() + "/check";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "POST",
                    request.UserRequest,
                    null,
                    null);
                if (response != null)
                {
                    return (CheckResponse)SerializationHelper.Deserialize(response, typeof(CheckResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.ErrorCode == 404)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Translate document
        /// </summary>
        /// <param name="request">Request.  <see cref="TranslateDocumentRequest"/> </param>
        /// <returns><see cref="TranslationResponse"/></returns>
        public TranslationResponse RunTranslationTask(TranslateDocumentRequest request)
        {
            if (request.UserRequest == null)
            {
                throw new ApiException(400, "Empty request");
            }

            var resourcePath = this.configuration.GetApiRootUrl() + "/document";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "POST",
                    request.UserRequest,
                    null,
                    null);
                if (response != null)
                {
                    return (TranslationResponse)SerializationHelper.Deserialize(response, typeof(TranslationResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.ErrorCode == 404)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Summarize document
        /// </summary>
        /// <param name="request">Request.  <see cref="SummarizeDocumentRequest"/> </param>
        /// <returns><see cref="SummarizationResponse"/></returns>
        /*public SummarizationResponse RunSummarizationTask(SummarizeDocumentRequest request)
        {
            if (request.UserRequest == null)
            {
                throw new ApiException(400, "Empty request");
            }

            var resourcePath = this.configuration.GetApiRootUrl() + "/summarizefile";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "POST",
                    request.UserRequest,
                    null,
                    null);
                if (response != null)
                {
                    return (SummarizationResponse)SerializationHelper.Deserialize(response, typeof(SummarizationResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.ErrorCode == 404)
                {
                    return null;
                }

                throw;
            }
        }*/

        /// <summary>
        /// Translate text
        /// </summary>
        /// <param name="request">Request.  <see cref="TranslateTextRequest"/> </param>
        /// <returns><see cref="TextResponse"/></returns>
        public TextResponse RunTranslationTextTask(TranslateTextRequest request)
        {
            if (request.UserRequest == null)
            {
                throw new ApiException(400, "Empty request");
            }

            var resourcePath = this.configuration.GetApiRootUrl() + "/text";
            

            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "POST",
                    request.UserRequest,
                    null,
                    null);
                if (response != null)
                {
                    return (TextResponse)SerializationHelper.Deserialize(response, typeof(TextResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.ErrorCode == 404)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Translate text
        /// </summary>
        /// <param name="request">Request.  <see cref="SummarizeTextRequest"/> </param>
        /// <returns><see cref="SummarizationTextResponse"/></returns>
        /*public SummarizationTextResponse RunSummarizationTextTask(SummarizeTextRequest request)
        {
            if (request.UserRequest == null)
            {
                throw new ApiException(400, "Empty request");
            }

            var resourcePath = this.configuration.GetApiRootUrl() + "/summarizetext";


            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "POST",
                    request.UserRequest,
                    null,
                    null);
                if (response != null)
                {
                    return (SummarizationTextResponse)SerializationHelper.Deserialize(response, typeof(SummarizationTextResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.ErrorCode == 404)
                {
                    return null;
                }

                throw;
            }
        }*/

        /// <summary>
        /// Health check of GroupDocs.Translation
        /// </summary>
        /// <returns><see cref="TranslationResponse"/></returns>
        public TranslationResponse RunHealthCheck()
        {
            var resourcePath = this.configuration.GetApiRootUrl() + "/hc";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");


            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "GET",
                    null,
                    null,
                    null);
                if (response != null)
                {
                    return (TranslationResponse)SerializationHelper.Deserialize(response, typeof(TranslationResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.ErrorCode == 404)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Returns structure of request for document translation
        /// </summary>
        /// <returns><see cref="FileInfo"/></returns>
        public Model.FileInfo GetDocumentRequestStructure()
        {
            var resourcePath = this.configuration.GetApiRootUrl() + "/info/document";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            
            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "GET",
                    null,
                    null,
                    null);
                if (response != null)
                {
                    return (Model.FileInfo)SerializationHelper.Deserialize(response, typeof(Model.FileInfo));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.ErrorCode == 404)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Returns structure of request for text translation
        /// </summary>
        /// <returns><see cref="TextInfo"/></returns>
        public TextInfo GetTextRequestStructure()
        {
            var resourcePath = this.configuration.GetApiRootUrl() + "/info/text";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "GET",
                    null,
                    null,
                    null);
                if (response != null)
                {
                    return (TextInfo)SerializationHelper.Deserialize(response, typeof(TextInfo));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.ErrorCode == 404)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Returns structure of request for text translation
        /// </summary>
        /// <returns><see cref="Dictionary<string, string[]>"/></returns>
        public Dictionary<string, string[]> GetLanguagePairs()
        {
            var resourcePath = this.configuration.GetApiRootUrl() + "/info/pairs";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");

            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "GET",
                    null,
                    null,
                    null);
                if (response != null)
                {
                    return (Dictionary<string, string[]>)SerializationHelper.Deserialize(response, typeof(Dictionary<string, string[]>));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.ErrorCode == 404)
                {
                    return null;
                }

                throw;
            }
        }
    }
}
