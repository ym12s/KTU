using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Khanq.View
{
    public partial class @null : Form
    {
        public @null()
        {
            InitializeComponent();
            View.UCLogin uCLogin = new UCLogin();
            uCLogin.Show();
            this.Hide();
        }
    }
}
