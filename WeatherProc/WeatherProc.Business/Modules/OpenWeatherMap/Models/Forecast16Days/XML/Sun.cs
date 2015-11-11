using System;
using System.Xml.Serialization;

namespace WeatherProc.Business.Modules.OpenWeatherMap.Models.Forecast16Days.XML
{
    [Serializable]
    public class Sun
    {
        [XmlAttribute("rise")]
        public DateTime Rise { get; set; }

        [XmlAttribute("set")]
        public DateTime Set { get; set; }
    }
}
