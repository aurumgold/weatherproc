using Newtonsoft.Json;

namespace WeatherProc.Business.Modules.OpenWeatherMap.Models.Forecast16Days.JSON
{
    [JsonObject]
    public class Coordinates
    {
        [JsonProperty("lon")]
        public double Longitude { get; set; }
        [JsonProperty("lat")]
        public double Latitude { get; set; }
    }
}
