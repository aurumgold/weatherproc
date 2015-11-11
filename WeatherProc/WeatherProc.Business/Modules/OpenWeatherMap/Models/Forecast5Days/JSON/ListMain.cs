using Newtonsoft.Json;

namespace WeatherProc.Business.Modules.OpenWeatherMap.Models.Forecast5Days.JSON
{
    [JsonObject]
    public class ListMain
    {
        [JsonProperty("temp")]
        public double Temperature { get; set; }

        [JsonProperty("temp_min")]
        public double TemperatureMin { get; set; }

        [JsonProperty("temp_max")]
        public double TemperatureMax { get; set; }

        [JsonProperty("pressure")]
        public double Preassure { get; set; }

        [JsonProperty("sea_level")]
        public double SeaLvl { get; set; }

        [JsonProperty("grnd_level")]
        public double GroundLvl { get; set; }

        [JsonProperty("humidity")]
        public int Humidity { get; set; }

        [JsonProperty("temp_kf")]
        public double TemperatureKf { get; set; }
    }
}
