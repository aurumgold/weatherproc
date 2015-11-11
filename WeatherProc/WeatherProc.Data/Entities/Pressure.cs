namespace WeatherProc.Data.Entities
{
    public class Pressure
    {
        private double mmHg;

        public double MmHg
        {
            get { return mmHg; }
            set { mmHg = value; }
        }

        public double hPa
        {
            get { return mmHg * 1.33322; }
            set { mmHg = value / 1.33322; }
        }

        public double Bar
        {
            get { return mmHg / 750.06; }
            set { mmHg = value * 750.06; }
        }

        public double Atm
        {
            get { return mmHg / 760; }
            set { mmHg = value * 760; }
        }
    }
}
