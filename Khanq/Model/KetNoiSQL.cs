using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Khanq.Model
{
    internal class KetNoiSQL
    {
        private static SqlConnection sqlconn;
        private static string chuoiketnoi = "Server=DESKTOP-9DCLD5S;Database=QLCTXH;User Id=sa;Password=demo123;TrustServerCertificate=True;";

        static KetNoiSQL()
        {
            sqlconn = new SqlConnection(chuoiketnoi);
        }
        public static SqlConnection GetConnection()
        {
            return sqlconn;
        }
        public void OpenSQL()
        {
            if (sqlconn.State == ConnectionState.Closed)
            {
                sqlconn.Open();
            }
        }
        public void CloseSQl()
        {
            if (sqlconn.State == ConnectionState.Open)
            {
                sqlconn.Close();
            }
    }
    }
}

