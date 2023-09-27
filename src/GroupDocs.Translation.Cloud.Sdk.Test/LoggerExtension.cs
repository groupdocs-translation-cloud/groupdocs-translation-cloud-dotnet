using System.Runtime.CompilerServices;
using Microsoft.Extensions.Logging;

namespace GroupDocs.Translation.Cloud.Sdk
{
    public static class LoggerExtension
    {
        public static void LogInformation(this ILogger logger, string message, [CallerMemberName] string methodName = null)
        {
            logger.Log(LogLevel.Information, $".{methodName}: {message}");
        }
    }
}