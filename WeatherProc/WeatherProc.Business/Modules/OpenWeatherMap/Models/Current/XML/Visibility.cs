using System;
using System.Xml.Serialization;

namespace WeatherProc.Business.Modules.OpenWeatherMap.Models.Current.XML
{
    [Serializable]
    public class Visibility
    {
        [XmlAttribute("value")]
        public int Value { get; set; }
    }
}
