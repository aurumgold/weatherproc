using System;
using System.Xml.Serialization;

namespace WeatherProc.Business.Modules.OpenWeatherMap.Models.Current.XML
{
    [Serializable]
    public class City
    {
        [XmlAttribute("id")]
        public int Id { get; set; }

        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlElement("coord")]
        public CityCoordinates Coordinates { get; set; }

        [XmlElement("country")]
        public string Country { get; set; }

        [XmlElement("sun")]
        public Sun Sun { get; set; }
    }
}
