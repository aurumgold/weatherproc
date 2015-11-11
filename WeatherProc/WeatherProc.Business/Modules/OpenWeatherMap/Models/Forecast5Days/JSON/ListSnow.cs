using Newtonsoft.Json;

namespace WeatherProc.Business.Modules.OpenWeatherMap.Models.Forecast5Days.JSON
{
    [JsonObject]
    public class ListSnow
    {
        [JsonProperty("3h")]
        public double VolumeLast3h { get; set; }
    }
}
