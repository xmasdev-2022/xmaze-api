using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net;
using System.Net.Http.Headers;

namespace XMazeApi
{
    public static class XMasFunctions
    {
        [FunctionName("DefaultFunction")]
        public static async Task<IActionResult> RunDefaultFunction(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# RunDefaultFunction");

            string name = req.Query["name"];

            if(string.IsNullOrEmpty(name) )
            {
                return new BadRequestResult();
            }

            string responseMessage = $"Merry XMas, {name}.";

            return new OkObjectResult(responseMessage);
        }

        [FunctionName("XMasTotalPackages")]
        public static async Task<HttpResponseMessage> RunXMasTotalPackages(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequest req,
            ILogger log)
        {
            //TODO block to change
            if(true) 
            {
                log.LogInformation("C# RunXMasTotalPackages");
            }
            else 
            {

            }

            string name = req.Query["name"];

            var html = "<html><head><script>alert('"+ name + "')</script></head><body><span>"+ name + "</span></body></html>";
            var response = new HttpResponseMessage(HttpStatusCode.OK);
            response.Content = new StringContent(html);
            response.Content.Headers.ContentType = new MediaTypeHeaderValue("text/html");
            return response;

        }
    }
}
