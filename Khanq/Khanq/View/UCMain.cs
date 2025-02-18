using System;
using System.Windows.Forms;
namespace Khanq.View
{
    public partial class UCMain : Form
    {
        public UCMain()
        {
            InitializeComponent();
         
         
        }

        private void UCMain_Load(object sender, EventArgs e)
        {
            View.UCLogin uCLogin = new UCLogin();
            uCLogin.Show();
        }
    }
}
