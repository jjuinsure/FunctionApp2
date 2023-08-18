using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace FunctionApp2
{
    public class AppSettingsFunction
    {
        [FunctionName("RetrieveAppSetting")]
        public static void Run(
            [TimerTrigger("0 * * * * *")] TimerInfo myTimer,
            ILogger log)
        {
            // Retrieve the app setting value using GetEnvironmentVariable
            string appSettingValue = Environment.GetEnvironmentVariable("YourAppSettingKey");

            // Print the app setting value
            log.LogInformation($"App Setting Value: {appSettingValue}");
        }
    }
}
