using System;
using System.Xml.Serialization;

namespace WeatherProc.Business.Modules.OpenWeatherMap.Models.Forecast5Days.XML
{
    [Serializable]
    public class TimeWindSpeed
    {
        [XmlAttribute("mps")]
        public double Speed { get; set; }

        [XmlAttribute("name")]
        public string Name { get; set; }
    }
}
