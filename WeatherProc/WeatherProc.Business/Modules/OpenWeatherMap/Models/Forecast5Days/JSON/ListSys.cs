using Newtonsoft.Json;

namespace WeatherProc.Business.Modules.OpenWeatherMap.Models.Forecast5Days.JSON
{
    [JsonObject]
    public class ListSys
    {
        [JsonProperty("pod")]
        public string Pod { get; set; }
    }
}
