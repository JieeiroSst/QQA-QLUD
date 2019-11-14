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
    public class UserDAO:_User
    {
        public db db = new db();

        public DataTable GetAllData()
        {
            string sql = "Select * from [_User]";
            var rs = db.GetData(sql);

            return rs;
        }

        public int Update(_User user)
        {
            string sql = string.Format("update [_User] set  UserName ='{1}',Password ='{2}',RoleId={3} where UserID={0}",user.UserName,user.Password,user.RoleId,user.UserID);
            var rs = db.ExecuteSQL(sql);

            return rs;
        }
        public int DeleteById(int userId)
        {
            string sql = string.Format("Delete from [_User] Where UserID = {0}", userId);
            var rs = db.ExecuteSQL(sql);

            return rs;
        }

        public int Insert(_User user)
        {
            string sql = string.Format("insert into [_User](UserID,UserName,Password,RoleId ) values({0},'{1}','{2}',{3})",user.UserID,user.UserName,user.Password,user.RoleId);
            var rs = db.ExecuteSQL(sql);

            return rs;
        }
        public int UpdateByStore(_User user)
        {
            string sql= string.Format("update [_User] set  UserName ='{0}',Password ='{1}',RoleId={2} where UserID={3}", user.UserName, user.Password, user.RoleId, user.UserID);
            List<SqlParameter> lstParams = new List<SqlParameter>();
            lstParams.Add(new SqlParameter("@UserID", user.UserID));
            lstParams.Add(new SqlParameter("@UserName", user.UserName));
            lstParams.Add(new SqlParameter("@Password", user.Password));
            lstParams.Add(new SqlParameter("@RoleId", user.RoleId));

            var rs = db.ExecuteStore(sql, lstParams.ToArray());

            return rs;
        }

        public _User Login(string userName, string password)
        {
            string sql= string.Format("Select UserID, RoleId from [User] Where UserName='{0}' and Password='{1}'", userName, password);
            var tb = db.GetData(sql);
            if (tb != null && tb.Rows.Count > 0)
            {
                return new _User()
                {
                    UserID = int.Parse(tb.Rows[0]["UserID"].ToString()),
                    RoleId = int.Parse(tb.Rows[0]["RoleId"].ToString())
                };
            }
            else
                return null;
        }
    }
}
