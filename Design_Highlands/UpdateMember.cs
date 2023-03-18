using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Highlands
{
    internal partial class UpdateMember : Form
    {
        Member member;
        DataGridView membersGridView;
        public UpdateMember()
        {
            InitializeComponent();
        }
        public UpdateMember(Member member, DataGridView membersGridView)
        {
            InitializeComponent();
            this.member = member;
            this.membersGridView = membersGridView;
        }


        // Events
        private void UpdateMember_Load(object sender, EventArgs e)
        {
            txt_updateNameMem.Text = member.name;
            txt_updatePhoneMem.Text = member.phone;
            txt_updateBirthYearMem.Text = member.birthYear;
            txt_updateAddressMem.Text = member.address;
            
            if (member.gender == "male")
            {
                rdbtn_updateMaleMem.Checked = true;
            } else
            {
                rdbtn_updateFemaleMem.Checked = true;
            }

        }

        private void btn_cancelMem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_confirmUpdateMem_Click(object sender, EventArgs e)
        {
            // Update databse
            var client = new MongoClient("mongodb+srv://52000797:tQ!mTK6NW74wexq@highlandcluster.fc5jjn4.mongodb.net");
            var db = client.GetDatabase("highland");
            IMongoCollection<BsonDocument> collection = db.GetCollection<BsonDocument>("members");

            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(member.Id));
            var genderValue = rdbtn_updateFemaleMem.Checked ? "female" : "male";
            var update = Builders<BsonDocument>.Update.Set("name", txt_updateNameMem.Text).Set("birthYear", txt_updateBirthYearMem.Text).Set("phone", txt_updatePhoneMem.Text).Set("address", txt_updateAddressMem.Text).Set("gender", genderValue);


            UpdateResult result = collection.UpdateOne(filter, update);

            if (result.IsAcknowledged)
            {
                // Update grid view
                int rowIndex = membersGridView.CurrentCell.RowIndex;
                DataGridViewRow selectedRow = membersGridView.Rows[rowIndex];

                selectedRow.Cells[1].Value = txt_updateNameMem.Text;
                selectedRow.Cells[2].Value = txt_updatePhoneMem.Text;
                selectedRow.Cells[3].Value = txt_updateBirthYearMem.Text;
                selectedRow.Cells[4].Value = genderValue;
                selectedRow.Cells[5].Value = txt_updateAddressMem.Text;

                DialogResult dialogResult = MessageBox.Show("Updated member's info successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                switch (dialogResult)
                {
                    case DialogResult.OK:
                        this.Hide();
                        break;
                    default:
                        break;
                }

            }
            else
            {
                MessageBox.Show("Failed to update. There is something wrong happened", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

            }
        }
    }
}
