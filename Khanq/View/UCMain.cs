using System;
using System.Windows.Forms;
using Khanq.Model;
namespace Khanq.View
{
    public partial class UCMain : Form
    {
        public UCMain()
        {
            InitializeComponent();
            KetNoiSQL conn = new KetNoiSQL();
            VisiblePanel();
            PanelContainer.Dock = DockStyle.Right;

        }

        private void UCMain_Load(object sender, EventArgs e)
        {

        }
        private void VisiblePanel()
        {
            Panel1.Visible = false;
            khangPanel1.Visible = false;
            khangPanel2.Visible = false;
            khangPanel3.Visible = false;
        }
        private void MainMenu()
        {
           if (Panel1.Visible == true)
              Panel1.Visible = false;
           if (khangPanel1.Visible == true)
                khangPanel1.Visible = false;
           if (khangPanel2.Visible == true)
                khangPanel2.Visible = false;
           if (khangPanel3.Visible == true)
                khangPanel3.Visible = false;
        }
        private void hienMenu(Panel menuLeft)
        {
            if (menuLeft.Visible == false)
            {
                menuLeft.Visible= true;
            }else
            {
                menuLeft.Visible = false;
            }
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            hienMenu(Panel1);
        }

        private void khangButton2_Click(object sender, EventArgs e)
        {
            hienMenu(khangPanel1);
           
        }

        private void khangButton3_Click(object sender, EventArgs e)
        {
            hienMenu(khangPanel2);
        }

        private void khangButton20_Click(object sender, EventArgs e)
        {
            hienMenu(khangPanel3);
        }

        private void khangButton9_Click(object sender, EventArgs e)
        {
            UCSinhVien ucSinhVien = new UCSinhVien();
            ucSinhVien.Show();
        }
    }

        
    }

