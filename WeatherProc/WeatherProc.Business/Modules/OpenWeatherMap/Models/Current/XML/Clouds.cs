using System;
using System.Xml.Serialization;

namespace WeatherProc.Business.Modules.OpenWeatherMap.Models.Current.XML
{
    [Serializable]
    public class Clouds
    {
        [XmlAttribute("value")]
        public int Value { get; set; }

        [XmlAttribute("name")]
        public string Name { get; set; }
    }
}
