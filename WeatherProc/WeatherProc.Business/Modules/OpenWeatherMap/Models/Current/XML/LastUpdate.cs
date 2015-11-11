using System;
using System.Xml.Serialization;

namespace WeatherProc.Business.Modules.OpenWeatherMap.Models.Current.XML
{
    [Serializable]
    public class LastUpdate
    {
        [XmlAttribute("value")]
        public DateTime Value { get; set; }
    }
}
