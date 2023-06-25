using System.Text.Json.Serialization;

namespace WeatherApp.Models.WeatherAPI.ForecastApi;

public class Forecastday
{

    [JsonPropertyName("date")]
    public string Date { get; set; }
    [JsonPropertyName("date_epoch")]
    public int DateEpoch { get; set; }
    [JsonPropertyName("day")]
    public Day Day { get; set; }
    [JsonPropertyName("astro")]
    public Astro Astrology { get; set; }
    [JsonPropertyName("hour")]
    public Hour[] Hour { get; set; }
}