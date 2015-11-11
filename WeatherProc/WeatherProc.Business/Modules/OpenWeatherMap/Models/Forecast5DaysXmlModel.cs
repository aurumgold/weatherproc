using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using WeatherProc.Business.Modules.OpenWeatherMap.Models.Forecast5Days.XML;

namespace WeatherProc.Business.Modules.OpenWeatherMap.Models
{
    [Serializable]
    [XmlRoot("weatherdata")]
    public class Forecast5DaysXmlModel : XmlModel
    {
        [XmlElement("location")]
        public Location Location { get; set; }

        [XmlElement("meta")]
        public Meta Meta { get; set; }

        [XmlElement("sun")]
        public Sun Sun { get; set; }

        [XmlArray("forecast")]
        [XmlArrayItem("time")]
        public List<Time> Forecast { get; set; }
    }
}
