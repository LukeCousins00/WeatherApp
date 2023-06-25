using System.Text.Json.Serialization;
using WeatherApp.Models.WeatherAPI.CurrentApi;

namespace WeatherApp.Models.WeatherAPI.ForecastApi;

public class ForecastApiResponse
{
    [JsonPropertyName("location")]
    public Location Location { get; set; }
    [JsonPropertyName("current")]
    public Current Current { get; set; }
    [JsonPropertyName("forecast")]
    public Forecast Forecast { get; set; }
}
