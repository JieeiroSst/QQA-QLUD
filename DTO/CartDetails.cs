using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCK.DTO
{
    class CartDetails
    {
        public int  ProductID { get; set; }
        public int CartID { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
    }
}
