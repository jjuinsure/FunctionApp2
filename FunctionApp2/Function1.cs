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
            string appSetting1 = Environment.GetEnvironmentVariable("AppSetting1");
            string appSetting2 = Environment.GetEnvironmentVariable("Group1:AppSetting2");
            string appSetting3 = Environment.GetEnvironmentVariable("Group1:AppSetting3");
            string appSetting4 = Environment.GetEnvironmentVariable("ConnectionStrings:AppSetting4");
            string appSetting5 = Environment.GetEnvironmentVariable("Group1__AppSetting5");
        

            // Print the app setting value
            log.LogInformation($"App Setting Value AppSetting1: {appSetting1}");
            log.LogInformation($"App Setting Value Group1:AppSetting2: {appSetting2}");
            log.LogInformation($"App Setting Value Group1:AppSetting3: {appSetting3}");
            log.LogInformation($"App Setting Value ConnectionStrings:AppSetting4: {appSetting4}");
            log.LogInformation($"App Setting Value CGroup1:AppSetting5: {appSetting5}");
        }
    }
}
