using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCK.DTO
{
    class RoleForm
    {
        public int RoleFormID { get; set; }
	    public int RoleId { get; set; }
        public int FormId { get; set; }
        public bool Access { get; set; }
        public bool _Insert { get; set; }
        public bool _Delete { get; set; }
        public bool _Update { get; set; }
        public bool _Print { get; set; }
        public bool Import { get; set; }
        public bool Export { get; set; }
    }
}
