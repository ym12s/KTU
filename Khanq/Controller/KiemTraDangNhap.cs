using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Windows.Forms;
using Khanq.Model;
namespace Khanq.Controller
{
    internal class KiemTraDangNhap
    {
        private SqlConnection conn;
        public KiemTraDangNhap()
        {
            conn = KetNoiSQL.GetConnection();
        }
        public bool kiemtraUser(string username, string password)
        {
            try
            {
                    string query = "SELECT COUNT(*) FROM tbUser WHERE Username=@username AND Password=@password";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("username", username);
                    command.Parameters.AddWithValue("password", password);
                    int kq = (int)command.ExecuteScalar();
                    return kq > 0;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }   
    }
}
