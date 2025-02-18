using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Khanq.Model
{
    internal class LayThongTinSinhVien
    {
        KetNoiSQL ketnoiSQl = new KetNoiSQL();
        
        public User ThongTinSinhVien(string mssv)
        {
            try
            {
                ketnoiSQl.OpenSQL();
                SqlConnection conn = KetNoiSQL.GetConnection();
                string query = "SELECT * FROM tbUser Where MSSV = @mssv";
                SqlCommand command = new SqlCommand(query,conn);
                command.Parameters.AddWithValue("@mssv", mssv);

                SqlDataReader reader = command.ExecuteReader();
                
                if (reader.HasRows)
                {
                    reader.Read();
                    User user = new User
                    {
                     Uid = reader["UserID"].ToString(),
                     Mssv = reader["MSSV"].ToString(),
                     Username = reader["Username"].ToString(),
                     Password = reader["Password"].ToString(),
                     Email = reader["Email"].ToString(),
                    };
                    reader.Close();
                    return user;
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
            finally
            {
                ketnoiSQl.CloseSQl();
            }
            return null;
        }
    }
}
