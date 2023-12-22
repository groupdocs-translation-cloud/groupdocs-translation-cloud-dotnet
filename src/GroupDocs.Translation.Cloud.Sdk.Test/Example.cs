using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using GroupDocs.Translation.Cloud.Sdk.Api;
using GroupDocs.Translation.Cloud.Sdk.Client;
using GroupDocs.Translation.Cloud.Sdk.Client.Auth;
using GroupDocs.Translation.Cloud.Sdk.Extensions;
using GroupDocs.Translation.Cloud.Sdk.Model;
using HttpStatusCode = System.Net.HttpStatusCode;

namespace GroupDocs.Translation.Cloud.Sdk
{
    /// <summary>
    /// Example of translate text string form English to German
    /// </summary>
    public class Example
    {
        private TranslationApi apiInstance;
        public Example()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.groupdocs.cloud/v2.0/translation";
            // Configure OAuth2 ClientId and ClientSecret: JWT
            config.OAuthClientId = "YOU_CLIENT_ID";
            config.OAuthClientSecret = "YOU_CLIENT_SECRET";
            config.OAuthFlow = OAuthFlow.APPLICATION;
            apiInstance = new TranslationApi(config);
        }
        public string TranslateText(string text, string fromLang, string toLang)
        {
            string res = "";
            var targetLanguages = new List<string>() { toLang };
            var textRequest =
                new TextRequest(fromLang, targetLanguages, new List<string>()
                    {text}, origin: "unit-tests");
            try
            {
                // Translate any supported file
                StatusResponse statusResponse = apiInstance.TextPost(textRequest);
                if (statusResponse.Status.ToSystemHttpStatusCode() == HttpStatusCode.Accepted)
                {
                    while (true)
                    {
                        var result = apiInstance.TextRequestIdGet(statusResponse.Id);
                        if (result.Status.ToSystemHttpStatusCode() == HttpStatusCode.OK)
                        {
                            res = result.Translations[toLang].First();
                            break;
                        }
                        Thread.Sleep(1000);
                    }
                }
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TranslationApi.AutoPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
                res = e.Message;
            }

            return res;
        }
    }
}