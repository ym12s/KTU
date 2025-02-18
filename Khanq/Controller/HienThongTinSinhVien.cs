using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Khanq.Model;
namespace Khanq.Controller
{
    internal class HienThongTinSinhVien
    {
        LayThongTinSinhVien layThongTinSinhVien = new LayThongTinSinhVien();
        public User Get(string mssv)
        {
            User user = layThongTinSinhVien.ThongTinSinhVien(mssv);
            if (user == null)
            {
                MessageBox.Show($"Mã số {mssv} không tồn tại");
                return null;
            }
            return user;
        }
    }
}
