using System.Collections.Generic;
using Newtonsoft.Json;
using WeatherProc.Business.Modules.OpenWeatherMap.Models.Current.JSON;

namespace WeatherProc.Business.Modules.OpenWeatherMap.Models
{
    [JsonObject]
    public class CurrentJsonModel : JsonModel
    {
        [JsonProperty("coord")]
        public Coordinates Coordinates { get; set; }

        [JsonProperty("weather")]
        public IEnumerable<Weather> Weather { get; set; }

        [JsonProperty("base")]
        public string Base { get; set; }

        [JsonProperty("main")]
        public Main Main { get; set; }

        [JsonProperty("wind")]
        public Wind Wind { get; set; }

        [JsonProperty("clouds")]
        public Clouds Clouds { get; set; }

        [JsonProperty("rain")]
        public Rain Rain { get; set; }

        [JsonProperty("snow")]
        public Snow Snow { get; set; }

        [JsonProperty("dt")]
        public long DateStamp { get; set; }

        [JsonProperty("sys")]
        public SystemParameters SystemParametrs { get; set; }

        [JsonProperty("id")]
        public int CityId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("cod")]
        public int Code { get; set; }
    }
}
