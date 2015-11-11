using System.Collections.Generic;
using System.Linq;
using System.IO;
using WeatherProc.Data.Enums;
using WeatherProc.Data.Entities;
using WeatherProc.Business.Abstracts;
using WeatherProc.Business.Enums;
using WeatherProc.Business.Modules.OpenWeatherMap.Deserializers;
using WeatherProc.Business.Modules.OpenWeatherMap.Models;
using WeatherProc.Business.Helpers;

namespace WeatherProc.Business.Modules
{
    public class OpenWeatherMapModule : IModule
    {
        private readonly JsonDeserializer _deserializer;
        private CurrentJsonModel _currentWeatherJson;
        private Forecast5DaysJsonModel _fc5WeatherJson;
        private Forecast16DaysJsonModel _fc16WeatherJson;

        public OpenWeatherMapModule()
        {
            _deserializer = new JsonDeserializer();
            _currentWeatherJson = new CurrentJsonModel();
            _fc5WeatherJson = new Forecast5DaysJsonModel();
            _fc16WeatherJson = new Forecast16DaysJsonModel();

            Location = new LocationData();
            CurrentWeather = new Weather();
            FiveDays = new List<WeatherHourly>();
            TwoWeeks = new List<WeatherDaily>();
        }

        public LocationData Location { get; private set; }
        public Weather CurrentWeather { get; private set; }
        public List<WeatherHourly> FiveDays { get; private set; }
        public List<WeatherDaily> TwoWeeks { get; private set; } 

        public void Initialize()
        {
            LoadFromFiles();
            InitLocation();
            InitCurrentWeather();
            InitForecast5Days();
            InitForecast16Days();
        }

        private void LoadFromFiles()
        {
            using (StreamReader file = File.OpenText(@"C:\Users\Fishman\Desktop\C#\WeatherProc\Inputs\OpenWeatherMap\json\cur.weather.json"))
            {
                _currentWeatherJson = _deserializer.JsonToObject(file, ModelType.Current) as CurrentJsonModel;
                file.Close();
            }

            using (StreamReader file = File.OpenText(@"C:\Users\Fishman\Desktop\C#\WeatherProc\Inputs\OpenWeatherMap\json\fc5.weather.json"))
            {
                _fc5WeatherJson = _deserializer.JsonToObject(file, ModelType.Forecast5Days) as Forecast5DaysJsonModel;
                file.Close();
            }

            using (StreamReader file = File.OpenText(@"C:\Users\Fishman\Desktop\C#\WeatherProc\Inputs\OpenWeatherMap\json\fc16.weather.json"))
            {
                _fc16WeatherJson = _deserializer.JsonToObject(file, ModelType.Forecast16Days) as Forecast16DaysJsonModel;
                file.Close();
            }
        }

        #region Intializations
        private void InitLocation()
        {
            Location.Location.Latitude = _currentWeatherJson.Coordinates.Latitude;
            Location.Location.Longitude = _currentWeatherJson.Coordinates.Longitude;

            Location.Sun.SunRise = _currentWeatherJson.SystemParametrs.Sunrise.UnixTimeStampToDateTime();
            Location.Sun.SunSet = _currentWeatherJson.SystemParametrs.Sunset.UnixTimeStampToDateTime();

            Location.Country = CountryHelper.FindCountryByAlpha2(_currentWeatherJson.SystemParametrs.Country);

            Location.City = _currentWeatherJson.Name;
        }

        private void InitCurrentWeather()
        {
            CurrentWeather.Clouds.Value = _currentWeatherJson.Clouds.All;
            CurrentWeather.Date = _currentWeatherJson.DateStamp.UnixTimeStampToDateTime();
            CurrentWeather.Humidity.Value = _currentWeatherJson.Main.Humidity;
            CurrentWeather.Temperature.Kelvin = _currentWeatherJson.Main.Temperature;
            CurrentWeather.Pressure.hPa = _currentWeatherJson.Main.Preasure;
            CurrentWeather.Wind.Degrees = _currentWeatherJson.Wind.Degrees;
            CurrentWeather.Wind.MetPerSec = _currentWeatherJson.Wind.Speed;
            CurrentWeather.Precipitation.Name = _currentWeatherJson.Weather.First().Description;

            if (_currentWeatherJson.Rain != null)
            {
                CurrentWeather.Precipitation.Value = _currentWeatherJson.Rain.VolumeLast3h;
                CurrentWeather.Precipitation.Type = (PrecipitationTypes)_currentWeatherJson.Weather.First().Id;
            }
            else if (_currentWeatherJson.Snow != null)
            {
                CurrentWeather.Precipitation.Value = _currentWeatherJson.Snow.VolumeLast3h;
                CurrentWeather.Precipitation.Type = (PrecipitationTypes)_currentWeatherJson.Weather.First().Id;
            }
                
        }

