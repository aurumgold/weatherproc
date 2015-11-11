using System;
using System.Xml.Serialization;

namespace WeatherProc.Business.Modules.OpenWeatherMap.Models.Current.XML
{
    [Serializable]
    public class CityCoordinates
    {
        [XmlAttribute("lon")]
        public double Longitude { get; set; }

        [XmlAttribute("lat")]
        public double Latitude { get; set; }
    }
}
