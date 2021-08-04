using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Challenge.Challenges
{
    class ATTVehicle
    {
        public string VehicleId { get; set; }
        public string LicensePlate { get; set; }
        public string VIN { get; set; }
        public float Miles { get; set; }
        public ATTTechnician Technician { get; set; }
    }
}
