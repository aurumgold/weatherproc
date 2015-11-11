using System;
using System.Xml.Serialization;

namespace WeatherProc.Business.Modules.OpenWeatherMap.Models.Current.XML
{
    [Serializable]
    public class Wind
    {
        [XmlElement("speed")]
        public WindSpeed Speed { get; set; }

        [XmlElement("direction")]
        public WindDirection Direction { get; set; }
    }
}