        private void InitForecast5Days()
        {
            foreach (var hourly in _fc5WeatherJson.Forecast)
            {
                FiveDays.Add(new WeatherHourly
                {
                    Clouds = new Clouds
                    {
                        Value = hourly.Clouds.All
                    },
                    Date = hourly.DateTxt,
                    Humidity = new Humidity
                    {
                        Value = hourly.Main.Humidity
                    },
                    Pressure = new Pressure
                    {
                        hPa = hourly.Main.Preassure
                    },
                    Temperature = new Temperature
                    {
                        Kelvin = hourly.Main.Temperature
                    },
                    TemperatureMin = new Temperature
                    {
                        Kelvin = hourly.Main.TemperatureMin
                    },
                    TemperatureMax = new Temperature
                    {
                        Kelvin = hourly.Main.TemperatureMax
                    },
                    Wind = new Wind
                    {
                        Degrees = hourly.Wind.Degrees,
                        MetPerSec = hourly.Wind.Speed
                    },
                    Precipitation = new Precipitation
                    {
                        Name = hourly.Weather.First().Description,

                        Type = (hourly.Rain != null || hourly.Snow != null) 
                            ? (PrecipitationTypes)hourly.Weather.First().Id 
                            : PrecipitationTypes.No,

                        Value = hourly.Rain != null
                            ? hourly.Rain.VolumeLast3h
                            : hourly.Snow != null
                                ? hourly.Snow.VolumeLast3h
                                : 0
                    }
                });
            }
        }

        private void InitForecast16Days()
        {
            var twoWeeks = _fc16WeatherJson.Forecast
                .Where(t => t.DateTime.UnixTimeStampToDateTime().Day != CurrentWeather.Date.Day)
                .Take(14);

            foreach (var daily in twoWeeks)
            {
                TwoWeeks.Add(new WeatherDaily
                {
                    Clouds = new Clouds
                    {
                        Value = daily.Clouds
                    },
                    Date = daily.DateTime.UnixTimeStampToDateTime(),
                    Humidity = new Humidity
                    {
                        Value = daily.Humidity
                    },
                    Pressure = new Pressure
                    {
                        hPa = daily.Pressure
                    },
                    Temperature = new Temperature
                    {
                        Kelvin = (daily.Temperature.Min + daily.Temperature.Max) / 2
                    },
                    TemperatureMax = new Temperature
                    {
                        Kelvin = daily.Temperature.Max
                    },
                    TemperatureMin = new Temperature
                    {
                        Kelvin = daily.Temperature.Min
                    },
                    TemperatureNight = new Temperature
                    {
                        Kelvin = daily.Temperature.Night
                    },
                    TemperatureMorning = new Temperature
                    {
                        Kelvin = daily.Temperature.Morning
                    },
                    TemperatureDay = new Temperature
                    {
                        Kelvin = daily.Temperature.Day
                    },
                    TemperatureEvening = new Temperature
                    {
                        Kelvin = daily.Temperature.Evening
                    },
                    Wind = new Wind
                    {
                        Degrees = daily.WindDegrees,
                        MetPerSec = daily.WindSpeed
                    },
                    Precipitation = new Precipitation
                    {
                        Name = daily.Weather.First().Description,

                        Type = ((int)daily.Rain != 0 || (int)daily.Snow != 0)
                            ? (PrecipitationTypes)daily.Weather.First().Id
                            : PrecipitationTypes.No,

                        Value = (int)daily.Rain != 0
                            ? daily.Rain
                            : (int)daily.Snow != 0
                                ? daily.Snow
                                : 0
                    }
                });
            }
        }
        #endregion
    }
}
