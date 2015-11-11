using WeatherProc.Data.Enums;

namespace WeatherProc.Data.Entities
{
    public class Clouds
    {
        private int _value;

        public CloudType Cloudnes { get; set; }
        public int Value
        {
            get { return _value; }
            set
            {
                _value = value;
                InitializeCloudnes();
            }
        }

        private void InitializeCloudnes()
        {
            if (_value < 10)
                Cloudnes = CloudType.ClearSky;
            else if (_value <= 30)
                Cloudnes = CloudType.FewClouds;
            else if (_value <= 50)
                Cloudnes = CloudType.ScatteredClouds;
            else if (_value <= 85)
                Cloudnes = CloudType.BrokenClouds;
            else Cloudnes = CloudType.OvercastClouds;
        }
    }

    
}
