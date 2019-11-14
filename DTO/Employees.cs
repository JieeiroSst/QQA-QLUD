using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCK.DTO
{
    class Employees
    {
        public int EmployeeID { get; set; }
	    public string Name { get; set; }
        public string   Address { get; set; }
        public string   Phone { get; set; }
        public int   RoleID { get; set; }
        public int   UserId { get; set; }
    }
}
