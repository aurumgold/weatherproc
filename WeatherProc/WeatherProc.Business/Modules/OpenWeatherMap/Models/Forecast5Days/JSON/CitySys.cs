using Newtonsoft.Json;

namespace WeatherProc.Business.Modules.OpenWeatherMap.Models.Forecast5Days.JSON
{
    [JsonObject]
    public class CitySys
    {
        [JsonProperty("population")]
        public int Population { get; set; }
    }
}
