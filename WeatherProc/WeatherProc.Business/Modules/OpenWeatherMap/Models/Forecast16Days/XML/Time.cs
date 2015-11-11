using System;
using System.Xml.Serialization;

namespace WeatherProc.Business.Modules.OpenWeatherMap.Models.Forecast16Days.XML
{
    [Serializable]
    public class Time
    {
        [XmlAttribute("day")]
        public DateTime Day { get; set; }

        [XmlElement("symbol")]
        public TimeSymbol Symbol { get; set; }

        [XmlElement("precipitation")]
        public TimePrecipitation Precipititation { get; set; }

        [XmlElement("windDirection")]
        public TimeWindDirection WindDirection { get; set; }

        [XmlElement("windSpeed")]
        public TimeWindSpeed WindSpeed { get; set; }

        [XmlElement("temperature")]
        public TimeTemperature Temperature { get; set; }

        [XmlElement("pressure")]
        public TimePressure Pressure { get; set; }

        [XmlElement("humidity")]
        public TimeHumidity Humidity { get; set; }

        [XmlElement("clouds")]
        public TimeClouds Clouds { get; set; }
    }
}
