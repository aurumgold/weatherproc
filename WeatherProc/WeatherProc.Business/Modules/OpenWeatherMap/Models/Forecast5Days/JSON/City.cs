using Newtonsoft.Json;

namespace WeatherProc.Business.Modules.OpenWeatherMap.Models.Forecast5Days.JSON
{
    [JsonObject]
    public class City
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("coord")]
        public Coordinates Coordinates { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("population")]
        public int Population { get; set; }

        [JsonProperty("sys")]
        public CitySys System { get; set; }
    }
}
