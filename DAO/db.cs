using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DoAnCK.DAO
{
    public class db
    {
        string connStr = "Data Source=DESKTOP-4GHOCG1\MSSQLSERVER02;Initial Catalog=ShopOnline;Integrated Security=True";
        public DataTable GetData(string sql)
        {
            SqlConnection sqlConnection = new SqlConnection(connStr);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public int ExecuteSQL(string sql)
        {
            SqlConnection sqlConnection = new SqlConnection(connStr);
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlConnection.Open();
            int rs = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return rs;
        }
        public int ExecuteStore(string sql, SqlParameter[] param)
        {
            SqlConnection sqlConnection = new SqlConnection(connStr);
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddRange(param);
            sqlConnection.Open();
            var affectedRows = sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            return affectedRows;
        }
    }
}
