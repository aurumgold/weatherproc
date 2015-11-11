using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WeatherProc.Business.Modules.OpenWeatherMap.Models.Forecast5Days.JSON
{
    [JsonObject]
    public class Forecast
    {
        [JsonProperty("dt")]
        public long Date { get; set; }

        [JsonProperty("main")]
        public ListMain Main { get; set; }

        [JsonProperty("weather")]
        public IEnumerable<ListWeather> Weather { get; set; }

        [JsonProperty("clouds")]
        public ListClouds Clouds { get; set; }

        [JsonProperty("wind")]
        public ListWind Wind { get; set; }

        [JsonProperty("rain")]
        public ListRain Rain { get; set; }

        [JsonProperty("snow")]
        public ListSnow Snow { get; set; }

        [JsonProperty("sys")]
        public ListSys System { get; set; }

        [JsonProperty("dt_txt")]
        public DateTime DateTxt { get; set; }
    }
}
