using System.Text.Json.Serialization;

namespace WeatherApp.Logic.Models.WeatherAPI.ForecastApi;

public class Forecast
{
    [JsonPropertyName("forecastday")]
    public Forecastday[] TodaysForecast { get; set; }
}
