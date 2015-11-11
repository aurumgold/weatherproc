using System;
using System.Xml.Serialization;

namespace WeatherProc.Business.Modules.OpenWeatherMap.Models.Forecast5Days.XML
{
    [Serializable]
    public class TimeHumidity
    {
        [XmlAttribute("value")]
        public int Value { get; set; }

        [XmlAttribute("unit")]
        public string Unit { get; set; }
    }
}
