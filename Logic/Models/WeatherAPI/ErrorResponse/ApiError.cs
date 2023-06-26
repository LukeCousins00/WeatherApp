using System.Text.Json.Serialization;

namespace WeatherApp.Logic.Models.WeatherAPI.ErrorResponse;

public class ApiError
{
    [JsonPropertyName("error")]
    public Error Error { get; set; }
}