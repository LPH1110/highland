using MongoDB.Bson.Serialization;
using MongoDB.Bson;
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
    internal partial class QLTV : Form
    {
        Staff staff;
        DataTable table;
        public QLTV()
        {
            InitializeComponent();
        }

        public QLTV(Staff staff)
        {
            InitializeComponent();
            this.staff = staff;
        }

        // Event Handlers

        private void showHomeView()
        {
            this.Hide();
            Home homeView = new Home(this.staff);
            homeView.ShowDialog();
        }

        private void loadMembers()
        {
            DataTable table = new DataTable();
            this.table = table;

            table.Columns.Add("Id", typeof(string));
            table.Columns.Add("Member Id",typeof(string));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Phone", typeof(string));
            table.Columns.Add("Birth Year", typeof(string));
            table.Columns.Add("Gender", typeof(string));
            table.Columns.Add("Address", typeof(string));
            table.Columns.Add("Rank", typeof(string));

            var client = new MongoClient("mongodb+srv://52000797:tQ!mTK6NW74wexq@highlandcluster.fc5jjn4.mongodb.net");
            var db = client.GetDatabase("highland");
            IMongoCollection<BsonDocument> collection = db.GetCollection<BsonDocument>("members");
            List<BsonDocument> results = collection.Find(new BsonDocument()).ToList();

            foreach (BsonDocument result in results)
            {
                Member member = BsonSerializer.Deserialize<Member>(result);
                table.Rows.Add(member.Id, member.memberId, member.name, member.phone, member.birthYear, member.gender, member.address, member.rank);
            }

            membersGridView.DataSource = table;
        }

        private void showUpdateMemberDialog(Member member)
        {
            UpdateMember updateMemberDialog = new UpdateMember(member, membersGridView);
            updateMemberDialog.ShowDialog();
        }

        private Member getCurrentSelectedMember()
        {
            int rowIndex = membersGridView.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = membersGridView.Rows[rowIndex];
            var member = new Member(
                id: selectedRow.Cells[0].Value.ToString(),
                memberId: selectedRow.Cells[1].Value.ToString(),
                name: selectedRow.Cells[2].Value.ToString(),
                phone: selectedRow.Cells[3].Value.ToString(),
                birthYear: selectedRow.Cells[4].Value.ToString(),
                gender: selectedRow.Cells[5].Value.ToString(),
                address: selectedRow.Cells[6].Value.ToString(),
                rank: selectedRow.Cells[7].Value.ToString()
               );
            return member;
        }

        private async void deleteMember(ObjectId id, IMongoCollection<BsonDocument> collection)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("_id", id);
            DeleteResult result = await collection.DeleteOneAsync(filter);
            if (result.IsAcknowledged)
            {
                MessageBox.Show("Deleted member successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to delete mem!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Events

        private void lb_back_Click(object sender, EventArgs e)
        {
            showHomeView();
        }

        private void pb_back_Click(object sender, EventArgs e)
        {
            showHomeView();
        }

        private void QLTV_Load(object sender, EventArgs e)
        {
            loadMembers();
        }

        private void membersGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedMember = getCurrentSelectedMember();
            showUpdateMemberDialog(selectedMember);
        }

        private void btn_updateMem_Click(object sender, EventArgs e)
        {
            if (membersGridView.SelectedRows.Count > 0)
            {
                var selectedMember = getCurrentSelectedMember();
                showUpdateMemberDialog(selectedMember);
            } else
            {
                MessageBox.Show("You haven't selected any rows", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 
        }


        private void btn_createMem_Click(object sender, EventArgs e)
        {
            AddNewMember addMemberDialog = new AddNewMember(membersGridView);
            addMemberDialog.ShowDialog();
        }

        private void btn_deleteMem_Click(object sender, EventArgs e)
        {
            if (membersGridView.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Permanently remove this mem?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                switch (dialogResult)
                {
                    case DialogResult.Yes:
                        // Connect to mongo client and get collection
                        var client = new MongoClient("mongodb+srv://52000797:tQ!mTK6NW74wexq@highlandcluster.fc5jjn4.mongodb.net");
                        var db = client.GetDatabase("highland");
                        IMongoCollection<BsonDocument> collection = db.GetCollection<BsonDocument>("members");

                        // Find selected row then get staff _id
                        int rowIndex = membersGridView.CurrentCell.RowIndex;
                        DataGridViewRow selectedRow = membersGridView.Rows[rowIndex];
                        ObjectId id = ObjectId.Parse(selectedRow.Cells[0].Value.ToString());


                        // Remove row
                        DataTable dataTable = (DataTable)membersGridView.DataSource;
                        DataRow row = (membersGridView.Rows[rowIndex].DataBoundItem as DataRowView).Row;
                        dataTable.Rows.Remove(row);

                        deleteMember(id, collection);
                        break;
                    case DialogResult.No:
                        break;
                    default:
                        break;
                }
            }
            else
            {
                MessageBox.Show("You haven't selected any row. Please select one!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
