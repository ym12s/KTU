using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Khanq.Model;
namespace Khanq.Controller
{
    internal class KiemTraDangNhap
    {
        private Model.ketnoiSQL knsql;

        public KiemTraDangNhap()
        {
            knsql = new ketnoiSQL();
            knsql.OpenSQL();
        }
        public bool kiemtraUser(string username, string password)
        {
            try
            {
                 SqlConnection connection = knsql.GetConnection();
                string query = "SELECT COUNT(*) FROM tbUser WHERE Username=@username AND Password=@password";
                    SqlCommand command = new SqlCommand(query, connection);
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
