namespace WeatherProc.Data.Entities
{
    public class Temperature
    {
        private double kelvin;

        public Temperature()
        { }

        public Temperature(double kelvin)
        {
            this.kelvin = kelvin;
        }

        public double Kelvin
        {
            get { return kelvin; }
            set { kelvin = value; }
        }

        public double Fahrenheit
        {
            get { return kelvin * 9 / 5 - 459.67; }
        }

        public double Celsius
        {
            get { return (kelvin - 273.15); }
        }

        public static Temperature operator  +(Temperature t1, Temperature t2)
        {
            return new Temperature(t1.kelvin + t2.kelvin);
        }

        public static Temperature operator /(Temperature t1, double t2)
        {
            return new Temperature(t1.kelvin / t2);
        }

    }
}
