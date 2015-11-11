using Newtonsoft.Json;

namespace WeatherProc.Business.Modules.OpenWeatherMap.Models.Forecast16Days.JSON
{
    [JsonObject]
    public class ListTemperature
    {
        [JsonProperty("min")]
        public double Min { get; set; }

        [JsonProperty("max")]
        public double Max { get; set; }

        [JsonProperty("night")]
        public double Night { get; set; }

        [JsonProperty("morn")]
        public double Morning { get; set; }

        [JsonProperty("day")]
        public double Day { get; set; }

        [JsonProperty("eve")]
        public double Evening { get; set; }
    }
}
