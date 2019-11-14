using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DoAnCK.DTO;
namespace DoAnCK.DAO
{
    public class RoleFormDAO
    {
        public db db = new db();
        public DataTable GetAllData()
        {
            string sql = "Select * from [RoleForm]";
            var rs = db.GetData(sql);

            return rs;
        }

        public List<RoleForm> GetList(int roleId)
        {
            var rs = new List<RoleForm>();

            string sql= string.Format("Select * from RoleForm Where RoleId = {0}", roleId);
            var tb = db.GetData(sql);

            foreach (DataRow row in tb.Rows)
            {
                var roleForm = new RoleForm()
                {
                    RoleFormID = int.Parse(row["RoleFormID"].ToString()),
                    RoleId = int.Parse(row["RoleId"].ToString()),
                    FormId = int.Parse(row["FormId"].ToString()),
                    Access = bool.Parse(row["Access"].ToString()),
                    _Insert = bool.Parse(row["_Insert"].ToString()),
                    _Delete = bool.Parse(row["_Delete"].ToString()),
                    _Update = bool.Parse(row["_Update"].ToString()),
                    _Print = bool.Parse(row["_Print"].ToString()),
                    Import = bool.Parse(row["Import"].ToString()),
                    Export = bool.Parse(row["Export"].ToString()),
                };

                rs.Add(roleForm);
            }

            return rs;
        }

    }
}
