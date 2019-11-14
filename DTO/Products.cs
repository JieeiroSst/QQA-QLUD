using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCK.DTO
{
    class Products
    {
        public int ProductID { get; set; }
        public string ProductName{ get; set; }
        public string QuantitysPerUnit { get; set; }
        public float Price { get; set; }
        public int UnitsInStock { get; set; }
        public int UnitsInOrder { get; set; }
        public string   Img { get; set; }
        public string   Description { get; set; }
        public int   CategoryID { get; set; }
        public int  SupplierID { get; set; }
        public string Phone { get; set; }
    }
}
