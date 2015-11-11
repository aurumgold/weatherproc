using Newtonsoft.Json;

namespace WeatherProc.Business.Modules.OpenWeatherMap.Models.Forecast16Days.JSON
{
    [JsonObject]
    public class ListWeather
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("main")]
        public string Main { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }
    }
}
