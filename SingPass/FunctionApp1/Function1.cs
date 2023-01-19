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
        public static  IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = null)] HttpRequest req,ILogger log)
        {
            log.LogInformation("Received Code"+ req.Query["code"]);
            return new OkResult();
        }
    }
}
