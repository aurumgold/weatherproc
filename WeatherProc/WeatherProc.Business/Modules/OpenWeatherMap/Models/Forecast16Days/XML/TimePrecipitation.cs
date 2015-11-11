using System;
using System.Xml.Serialization;

namespace WeatherProc.Business.Modules.OpenWeatherMap.Models.Forecast16Days.XML
{
    [Serializable]
    public class TimePrecipitation
    {
        [XmlAttribute("value")]
        public double Value { get; set; }

        [XmlAttribute("unit")]
        public string Unit { get; set; }

        [XmlAttribute("type")]
        public string Type { get; set; }
    }
}
