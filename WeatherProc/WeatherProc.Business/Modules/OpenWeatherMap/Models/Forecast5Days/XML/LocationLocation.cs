using System;
using System;
using System.Xml.Serialization;

namespace WeatherProc.Business.Modules.OpenWeatherMap.Models.Forecast5Days.XML
{
    [Serializable]
    public class LocationLocation
    {
        [XmlAttribute("altitude")]
        public double Altitude { get; set; }

        [XmlAttribute("latitude")]
        public double Latitude { get; set; }

        [XmlAttribute("longitude")]
        public double Longitude { get; set; }

        [XmlAttribute("geobase")]
        public string Geobase { get; set; }

        [XmlAttribute("geobaseid")]
        public int GeobaseId { get; set; }
    }
}
