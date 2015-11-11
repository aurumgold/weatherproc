using System;
using System.Xml.Serialization;

namespace WeatherProc.Business.Modules.OpenWeatherMap.Models.Current.XML
{
    [Serializable]
    public class WindSpeed
    {
        [XmlAttribute("value")]
        public double Value { get; set; }

        [XmlAttribute("name")]
        public string Name { get; set; }
    }
}
