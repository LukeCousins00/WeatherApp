using System.Text.Json.Serialization;

namespace WeatherApp.Models.WeatherAPI.CurrentApi;

public class Location
{
    [JsonPropertyName("name")]
    public string Name { get; set; }
    [JsonPropertyName("region")]
    public string Region { get; set; }
    [JsonPropertyName("country")]
    public string Country { get; set; }
    [JsonPropertyName("lat")]
    public float Latitude { get; set; }
    [JsonPropertyName("lon")]
    public float Longitude { get; set; }
    [JsonPropertyName("tz_id")]
    public string Timezone { get; set; }
    [JsonPropertyName("localtime_epoch")]
    public int LocalTimeEpoch { get; set; }
    [JsonPropertyName("localtime")]
    public string LocalTime { get; set; }
}
