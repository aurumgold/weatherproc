using System;
using System.Xml.Serialization;

namespace WeatherProc.Business.Modules.OpenWeatherMap.Models.Forecast16Days.XML
{
    [Serializable]
    public class TimePressure
    {
        [XmlAttribute("unit")]
        public string Unit { get; set; }

        [XmlAttribute("value")]
        public double Value { get; set; }
    }
}
