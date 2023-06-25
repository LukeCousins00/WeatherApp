using System.Text.Json;
using WeatherApp.Logic.Interfaces;
using WeatherApp.Logic.Models.WeatherAPI.ForecastApi;

namespace WeatherApp.Logic.Services;
public class WeatherApiService : IWeatherApiService
{
    private readonly HttpClient _httpClient;

    public WeatherApiService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<ForecastApiResponse> GetForecastAsync(string location)
    {

        using (var httpClient = new HttpClient())
        {

        }
        


        var weatherApiResponse = await _httpClient.GetAsync($"/v1/forecast.json?key={Environment.GetEnvironmentVariable("API_KEY")}&q={location}");
        var weatherApiContent = await weatherApiResponse.Content.ReadAsStringAsync();

        if (!weatherApiResponse.IsSuccessStatusCode)
        {
            throw new Exception("Failed to get response from WeatherAPI");
        }

        ForecastApiResponse forecast = JsonSerializer.Deserialize<ForecastApiResponse>(weatherApiContent);

        return forecast;
    } 
}
