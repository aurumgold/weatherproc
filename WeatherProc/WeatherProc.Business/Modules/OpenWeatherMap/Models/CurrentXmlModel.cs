using System;
using System.Xml.Serialization;
using WeatherProc.Business.Modules.OpenWeatherMap.Models.Current.XML;

namespace WeatherProc.Business.Modules.OpenWeatherMap.Models
{
    [Serializable]
    [XmlRoot("current")]
    public class CurrentXmlModel : XmlModel
    {
        [XmlElement("city")]
        public City City { get; set; }

        [XmlElement("temperature")]
        public Temperature Temperature { get; set; }

        [XmlElement("humidity")]
        public Humidity Humidity { get; set; }

        [XmlElement("pressure")]
        public Pressure Preassure { get; set; }

        [XmlElement("wind")]
        public Wind Wind { get; set; }

        [XmlElement("clouds")]
        public Clouds Clouds { get; set; }

        [XmlElement("visibility")]
        public Visibility Visibility { get; set; }

        [XmlElement("precipitation")]
        public Precipitation Precipitation { get; set; }

        [XmlElement("weather")]
        public Weather Weather { get; set; }

        [XmlElement("lastupdate")]
        public LastUpdate LastUpdate { get; set; }
    }
}
