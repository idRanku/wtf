namespace Agent.Api.Models;

public class RequestDto {

    [JsonPropertyName("source")]
    public string Source { get; set; }

    [JsonPropertyName("message")]
    public string Message { get; set; }

}