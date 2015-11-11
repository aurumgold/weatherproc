using System;
using System.Xml.Serialization;

namespace WeatherProc.Business.Modules.OpenWeatherMap.Models.Forecast5Days.XML
{
    [Serializable]
    public class TimeWindDirection
    {
        [XmlAttribute("deg")]
        public double Degrees { get; set; }

        [XmlAttribute("code")]
        public string Code { get; set; }

        [XmlAttribute("name")]
        public string Name { get; set; }
    }
}
