using System;
using System.Xml.Serialization;

namespace WeatherProc.Business.Modules.OpenWeatherMap.Models.Forecast5Days.XML
{
    [Serializable]
    public class TimeSymbol
    {
        [XmlAttribute("number")]
        public int Number { get; set; }

        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("var")]
        public string Var { get; set; }
    }
}
