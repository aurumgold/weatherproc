using System;
using System.Xml.Serialization;

namespace WeatherProc.Business.Modules.OpenWeatherMap.Models.Forecast16Days.XML
{
    [Serializable]
    public class Location
    {
        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("country")]
        public string Country { get; set; }

        [XmlElement("location")]
        public LocationLocation LocationLocation { get; set; }
    }
}
