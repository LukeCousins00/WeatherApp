using System.Text.Json;
using WeatherApp.Logic.Interfaces;
using WeatherApp.Logic.Models.WeatherAPI;
using WeatherApp.Logic.Models.WeatherAPI.CurrentApi;
using WeatherApp.Logic.Models.WeatherAPI.ErrorResponse;
using WeatherApp.Logic.Models.WeatherAPI.ForecastApi;

namespace WeatherApp.Logic.Services;
public class WeatherApiService : IWeatherApiService
{
    private readonly HttpClient _httpClient;

    public WeatherApiService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<ForecastModel> GetForecastAsync(string location)
    {
        var weatherApiResponse = await _httpClient.GetAsync($"/v1/forecast.json?key={Environment.GetEnvironmentVariable("API_KEY")}&q={location}");
        var apiResponseContent = await weatherApiResponse.Content.ReadAsStringAsync();

        ForecastModel forecastModel = new ForecastModel();

        if (!weatherApiResponse.IsSuccessStatusCode)
        {
            try
            {
                forecastModel.ApiErrorResponse = JsonSerializer.Deserialize<ApiError>(apiResponseContent);

                return forecastModel;
            }

            catch (Exception)
            {
                throw new Exception("Failed to get response from WeatherAPI");
            }
        }

        forecastModel.ForecastApiResponse = JsonSerializer.Deserialize<ForecastApiResponse>(apiResponseContent);

        return forecastModel;
    }

    public async Task<List<Location>> GetLocationsAsync(string location)
    {
        var weatherApiResponse = await _httpClient.GetAsync($"/v1/search.json?key={Environment.GetEnvironmentVariable("API_KEY")}&q={location}");
        var apiResponseContent = await weatherApiResponse.Content.ReadAsStringAsync();

        if (!weatherApiResponse.IsSuccessStatusCode)
        {
            throw new Exception("Failed to get response from WeatherAPI");
        }

        try
        {
            List<Location> locations = JsonSerializer.Deserialize<List<Location>>(apiResponseContent);
            return locations;
        }
        catch (Exception)
        {
            return null;
        }
    }
}