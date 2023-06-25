using WeatherApp.Models.WeatherAPI.CurrentApi;
using WeatherApp.Models.WeatherAPI.ForecastApi;

namespace WeatherApp.ViewModels;

public class WeatherViewModel
{ 
    public Day Day { get; set; }
    public Current Current { get; set; }
    public Astro Astrology { get; set; }
}