using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.AspNetCore.Mvc;
using WeatherApp.Logic.Interfaces;
using WeatherApp.Logic.Models.WeatherAPI;
using WeatherApp.Logic.Models.WeatherAPI.CurrentApi;
using WeatherApp.ViewModels;

namespace WeatherApp.Controllers;
public class WeatherController : Controller
{
    private readonly IWeatherApiService _weatherApiService;
    private readonly IConfiguration _configuration;

    public WeatherController(IWeatherApiService weatherApiService, IConfiguration configuration)
    {
        _weatherApiService = weatherApiService;
        _configuration = configuration;

    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Index(string location)
    {
        var apiKey = _configuration.GetSection("WeatherApiKey").Value;

        ForecastModel forecast = await _weatherApiService.GetForecastAsync(location, apiKey);
        WeatherViewModel viewModel = new WeatherViewModel();

        if (forecast.ApiErrorResponse != null)
        {
            viewModel.ErrorMessage = forecast.ApiErrorResponse.Error.Message;

            return View(viewModel);
        }

        viewModel.Astrology = forecast.ForecastApiResponse.Forecast.TodaysForecast.First().Astrology;
        viewModel.Current = forecast.ForecastApiResponse.Current;
        viewModel.Day = forecast.ForecastApiResponse.Forecast.TodaysForecast.First().Day;
        viewModel.Location = forecast.ForecastApiResponse.Location;

        return View(viewModel); 
    }

    [HttpGet]
    public async Task<IActionResult> AutocompleteData(string location)
    {
        var apiKey = _configuration.GetSection("WeatherApiKey").Value;

        var locations = await _weatherApiService.GetLocationsAsync(location, apiKey);

        return Json(locations);
    }
}
