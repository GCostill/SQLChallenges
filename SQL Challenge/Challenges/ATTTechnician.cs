using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Challenge.Challenges
{
    class ATTTechnician
    {
        public string TechnicianId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float CustomerRating { get; set; }
        public string VehicleId { get; set; }
        public ATTVehicle Vehicle { get; set; }
    }
}
