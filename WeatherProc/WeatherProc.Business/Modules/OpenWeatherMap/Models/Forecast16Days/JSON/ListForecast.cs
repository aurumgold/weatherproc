using System.Collections.Generic;
using Newtonsoft.Json;

namespace WeatherProc.Business.Modules.OpenWeatherMap.Models.Forecast16Days.JSON
{
    [JsonObject]
    public class ListForecast
    {
        [JsonProperty("dt")]
        public long DateTime { get; set; }

        [JsonProperty("temp")]
        public ListTemperature Temperature { get; set; }

        [JsonProperty("pressure")]
        public double Pressure { get; set; }

        [JsonProperty("humidity")]
        public int Humidity { get; set; }

        [JsonProperty("weather")]
        public IEnumerable<ListWeather> Weather { get; set; }

        [JsonProperty("speed")]
        public double WindSpeed { get; set; }

        [JsonProperty("deg")]
        public int WindDegrees { get; set; }

        [JsonProperty("clouds")]
        public int Clouds { get; set; }

        [JsonProperty("rain")]
        public double Rain { get; set; }

        [JsonProperty("snow")]
        public double Snow { get; set; }
    }
}
