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
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
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
            : this (new Configuration { AppKey = apiKey, AppSid = appSid}) 
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
    }
}
