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
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Phone", typeof(string));
            table.Columns.Add("Rank", typeof(string));

            var client = new MongoClient("mongodb+srv://52000797:tQ!mTK6NW74wexq@highlandcluster.fc5jjn4.mongodb.net");
            var db = client.GetDatabase("highland");
            IMongoCollection<BsonDocument> collection = db.GetCollection<BsonDocument>("members");
            List<BsonDocument> results = collection.Find(new BsonDocument()).ToList();

            foreach (BsonDocument result in results)
            {
                Member member = BsonSerializer.Deserialize<Member>(result);
                table.Rows.Add(member.Id, member.name, member.phone, member.rank);
            }

            membersGridView.DataSource = table;
        }

        private void showUpdateMemberDialog(Member member)
        {
            UpdateMember updateMemberDialog = new UpdateMember(member);
            updateMemberDialog.ShowDialog();
        }

        private Member getCurrentSelectedMember()
        {
            int rowIndex = membersGridView.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = membersGridView.Rows[rowIndex];
            var member = new Member(
                id: selectedRow.Cells[0].Value.ToString(),
                name: selectedRow.Cells[2].Value.ToString(),
                phone: selectedRow.Cells[3].Value.ToString(),
                rank: selectedRow.Cells[4].Value.ToString()
               );
            return member;
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
    }
}
