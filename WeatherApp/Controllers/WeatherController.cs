using Microsoft.AspNetCore.Mvc;
using WeatherApp.Logic.Interfaces;
using WeatherApp.Logic.Models.WeatherAPI;
using WeatherApp.Logic.Models.WeatherAPI.CurrentApi;
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
        ForecastModel forecast = await _weatherApiService.GetForecastAsync(location);
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
        var locations = await _weatherApiService.GetLocationsAsync(location);

        return Json(locations);
    }
}
