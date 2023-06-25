using Microsoft.AspNetCore.Mvc;
using WeatherApp.Logic.Interfaces;
using WeatherApp.Logic.Models.WeatherAPI.ForecastApi;
using WeatherApp.ViewModels;

namespace WeatherApp.Controllers;
public class WeatherController : Controller
{
    private readonly IWeatherApiService _weatherApiService;

    public WeatherController(IWeatherApiService weatherApiService)
    {
        _weatherApiService = weatherApiService;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Index(string location)
    {
        ForecastApiResponse forecast = await _weatherApiService.GetForecastAsync(location);

        WeatherViewModel viewModel = new WeatherViewModel()
        {
            Astrology = forecast.Forecast.TodaysForecast.First().Astrology,
            Current = forecast.Current,
            Day = forecast.Forecast.TodaysForecast.First().Day,
            Location = forecast.Location
        };

        return View(viewModel);
    }
}
