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
    internal partial class Home : Form
    {
        Staff staff;

        public Home()
        {
            InitializeComponent();

        }
        public Home(Staff staff)
        {
            InitializeComponent();
            this.staff = staff;

        }

        private Boolean higherAuthorize(Staff staff)
        {
            return staff.role == "Admin";
        }

        private void logOut()
        {
            DialogResult result = MessageBox.Show("Do you want to log out?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            switch(result)
            {
                case DialogResult.Cancel:
                    break;
                case DialogResult.No:
                    break;
                case DialogResult.Yes:
                    backToLogin();
                    break;
                default:
                    break;
            }
        }

        private void backToLogin()
        {
            this.Hide();
            Login loginView = new Login();
            loginView.ShowDialog();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            logOut();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            logOut();

        }

        private void pic_satff_Click(object sender, EventArgs e)
        {
            if(higherAuthorize(this.staff))
            {
                this.Hide();
                QLNV staffManagementView = new QLNV();
                staffManagementView.ShowDialog();        
             } else
            {
                MessageBox.Show("You don't have permission to access this field!", "Authorization", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
