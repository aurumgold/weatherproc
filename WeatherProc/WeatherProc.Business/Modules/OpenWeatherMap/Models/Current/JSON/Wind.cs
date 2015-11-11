using Newtonsoft.Json;

namespace WeatherProc.Business.Modules.OpenWeatherMap.Models.Current.JSON
{
    [JsonObject]
    public class Wind
    {
        [JsonProperty("speed")]
        public double Speed { get; set; }

        [JsonProperty("deg")]
        public double Degrees { get; set; }
    }
}
