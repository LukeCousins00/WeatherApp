using System.Text.Json.Serialization;

namespace WeatherApp.Logic.Models.WeatherAPI.ErrorResponse;
public class Error
{
    [JsonPropertyName("code")]
    public int Code { get; set; }
    [JsonPropertyName("message")]
    public string Message { get; set; }
}