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
using MongoDB.Bson.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Design_Highlands
{
    public partial class AddNewStaff : Form
    {
        DataGridView staffsGridView;
        DataTable table;
        public AddNewStaff()
        {
            InitializeComponent();
        }

        public AddNewStaff(DataGridView staffsGridView, DataTable table)
        {
            InitializeComponent();
            this.staffsGridView = staffsGridView;
            this.table = table;
        }

        private async void createStaff(BsonDocument document, IMongoCollection<BsonDocument> collection)
        {
            if (document != null)
            {
                await collection.InsertOneAsync(document);
                MessageBox.Show("Create new staff successfully!", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                this.Hide();

            }
            else
            {
                MessageBox.Show("Failed to create new staff. Please try again!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                this.Hide();
            }
        }

        private Staff findStaffByIdentity(string identity, IMongoCollection<BsonDocument> collection)
        {
            List<BsonDocument> results = collection.Find(new BsonDocument()).ToList();
            foreach (BsonDocument result in results)
            {
                if (result.ContainsValue(identity))
                {
                    Staff staff = BsonSerializer.Deserialize<Staff>(result);
                    return staff;
                }
            }
            return null;
        }

        private Boolean isDataValid()
        {
            char[] charsToTrim = { '*', ' ', '\'' };

            return txt_nameStaff.Text.Trim(charsToTrim) != ""
                && txt_phoneStaff.Text.Trim(charsToTrim) != ""
                && txt_addressStaff.Text.Trim(charsToTrim) != ""
                && txt_birthYearStaff.Text.Trim(charsToTrim) != ""
                && txt_identityStaff.Text.Trim(charsToTrim) != ""
                && txt_passwordStaff.Text.Trim(charsToTrim) != ""
                && txt_roleStaff.Text.Trim(charsToTrim) != "";
        }

        private void btn_confirmCreateStaff_Click(object sender, EventArgs e)
        {
            if (isDataValid())
            {
                // Connect to db
                var client = new MongoClient("mongodb+srv://52000797:tQ!mTK6NW74wexq@highlandcluster.fc5jjn4.mongodb.net");
                var db = client.GetDatabase("highland");
                IMongoCollection<BsonDocument> collection = db.GetCollection<BsonDocument>("staffs");

                // Create BsonDocument
                var document = new BsonDocument
                {
                    { "staffId", "" },
                    { "name", txt_nameStaff.Text },
                    { "phone", txt_phoneStaff.Text },
                    { "birthYear", txt_birthYearStaff.Text },
                    { "identity", txt_identityStaff.Text },
                    { "password", txt_passwordStaff.Text },
                    { "role", txt_roleStaff.Text },
                    { "address", txt_addressStaff.Text }
                };


                // write staff to database
                createStaff(document, collection);

                Staff staff = findStaffByIdentity(txt_identityStaff.Text, collection);
                if (staff != null)
                {
                    // Update grid view 

                    DataTable dataTable = (DataTable)staffsGridView.DataSource;
                    DataRow newRow = dataTable.NewRow();

                    newRow["Id"] = staff.Id;
                    newRow["Staff Id"] = staff.staffId;
                    newRow["Name"] = staff.name;
                    newRow["Phone"] = staff.phone;
                    newRow["Identity"] = staff.identity;
                    newRow["Address"] = staff.address;
                    newRow["Birth Year"] = staff.birthYear;
                    newRow["Role"] = staff.role;
                    newRow["Username"] = staff.username;
                    newRow["Password"] = staff.password;

                    dataTable.Rows.Add(newRow);
                    dataTable.AcceptChanges();
                } else
                {
                    MessageBox.Show("Something went wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }



            } else
            {
                MessageBox.Show("You have missed some info", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_cancelCreateStaff_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
