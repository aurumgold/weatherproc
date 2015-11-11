using Newtonsoft.Json;

namespace WeatherProc.Business.Modules.OpenWeatherMap.Models.Forecast5Days.JSON
{
    [JsonObject]
    public class ListWind
    {
        public double Speed { get; set; }
        public double Degrees { get; set; }
    }
}
