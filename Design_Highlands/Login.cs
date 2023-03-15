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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        //Set Placeholder text in textboxs "username"
        private void txt_username_Enter_1(object sender, EventArgs e)
        {
            if (txt_username.Text == "Tên đăng nhập")
            {
                txt_username.Text = "";
                txt_username.ForeColor = Color.Black;
            }
        }
        //Set Placeholder text in textboxs "username"
        private void txt_username_Leave(object sender, EventArgs e)
        {
            if (txt_username.Text == "")
            {
                txt_username.Text = "Tên đăng nhập";
                txt_username.ForeColor = Color.Gray;
            }
        }

        //Set Placeholder text in textboxs "password"
        private void txt_password_Enter(object sender, EventArgs e)
        {
            if (txt_password.Text == "Mật khẩu")
            {
                txt_password.Text = "";
                txt_password.ForeColor = Color.Black;
            
            }
        }
        //Set Placeholder text in textboxs "password"
        private void txt_password_Leave(object sender, EventArgs e)
        {
            if (txt_password.Text == "")
            {
                txt_password.Text = "Mật khẩu";
                txt_password.ForeColor = Color.Gray;
            }
        }


    }

}
