using System.Text.Json.Serialization;

namespace Company.Function;

public class TodoItem
{

    [JsonPropertyName("name")]
    public string? Name {get; set;}

    [JsonPropertyName("id")]
    public string? Id {get;set;}
}