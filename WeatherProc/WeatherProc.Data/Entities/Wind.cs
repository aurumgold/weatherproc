using WeatherProc.Data.Enums;

namespace WeatherProc.Data.Entities
{
    public class Wind
    {
        private const double KNOT_COEFFICIENT = 1.943844492441;
        private const double KM_COEFFICIENT = 3.6;
        private const double MILE_COEFFICIENT = 2.236936292054;

        private double _windPower;
        private double _degrees;
        public WindDirection Direction { get; set; }
        public WindType Type { get; set; }

        public double Degrees
        {
            get { return _degrees; }
            set
            {
                _degrees = value;
                InitializeDirection();
            }
        }

        public double MetPerSec
        {
            get { return _windPower; }
            set
            {
                _windPower = value;
                InitializeType();
            }
        }

        public double KMetPerHour
        {
            get { return _windPower * KM_COEFFICIENT; }
            set { _windPower = value / KM_COEFFICIENT; }
        }

        public double MilePerHour
        {
            get { return _windPower * MILE_COEFFICIENT; }
            set { _windPower = value / MILE_COEFFICIENT; }
        }

        public double Knots
        {
            get { return _windPower * KNOT_COEFFICIENT; }
            set { _windPower = value / KNOT_COEFFICIENT; }
        }

        private void InitializeDirection()
        {
            if (_degrees > 348.75 || _degrees <= 11.25)
                Direction = WindDirection.North;
            else if (_degrees > 11.25 && _degrees <= 33.75)
                Direction = WindDirection.NorthNorthEast;
            else if (_degrees > 33.75 && _degrees <= 56.25)
                Direction = WindDirection.NorthEast;
            else if (_degrees > 56.25 && _degrees <= 78.75)
                Direction = WindDirection.EastNorthEast;
            else if (_degrees > 78.75 && _degrees <= 101.25)
                Direction = WindDirection.East;
            else if (_degrees > 101.25 && _degrees <= 123.75)
                Direction = WindDirection.EastSouthEast;
            else if (_degrees > 123.75 && _degrees <= 146.25)
                Direction = WindDirection.SouthEast;
            else if (_degrees > 146.25 && _degrees <= 168.75)
                Direction = WindDirection.SouthSouthEast;
            else if (_degrees > 168.75 && _degrees <= 191.25)
                Direction = WindDirection.South;
            else if (_degrees > 191.25 && _degrees <= 213.75)
                Direction = WindDirection.SouthSouthWest;
            else if (_degrees > 213.75 && _degrees <= 236.25)
                Direction = WindDirection.SouthWest;
            else if (_degrees > 236.25 && _degrees <= 258.75)
                Direction = WindDirection.WestSouthWest;
            else if (_degrees > 258.75 && _degrees <= 281.25)
                Direction = WindDirection.West;
            else if (_degrees > 281.25 && _degrees <= 303.75)
                Direction = WindDirection.WestNorthWest;
            else if (_degrees > 303.75 && _degrees <= 326.25)
                Direction = WindDirection.NorthWest;
            else if (_degrees > 326.25 && _degrees <= 348.75)
                Direction = WindDirection.NorthNorthWest;
        }

        private void InitializeType()
        {
            if (Knots < 1)
                Type = WindType.Calm;
            else if (Knots < 4)
                Type = WindType.LightAir;
            else if (Knots < 7)
                Type = WindType.LightBreeze;
            else if (Knots < 11)
                Type = WindType.GentleBreeze;
            else if (Knots < 17)
                Type = WindType.ModerateBreeze;
            else if (Knots < 22)
                Type = WindType.FreshBreeze;
            else if (Knots < 28)
                Type = WindType.StrongBreeze;
            else if (Knots < 34)
                Type = WindType.ModerateGale;
            else if (Knots < 41)
                Type = WindType.FreshGale;
            else if (Knots < 48)
                Type = WindType.StrongGale;
            else if (Knots < 56)
                Type = WindType.WholeGale;
            else if (Knots < 64)
                Type = WindType.Storm;
            else
                Type = WindType.Hurricane;
        }
    }
}
