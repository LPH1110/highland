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
using MongoDB.Bson.Serialization;

namespace Design_Highlands
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }



        private Staff validateCredentials(String username, String password)
        {
            var client = new MongoClient("mongodb+srv://52000797:tQ!mTK6NW74wexq@highlandcluster.fc5jjn4.mongodb.net");
            var db = client.GetDatabase("highland");
            IMongoCollection<BsonDocument> listCollection = db.GetCollection<BsonDocument>("staffs");
            List<BsonDocument> results = listCollection.Find(new BsonDocument()).ToList();
            foreach (BsonDocument result in results)
            {
                if (result.ContainsValue(username) && result.ContainsValue(password))
                {
                    Staff staff = BsonSerializer.Deserialize<Staff>(result);
                    return staff;
                }
            }
            return null;
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

        private void login()
        {
            // Check empty
            if (txt_username.Text == "" || txt_password.Text == "")
            {
                MessageBox.Show("You have missed your credentials!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate
            Staff staff = validateCredentials(txt_username.Text, txt_password.Text);
            if (staff != null)
            {
                MessageBox.Show("Login successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Home homeview = new Home(staff);
                homeview.ShowDialog();
            }
            else
            {
                MessageBox.Show("Login failed. Please check your credentials again.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
           
            login();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txt_username.Focus();
            txt_username.Text = "admin";
            txt_password.Text = "11102002";
        }

        private void btn_cancelLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }

}
