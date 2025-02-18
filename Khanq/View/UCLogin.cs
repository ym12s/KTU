using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using Khanq.Controller;
namespace Khanq.View
{
    public partial class UCLogin : Form
    {
        private KiemTraDangNhap ktDangNhap = new KiemTraDangNhap();
        public UCLogin()
        {
            InitializeComponent();
        }
        private void btnNo_Click(object sender, EventArgs e)
        {
           System.Windows.Forms.Application.Exit(); 
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtUsers.Text) && String.IsNullOrEmpty(txtPass.Text))
            {
                txtUsers.PlaceholderForeColor = Color.Red;

                txtPass.PlaceholderForeColor = Color.Red;
            }
            else if (String.IsNullOrEmpty(txtUsers.Text))
            {
                txtUsers.PlaceholderForeColor = Color.Red;
            }
            else if (String.IsNullOrEmpty(txtPass.Text))
            {
                txtPass.PlaceholderForeColor = Color.Red;
            }
            else
            {
                string username = txtUsers.Text;
                string password = txtPass.Text;

             if (ktDangNhap.kiemtraUser(username, password))
                {
                   DialogResult result =
                   MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                }
                else
                {
                   MessageBox.Show($"Sai tên đăng nhập hoặc mật khẩu ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
