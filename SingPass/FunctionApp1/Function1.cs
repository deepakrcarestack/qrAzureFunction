using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;

namespace FunctionApp1
{
    public static class SingpassCallback
    {
        [FunctionName("qrCallback")]
        public static  IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "qrCallback/callback")] HttpRequest req,ILogger log)
        {
            log.LogInformation("Received Code in staging"+ req.Query["code"]);
            return new OkResult();
        }

        [FunctionName("qrCallbackProd")]
        public static IActionResult RunProd([HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "qrCallbackProd/callback")] HttpRequest req, ILogger log)
        {
            log.LogInformation("Received Code in prod" + req.Query["code"]);
            return new OkResult();
        }
    }
}
