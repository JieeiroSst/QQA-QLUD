using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCK.DTO
{
    class Carts
    {
        public int CartID { get; set; }
        public float Subtotal { get; set; }
        public float Vat { get; set; }
        public float Discount { get; set; }
        public DateTime CreatedDate { get; set; }
        public int EmployeeID { get; set; }
        public int CustomerID { get; set; }
        public string Description { get; set; }
    }
}
