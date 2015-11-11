using Newtonsoft.Json;

namespace WeatherProc.Business.Modules.OpenWeatherMap.Models.Current.JSON
{
    [JsonObject]
    public class Main
    {
        [JsonProperty("temp")]
        public double Temperature { get; set; }

        [JsonProperty("pressure")]
        public double Preasure { get; set; }

        [JsonProperty("humidity")]
        public double Humidity { get; set; }

        [JsonProperty("temp_min")]
        public double TemperatureMin { get; set; }

        [JsonProperty("temp_max")]
        public double TemperatureMax { get; set; }

        [JsonProperty("sea_level")]
        public double SeaLevel { get; set; }

        [JsonProperty("grnd_level")]
        public double GrndLevel { get; set; }
    }
}
