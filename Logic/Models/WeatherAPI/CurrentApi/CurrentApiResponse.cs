using System.Text.Json.Serialization;

namespace WeatherApp.Logic.Models.WeatherAPI.CurrentApi;

public class CurrentApiResponse
{
    [JsonPropertyName("location")]
    public Location Location { get; set; } // exact location from which the data is gathered

    [JsonPropertyName("current")]
    public Current Current { get; set; }
}