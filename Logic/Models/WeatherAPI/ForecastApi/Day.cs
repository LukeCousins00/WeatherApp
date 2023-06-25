using System.Text.Json.Serialization;
using WeatherApp.Logic.Models.WeatherAPI.CurrentApi;

namespace WeatherApp.Logic.Models.WeatherAPI.ForecastApi;

public class Day
{
    [JsonPropertyName("maxtemp_c")]
    public float MaxTemperatureCelsius { get; set; }
    [JsonPropertyName("maxtemp_f")]
    public float MaxTemperatureFahrenheit { get; set; }
    [JsonPropertyName("mintemp_c")]
    public float MinTemperatureCelsius { get; set; }
    [JsonPropertyName("mintemp_f")]
    public float MinTemperatureFahrenheit { get; set; }
    [JsonPropertyName("avgtemp_c")]
    public float AverageTemperatureCelsius { get; set; }
    [JsonPropertyName("avgtemp_f")]
    public float AverageTemperatureFahrenheit { get; set; }
    [JsonPropertyName("maxwind_mph")]
    public float MaxWindSpeedMilesPerHour { get; set; }
    [JsonPropertyName("maxwind_kph")]

    public float MaxWindSpeedKilometersPerHour { get; set; }
    public float totalprecip_mm { get; set; }
    public float totalprecip_in { get; set; }
    public float totalsnow_cm { get; set; }
    public float avgvis_km { get; set; }
    public float avgvis_miles { get; set; }
    public float avghumidity { get; set; }
    public int daily_will_it_rain { get; set; }
    public int daily_chance_of_rain { get; set; }
    public int daily_will_it_snow { get; set; }
    public int daily_chance_of_snow { get; set; }

    [JsonPropertyName("condition")]
    public Condition Condition { get; set; }
    public float uv { get; set; }
}