using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;

namespace FunctionApp1
{
    public static class SingpassCallback
    {
        [FunctionName("qrCallback_callback")]
        public static  IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "qrCallback/callback")] HttpRequest req,ILogger log)
        {
            log.LogInformation("Received Code in staging"+ req.Query["code"]);
            return new OkResult();
        }

        [FunctionName("qrCallbackProd_callback")]
        public static IActionResult RunProd([HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "qrCallbackProd/callback")] HttpRequest req, ILogger log)
        {
            log.LogInformation("Received Code in prod" + req.Query["code"]);
            return new OkResult();
        }

        [FunctionName("qrCallback")]
        public static IActionResult Run1([HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "qrCallback")] HttpRequest req, ILogger log)
        {
            log.LogInformation("Received Code in staging 1" + req.Query["code"]);
            return new OkResult();
        }

        [FunctionName("qrCallbackProd")]
        public static IActionResult RunProd1([HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "qrCallbackProd")] HttpRequest req, ILogger log)
        {
            log.LogInformation("Received Code in prod 1" + req.Query["code"]);
            return new OkResult();
        }
    }
}
