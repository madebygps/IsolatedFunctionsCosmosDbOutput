using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;

namespace Company.Function;

public class ItemOutputType
{

    [CosmosDBOutput("%DatabaseName%", "%CollectionName%", ConnectionStringSetting = "ComosDbConnection", CreateIfNotExists = true)]
    public TodoItem? newItem {get;set;}
    public HttpResponseData? response {get;set;}
    
}
