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
    internal partial class QLMenu: Form
    {
        Staff staff;
        public QLMenu()
        {
            InitializeComponent();
        }

        public QLMenu(Staff staff)
        {
            InitializeComponent();
            this.staff = staff;
        }

        private void lb_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home homeView = new Home(staff);
            homeView.ShowDialog();
        }

        private void kryptonDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
