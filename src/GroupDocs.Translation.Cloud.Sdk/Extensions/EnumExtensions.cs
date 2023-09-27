using System;
using GroupDocs.Translation.Cloud.Sdk.Model;

namespace GroupDocs.Translation.Cloud.Sdk.Extensions
{
    public static class EnumExtensions
    {
        public static System.Net.HttpStatusCode ToSystemHttpStatusCode(this HttpStatusCode? statusCode)
        {
            return (System.Net.HttpStatusCode)(statusCode ?? HttpStatusCode._404);
        }
    }
}