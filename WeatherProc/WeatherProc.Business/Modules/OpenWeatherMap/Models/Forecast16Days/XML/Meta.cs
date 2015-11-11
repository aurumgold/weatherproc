﻿using System;
using System.Xml.Serialization;

namespace WeatherProc.Business.Modules.OpenWeatherMap.Models.Forecast16Days.XML
{
    [Serializable]
    public class Meta
    {
        [XmlElement("calctime")]
        public double CalculationTime { get; set; }
    }
}
