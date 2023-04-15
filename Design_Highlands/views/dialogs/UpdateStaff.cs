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
using MongoDB.Bson;

namespace Design_Highlands
{
    internal partial class UpdateStaff : Form
    {
        Staff staff;
        DataGridView staffsGridView;
        public UpdateStaff()
        {
            InitializeComponent();
        }

        public UpdateStaff(Staff staff, DataGridView staffsGridView)
        {
            InitializeComponent();
            this.staff = staff;
            this.staffsGridView = staffsGridView;
        }

        private void UpdateStaff_Load(object sender, EventArgs e)
        {
            txt_updateNameStaff.Text = staff.name;
            txt_updateBirthYearStaff.Text = staff.birthYear;
            txt_updateIdentityStaff.Text = staff.identity;
            txt_updateAddressStaff.Text = staff.address;
            txt_updatePhone.Text = staff.phone;
            txt_updateRoleStaff.Text = staff.role;
            txt_updatePasswordStaff.Text = staff.password;

        }

        private void btn_cancelUpdateStaff_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_confirmUpdateStaff_Click(object sender, EventArgs e)
        {

            // Update databse
            var client = new MongoClient("mongodb+srv://52000797:tQ!mTK6NW74wexq@highlandcluster.fc5jjn4.mongodb.net");
            var db = client.GetDatabase("highland");
            IMongoCollection<BsonDocument> collection  = db.GetCollection<BsonDocument>("staffs");

            var filter = Builders<BsonDocument>.Filter.Eq("identity", txt_updateIdentityStaff.Text);
            var update = Builders<BsonDocument>.Update.Set("name", txt_updateNameStaff.Text).Set("birthYear", txt_updateBirthYearStaff.Text).Set("phone", txt_updatePhone.Text).Set("identity", txt_updateIdentityStaff.Text).Set("password", txt_updatePasswordStaff.Text).Set("role", txt_updateRoleStaff.Text).Set("address", txt_updateAddressStaff.Text);


            UpdateResult result = collection.UpdateOne(filter, update);
            
            if(result.IsAcknowledged)
            {
                // Update grid view
                int rowIndex = staffsGridView.CurrentCell.RowIndex;
                DataGridViewRow selectedRow = staffsGridView.Rows[rowIndex];

                selectedRow.Cells[2].Value = txt_updateNameStaff.Text;
                selectedRow.Cells[3].Value = txt_updatePhone.Text;
                selectedRow.Cells[4].Value = txt_updateIdentityStaff.Text;
                selectedRow.Cells[5].Value = txt_updateAddressStaff.Text;
                selectedRow.Cells[6].Value = txt_updateBirthYearStaff.Text;
                selectedRow.Cells[7].Value = txt_updateRoleStaff.Text;
                selectedRow.Cells[9].Value = txt_updatePasswordStaff.Text;

                DialogResult dialogResult = MessageBox.Show("Updated info successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                switch(dialogResult)
                {
                    case DialogResult.OK:
                        this.Hide();
                        break;
                    default:
                        break;
                }
                
            } else
            {
                MessageBox.Show("Failed to update. There is something wrong happened", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

            }

            

        }
    }
}
