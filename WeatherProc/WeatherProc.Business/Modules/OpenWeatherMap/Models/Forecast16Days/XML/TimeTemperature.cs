using System;
using System.Xml.Serialization;
namespace WeatherProc.Business.Modules.OpenWeatherMap.Models.Forecast16Days.XML
{
    [Serializable]
    public class TimeTemperature
    {
        [XmlAttribute("min")]
        public double Min { get; set; }

        [XmlAttribute("max")]
        public double Max { get; set; }

        [XmlAttribute("night")]
        public double Night { get; set; }

        [XmlAttribute("morn")]
        public double Morning { get; set; }

        [XmlAttribute("day")]
        public double Day { get; set; }

        [XmlAttribute("eve")]
        public double Evening { get; set; }
    }
}
