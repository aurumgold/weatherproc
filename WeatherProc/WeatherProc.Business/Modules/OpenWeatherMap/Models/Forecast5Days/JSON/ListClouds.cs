using Newtonsoft.Json;

namespace WeatherProc.Business.Modules.OpenWeatherMap.Models.Forecast5Days.JSON
{
    [JsonObject]
    public class ListClouds
    {
        [JsonProperty("all")]
        public int All { get; set; }
    }
}
