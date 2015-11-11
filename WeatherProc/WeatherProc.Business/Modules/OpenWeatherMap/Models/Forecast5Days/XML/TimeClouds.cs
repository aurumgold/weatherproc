using System;
using System.Xml.Serialization;

namespace WeatherProc.Business.Modules.OpenWeatherMap.Models.Forecast5Days.XML
{
    [Serializable]
    public class TimeClouds
    {
        [XmlAttribute("value")]
        public string Value { get; set; }

        [XmlAttribute("all")]
        public int All { get; set; }

        [XmlAttribute("unit")]
        public string Unit { get; set; }
    }
}
