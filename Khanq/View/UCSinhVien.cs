using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Khanq.Controller;
using Khanq.Model;
namespace Khanq.View
{
    public partial class UCSinhVien : Form
    {
        HienThongTinSinhVien hienThongTinSinhVien = new HienThongTinSinhVien();
        public UCSinhVien()
        {
            InitializeComponent();
            txtBox2.Multiline = true;
            this.Location = new System.Drawing.Point(245, 285);
        }

        private void khangTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNhap.Text))
            {
                txtNhap.PlaceholderText = "VD: 22D1.....";
            }

        }

        private void UCSinhVien_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string mssv = txtNhap.Text.Trim();
            if (string.IsNullOrEmpty(txtNhap.Text))
            {
                txtNhap.BorderColor = Color.Red;
            }else
            {
                User user = hienThongTinSinhVien.Get(mssv);
                if (user != null)
                {

                    txtBox2.Text = $"UID: {user.Uid} \n MSSV: {user.Mssv} \n Username: {user.Username}" +
                        $" Password: {user.Password}\n Email: {user.Email}";
                }

            }
        }
    }
}
