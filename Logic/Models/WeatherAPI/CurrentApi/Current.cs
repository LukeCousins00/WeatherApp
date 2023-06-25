using System.Text.Json.Serialization;

namespace WeatherApp.Logic.Models.WeatherAPI.CurrentApi;

public class Current
{
    public int last_updated_epoch { get; set; }
    public string last_updated { get; set; }
    [JsonPropertyName("temp_c")]
    public float TemperatureCelsius { get; set; }
    [JsonPropertyName("temp_f")]
    public float TemperatureFahrenheit { get; set; }
    [JsonPropertyName("is_day")]
    public int IsDay { get; set; }
    [JsonPropertyName("condition")]
    public Condition Condition { get; set; }
    [JsonPropertyName("wind_mph")]
    public float WindSpeedMilesPerHour { get; set; }
    [JsonPropertyName("wind_kph")]
    public float WindSpeedKilometersPerHour { get; set; }
    public int wind_degree { get; set; }
    public string wind_dir { get; set; }
    public float pressure_mb { get; set; }
    public float pressure_in { get; set; }
    public float precip_mm { get; set; }
    public float precip_in { get; set; }
    [JsonPropertyName("humidity")]
    public int Humidity { get; set; }
    public int cloud { get; set; }
    public float feelslike_c { get; set; }
    public float feelslike_f { get; set; }
    public float vis_km { get; set; }
    public float vis_miles { get; set; }
    [JsonPropertyName("uv")]
    public float UltravioletRayStrength { get; set; }
    public float gust_mph { get; set; }
    public float gust_kph { get; set; }
}
