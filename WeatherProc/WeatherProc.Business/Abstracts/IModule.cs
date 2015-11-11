using System;
using System.Collections.Generic;
using WeatherProc.Data.Entities;

namespace WeatherProc.Business.Abstracts
{
    public interface IModule
    {
        LocationData Location { get; }
        Weather CurrentWeather { get; }
        List<WeatherHourly> FiveDays { get; }
        List<WeatherDaily> TwoWeeks { get; }

        void Initialize();
    }
}
