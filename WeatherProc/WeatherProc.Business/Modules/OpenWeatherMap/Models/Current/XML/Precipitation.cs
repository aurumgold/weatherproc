using System;
using System.Xml.Serialization;

namespace WeatherProc.Business.Modules.OpenWeatherMap.Models.Current.XML
{
    [Serializable]
    public class Precipitation
    {
        [XmlAttribute("value")]
        public string Value { get; set; }

        [XmlAttribute("mode")]
        public string Mode { get; set; }
    }
}
