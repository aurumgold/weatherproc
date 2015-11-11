using System;
using System.Xml.Serialization;

namespace WeatherProc.Business.Modules.OpenWeatherMap.Models.Current.XML
{
    [Serializable]
    public class Pressure
    {
        [XmlAttribute("value")]
        public double Value { get; set; }

        [XmlAttribute("unit")]
        public string Unit { get; set; }
    }
}
