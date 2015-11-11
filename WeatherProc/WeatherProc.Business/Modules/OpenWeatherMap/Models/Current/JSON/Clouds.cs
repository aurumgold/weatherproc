using Newtonsoft.Json;

namespace WeatherProc.Business.Modules.OpenWeatherMap.Models.Current.JSON
{
    [JsonObject]
    public class Clouds
    {
        [JsonProperty("all")]
        public int All { get; set; }
    }
}
