using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Khanq.Model
{

    internal class ketnoiSQL
    {
        private SqlConnection sqlconn;
        private string chuoiketnoi = "Server=DESKTOP-9DCLD5S;Database=QLCTXH;User Id=sa;Password=demo123;TrustServerCertificate=True;";
        
        public ketnoiSQL()
        {
            sqlconn = new SqlConnection(chuoiketnoi);
        }
        public SqlConnection GetConnection()
        {
           
            return sqlconn;
        }

        public void OpenSQL()
        {
            try
            {
                if (sqlconn.State == ConnectionState.Closed)
                {
                    sqlconn.Open();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Lỗi mở kết nối{e.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CloseSQL()
        {
            try
            {
                if (sqlconn.State == ConnectionState.Open)
                {
                    sqlconn.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Lỗi đóng kết nối{e.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
