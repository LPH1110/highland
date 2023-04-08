using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;

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
                    QLNV staffManagementView = new QLNV(this.staff);
                    staffManagementView.setStaff(null);
                    this.staff = null;
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

        private void showOrderScreen()
        {
            this.Hide();
            OrderScreen orderScreen = new OrderScreen();
            orderScreen.ShowDialog();
        }

        // Events

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
                QLNV staffsManagementView = new QLNV(this.staff);
                staffsManagementView.ShowDialog();        
             } else
            {
                MessageBox.Show("You don't have permission to access this field!", "Authorization", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pic_members_Click(object sender, EventArgs e)
        {
            if(higherAuthorize(this.staff))
            {
                this.Hide();
                QLTV membersManagermentView = new QLTV(this.staff);
                membersManagermentView.ShowDialog();

            } else
            {
                MessageBox.Show("You don't have permission to access this field!", "Authorization", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pic_menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            QLMenu menuManagementView = new QLMenu(staff);
            menuManagementView.ShowDialog();
        }

        private void pic_order_Click(object sender, EventArgs e)
        {
            showOrderScreen();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            showOrderScreen();
        }
    }
}
