using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Highlands
{
    public partial class OrderScreen : Form
    {
        public OrderScreen()
        {
            InitializeComponent();
        }

        // Event handlers
        private void backToHome()
        {
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
        }


        // Events
        private void lb_back_Click(object sender, EventArgs e)
        {
            backToHome();
        }

        private void pb_back_Click(object sender, EventArgs e)
        {
            backToHome();
        }
    }
}
