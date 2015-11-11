using System;
using System.Collections.Generic;
using System.Linq;
using WeatherProc.Data.Entities;
using WeatherProc.Data.Serializator;

namespace WeatherProc.Business.Helpers
{
    public static class CountryHelper
    {
        public static Country FindCountryByAlpha2(string alpha2)
        {
            Country country = new Country();
            using (CountrySerializer ser = new CountrySerializer(@"C:\Users\Fishman\Desktop\C#\WeatherProc\WeatherProc\WeatherProc.Data\XMLs\Countries.xml"))
            {
                var list = ser.Deserialize();
                country = list.Countries.FirstOrDefault(c => c.Alpha2 == alpha2);
            }
            return country;
        }
    }
}
