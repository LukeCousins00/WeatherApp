using WeatherApp.Logic.Models.WeatherAPI.ErrorResponse;
using WeatherApp.Logic.Models.WeatherAPI.ForecastApi;

namespace WeatherApp.Logic.Models.WeatherAPI;
public class ForecastModel
{
    public ForecastApiResponse ForecastApiResponse { get; set; }
    public ApiError ApiErrorResponse { get; set; }
}
