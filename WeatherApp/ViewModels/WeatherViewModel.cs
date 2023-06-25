using WeatherApp.Logic.Models.WeatherAPI.CurrentApi;
using WeatherApp.Logic.Models.WeatherAPI.ForecastApi;

namespace WeatherApp.ViewModels;

public class WeatherViewModel
{ 
    public Day Day { get; set; }
    public Current Current { get; set; }
    public Astro Astrology { get; set; }
    public Location Location { get; set; }
}