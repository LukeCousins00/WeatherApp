using System.Text.Json.Serialization;

namespace WeatherApp.Models.WeatherAPI.ForecastApi;

public class Forecast
{
    [JsonPropertyName("forecastday")]
    public Forecastday[] TodaysForecast { get; set; }
}
