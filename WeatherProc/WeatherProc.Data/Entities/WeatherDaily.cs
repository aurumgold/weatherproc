namespace WeatherProc.Data.Entities
{
    public class WeatherDaily : WeatherHourly
    {
        public WeatherDaily()
            : base()
        {
            TemperatureNight = new Temperature();
            TemperatureDay = new Temperature();
            TemperatureMorning = new Temperature();
            TemperatureEvening = new Temperature();
        }

        public Temperature TemperatureNight { get; set; }
        public Temperature TemperatureMorning { get; set; }
        public Temperature TemperatureDay { get; set; }
        public Temperature TemperatureEvening { get; set; }
    }
}
