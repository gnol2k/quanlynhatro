using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_Lý_Nhà_Trọ
{
    class Database
    {
        SqlConnection sqlConn;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand lenh = new SqlCommand();
        public Database()
        {
            string strCnn = " Data Source=DESKTOP-QEN4LJI\\SQLEXPRESS; Database=QLNHATRO; Intergrated Security = True";
            sqlConn = new SqlConnection(strCnn);
 
        }

        internal DataTable exectequery(string strsql)
        {
            throw new NotImplementedException();
        }

        public DataTable Execute(string sqlStr)
        {
            da = new SqlDataAdapter(sqlStr, sqlConn);
            ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
        
        public void ExecuteNonQuery(string strSQL)
        {
            SqlCommand sqlcmd = new SqlCommand(strSQL, sqlConn);
            sqlConn.Open();
            sqlcmd.ExecuteNonQuery();
            sqlConn.Close();
        }

    }

}
