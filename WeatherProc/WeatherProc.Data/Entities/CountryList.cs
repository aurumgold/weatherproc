using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace WeatherProc.Data.Entities
{
    [Serializable]
    [XmlRoot("countries")]
    public class CountryList
    {
        [XmlArray("country-list")]
        [XmlArrayItem("country", typeof(Country))]
        public List<Country> Countries { get; set; }
    }
}
