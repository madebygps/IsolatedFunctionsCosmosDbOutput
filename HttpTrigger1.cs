using System.Collections.Generic;
using System.Net;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace Company.Function
{
    public class HttpTrigger1
    {
        private readonly ILogger _logger;

        public HttpTrigger1(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<HttpTrigger1>();
        }

        [Function("HttpTrigger1")]
        public ItemOutputType Run([HttpTrigger(AuthorizationLevel.Function, "post")] HttpRequestData req, string name)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");

            var response = req.CreateResponse(HttpStatusCode.OK);
            response.Headers.Add("Content-Type", "text/plain; charset=utf-8");

            response.WriteString($"Created new item: {name}");

            return new ItemOutputType()
            {
                newItem = new TodoItem()
                {
                    Name = name,
                    Id = Guid.NewGuid().ToString("N")
                    
                },
                response = response
                

            };
        }
    }
}
