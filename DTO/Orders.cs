    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCK.DTO
{
    class Orders
    {
        public int OrderID { get; set; }
	    public float GrandTotal { get; set; }
        public string   Description { get; set; }
    }
}
