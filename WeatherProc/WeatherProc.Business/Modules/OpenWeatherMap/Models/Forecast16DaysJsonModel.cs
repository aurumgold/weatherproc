using System.Collections.Generic;
using Newtonsoft.Json;
using WeatherProc.Business.Modules.OpenWeatherMap.Models.Forecast16Days.JSON;

namespace WeatherProc.Business.Modules.OpenWeatherMap.Models
{
    [JsonObject]
    public class Forecast16DaysJsonModel : JsonModel
    {
        [JsonProperty("city")]
        public City City { get; set; }

        [JsonProperty("cod")]
        public string Code { get; set; }

        [JsonProperty("message")]
        public double Message { get; set; }

        [JsonProperty("cnt")]
        public int LinesCount { get; set; }

        [JsonProperty("list")]
        public IEnumerable<ListForecast> Forecast { get; set; }
    }
}
