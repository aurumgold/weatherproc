namespace WeatherProc.Data.Entities
{
    public class WeatherHourly : Weather
    {
        public WeatherHourly()
            : base()
        {
            TemperatureMin = new Temperature();
            TemperatureMax = new Temperature();
        }

        public Temperature TemperatureMin { get; set; }
        public Temperature TemperatureMax { get; set; }
    }
}
