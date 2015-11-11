using WeatherProc.Data.Enums;

namespace WeatherProc.Data.Entities
{
    public class Precipitation
    {
        public string Name { get; set; }
        public double Value { get; set; }
        public PrecipitationTypes Type { get; set; }
    }
}
