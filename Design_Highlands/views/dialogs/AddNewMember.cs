using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
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
    public partial class AddNewMember : Form
    {
        DataGridView membersGridView;
        public AddNewMember()
        {
            InitializeComponent();
        }

        public AddNewMember(DataGridView membersGridView)
        {
            InitializeComponent();
            this.membersGridView = membersGridView;
        }

        // Event Handlers
        private async void createMember(BsonDocument document, IMongoCollection<BsonDocument> collection)
        {
            if (document != null)
            {
                await collection.InsertOneAsync(document);
                MessageBox.Show("Create new member successfully!", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                this.Hide();

            }
            else
            {
                MessageBox.Show("Failed to create new staff. Please try again!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                this.Hide();
            }
        }

        private Member findMemberById(string memberId, IMongoCollection<BsonDocument> collection)
        {
            List<BsonDocument> results = collection.Find(new BsonDocument()).ToList();
            foreach (BsonDocument result in results)
            {
                if (result.ContainsValue(memberId))
                {
                    Member member = BsonSerializer.Deserialize<Member>(result);
                    return member;
                }
            }
            return null;
        }

        private Boolean isDataValid()
        {
            char[] charsToTrim = { '*', ' ', '\'' };

            return txt_nameMem.Text.Trim(charsToTrim) != ""
                && txt_phoneMem.Text.Trim(charsToTrim) != ""
                && txt_addressMem.Text.Trim(charsToTrim) != ""
                && txt_birthYearMem.Text.Trim(charsToTrim) != ""
                && (rdbtn_femaleMem.Checked || rdbtn_maleMem.Checked);
        }

        // Events
        private void btn_confirmCreateMember_Click(object sender, EventArgs e)
        {
            if (isDataValid())
            {
                // Connect to db
                var client = new MongoClient("mongodb+srv://52000797:tQ!mTK6NW74wexq@highlandcluster.fc5jjn4.mongodb.net");
                var db = client.GetDatabase("highland");
                IMongoCollection<BsonDocument> collection = db.GetCollection<BsonDocument>("members");

                // Create BsonDocument
                var genderVal = rdbtn_maleMem.Checked ? "male" : "female";
                var newMemberId = System.Guid.NewGuid().ToString();
                var document = new BsonDocument
                {
                    {"memberId",  newMemberId},
                    { "name", txt_nameMem.Text },
                    { "phone", txt_phoneMem.Text },
                    { "birthYear", txt_birthYearMem.Text },
                    { "rank", "" },
                    { "gender", genderVal },
                    { "address", txt_addressMem.Text }
                };


                // write staff to database
                createMember(document, collection);
                Member member = findMemberById(newMemberId, collection);
                if (member != null)
                {
                    // Update grid view 

                    DataTable dataTable = (DataTable)membersGridView.DataSource;
                    DataRow newRow = dataTable.NewRow();

                    newRow["Id"] = member.Id;
                    newRow["Member Id"] = member.memberId;
                    newRow["Name"] = member.name;
                    newRow["Phone"] = member.phone;
                    newRow["Birth Year"] = member.birthYear;
                    newRow["Gender"] = genderVal;
                    newRow["Address"] = member.address;
                    newRow["Rank"] = member.rank;

                    dataTable.Rows.Add(newRow);
                    dataTable.AcceptChanges();
                }
                else
                {
                    MessageBox.Show("Something went wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }



            }
            else
            {
                MessageBox.Show("You have missed some info", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
