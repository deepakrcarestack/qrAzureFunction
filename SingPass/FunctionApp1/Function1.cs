using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using sg.gov.ndi.MyInfoConnector;
using System;

namespace FunctionApp1
{
    public static class SingpassCallback
    {

        [FunctionName("qrCallback")]
        public static IActionResult Run1([HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "qrCallback")] HttpRequest req, ILogger log)
        {
            log.LogInformation("Received Code: " + req.Query["code"] +" , "+ req.Query["state"]);

            //var connector = MyInfoConnector.Create();
            //var authoriseUrl = connector.GetAuthoriseUrl(redirectUrl);
            //connector.GetPersonJson(authCode, state);
            return new OkResult();
        }
    }
}
