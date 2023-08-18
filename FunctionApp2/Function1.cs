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
            [TimerTrigger("0 */2 * * * *")] TimerInfo myTimer,
            ILogger log)
        {
            // Retrieve the app setting value using GetEnvironmentVariable
            string appSettingValue1 = Environment.GetEnvironmentVariable("YourAppSettingKey1");
            string appSettingValue2 = Environment.GetEnvironmentVariable("Group1:YourAppSettingKey2");
            string appSettingValue3 = Environment.GetEnvironmentVariable("ConnectionStrings:YourAppSettingKey3");

            // Print the app setting value
            log.LogInformation($"App Setting Value: {appSettingValue1}");
            log.LogInformation($"App Setting Value Group1:YourAppSettingKey: {appSettingValue2}");
            log.LogInformation($"App Setting Value ConnectionStrings:YourAppSettingKey: {appSettingValue3}");
        }
    }
}
