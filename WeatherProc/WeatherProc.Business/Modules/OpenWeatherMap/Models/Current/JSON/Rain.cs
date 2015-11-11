using Newtonsoft.Json;

namespace WeatherProc.Business.Modules.OpenWeatherMap.Models.Current.JSON
{
    [JsonObject]
    public class Rain
    {
        [JsonProperty("3h")]
        public double VolumeLast3h { get; set; } 
    }
}
