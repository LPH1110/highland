using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;

namespace Design_Highlands
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private Boolean validateCredentials(String username, String password)
        {
            MongoClient client = new MongoClient("");
            return false;
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

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (validateCredentials(txt_username.Text, txt_password.Text))
            {
                MessageBox.Show("Login successfully");
            } else
            {
                MessageBox.Show("Login failed. Please check your credentials again.");
            }
        }
    }

}
