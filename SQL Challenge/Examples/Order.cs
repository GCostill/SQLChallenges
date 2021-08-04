using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Challenge.Examples
{
    class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int OrderStatus { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public int StoreId { get; set; }
        public int StaffId { get; set; }
        //anytime you see "Id", you want to think to create a new class for it.
    }
}
