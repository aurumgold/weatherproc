using System;
using System.Xml.Serialization;

namespace WeatherProc.Data.Entities
{
    [Serializable]
    public class Country
    {
        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("fullname")]
        public string FullName { get; set; }

        [XmlElement("english")]
        public string English { get; set; }

        [XmlElement("alpha2")]
        public string Alpha2 { get; set; }

        [XmlElement("alpha3")]
        public string Alpha3 { get; set; }

        [XmlElement("iso")]
        public string ISO { get; set; }

        [XmlElement("location")]
        public string Location { get; set; }

        [XmlElement("location-precise")]
        public string LocationPrecise { get; set; }
    }
}
