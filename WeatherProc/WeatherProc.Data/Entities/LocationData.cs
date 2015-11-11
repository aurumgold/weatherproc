using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherProc.Data.Entities
{
    public class LocationData
    {
        public LocationData()
        {
            Country = new Country();
            Location = new Location();
            Sun = new Sun();
        }

        public string City { get; set; }
        public Country Country { get; set; }
        public Location Location { get; set; }
        public Sun Sun { get; set; }
    }
}
