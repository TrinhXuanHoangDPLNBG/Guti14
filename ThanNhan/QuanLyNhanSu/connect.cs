using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu
{
    class connect
    {
        public static string chuoiketnoi = @"Data Source=GUTI14;Initial Catalog=QL_NHANSU;Integrated Security=True";
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataAdapter da;
        public static void openketnoi()
        {
            con = new SqlConnection(chuoiketnoi);
            con.Open();
        }
        public static void dongketnoi()
        {
            con.Close();
        }
        // phuong thuc get
        public static DataTable gettable(string sql)
        {
            cmd = new SqlCommand(sql, con);
            da = new SqlDataAdapter(cmd);
            DataTable db = new DataTable();
            da.Fill(db);
            return db;
        }
        public static void executeQuery(string sql)
        {
            cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
        }
    }
}
