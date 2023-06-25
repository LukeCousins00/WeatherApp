using System.Text.Json.Serialization;
using WeatherApp.Logic.Models.WeatherAPI.CurrentApi;

namespace WeatherApp.Logic.Models.WeatherAPI.ForecastApi;

public class ForecastApiResponse
{
    [JsonPropertyName("location")]
    public Location Location { get; set; }
    [JsonPropertyName("current")]
    public Current Current { get; set; }
    [JsonPropertyName("forecast")]
    public Forecast Forecast { get; set; }
}
