using WeatherApp.Logic.Models.WeatherAPI.ForecastApi;

namespace WeatherApp.Logic.Interfaces;
public interface IWeatherApiService
{
    Task<ForecastApiResponse> GetForecastAsync(string location);
}
