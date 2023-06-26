using WeatherApp.Logic.Models.WeatherAPI;
using WeatherApp.Logic.Models.WeatherAPI.CurrentApi;

namespace WeatherApp.Logic.Interfaces;
public interface IWeatherApiService
{
    Task<ForecastModel> GetForecastAsync(string location);
    Task<List<Location>> GetLocationsAsync(string location);
}
