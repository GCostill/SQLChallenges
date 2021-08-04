using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Challenge.Challenges
{
    class ZillowListing
    {
        public string ListingId { get; set; }
        public DateTime DateListed { get; set; }
        public bool IsRental { get; set; }
        public string HouseId { get; set; }
        public ZillowHouse House { get; set; }
    }
}
