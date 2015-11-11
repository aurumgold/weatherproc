using System;

namespace WeatherProc.Data.Entities
{
    public class Weather
    {
        public Weather()
        {
            Precipitation = new Precipitation();
            Wind = new Wind();
            Temperature = new Temperature();
            Pressure = new Pressure();
            Humidity = new Humidity();
            Clouds = new Clouds();
        }

        public DateTime Date { get; set; }
        public Precipitation Precipitation { get; set; }
        public Wind Wind { get; set; }
        public Temperature Temperature { get; set; }
        public Pressure Pressure { get; set; }
        public Humidity Humidity { get; set; }
        public Clouds Clouds { get; set; }       
    }
}
