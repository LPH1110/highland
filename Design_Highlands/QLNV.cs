using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Design_Highlands
{
    internal partial class QLNV : Form
    {
        Staff staff;
        DataTable table;
        public QLNV()
        {
            InitializeComponent();
        }
        public QLNV(Staff staff)
        {
            InitializeComponent();
            this.staff = staff;
        }

        public void setStaff(Staff staff)
        {
            this.staff = staff;
        } 

        private void backToHome()
        {
            Home homeView = new Home(this.staff);
            this.Hide();
            homeView.ShowDialog();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            backToHome();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            backToHome();
        }

       

        private void staffsGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedStaff = getCurrentSelectedStaff(staffsGridView);
            showUpdateStaffDialog(selectedStaff);
        }

        public void loadStaffData()
        {
            DataTable table = new DataTable();
            this.table = table;

            table.Columns.Add("Id", typeof(string));
            table.Columns.Add("Staff ID", typeof(string));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Phone", typeof(string));
            table.Columns.Add("Identity", typeof(string));
            table.Columns.Add("Address", typeof(string));
            table.Columns.Add("Birth Year", typeof(string));
            table.Columns.Add("Role", typeof(string));
            table.Columns.Add("Username", typeof(string));
            table.Columns.Add("Password", typeof(string));


            var client = new MongoClient("mongodb+srv://52000797:tQ!mTK6NW74wexq@highlandcluster.fc5jjn4.mongodb.net");
            var db = client.GetDatabase("highland");
            IMongoCollection<BsonDocument> listCollection = db.GetCollection<BsonDocument>("staffs");
            List<BsonDocument> results = listCollection.Find(new BsonDocument()).ToList();

            foreach (BsonDocument result in results)
            {
                Staff staff = BsonSerializer.Deserialize<Staff>(result);
                table.Rows.Add(staff.Id, staff.staffId, staff.name, staff.phone, staff.identity, staff.address, staff.birthYear, staff.role, staff.username, staff.password);
            }

            staffsGridView.DataSource = table;
        }

        private void QLNV_Load(object sender, EventArgs e)
        {
            loadStaffData();
        }
        
        private Boolean checkRowSelected(DataGridView gridView)
        {
            return gridView.SelectedRows.Count > 0;
        }

        private void showUpdateStaffDialog(Staff staff)
        {

            UpdateStaff updateStaffDialog = new UpdateStaff(staff, staffsGridView);
            updateStaffDialog.ShowDialog();

            
        }

        private Staff getCurrentSelectedStaff(DataGridView gridView)
        {
            int rowIndex = staffsGridView.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = staffsGridView.Rows[rowIndex];
            var staff = new Staff(
                id: selectedRow.Cells[0].Value.ToString(),
                staffId: selectedRow.Cells[1].Value.ToString(),
                name: selectedRow.Cells[2].Value.ToString(),
                phone: selectedRow.Cells[3].Value.ToString(),
                identity: selectedRow.Cells[4].Value.ToString(),
                address: selectedRow.Cells[5].Value.ToString(),
                birthYear: selectedRow.Cells[6].Value.ToString(),
                role: selectedRow.Cells[7].Value.ToString(),
                username: selectedRow.Cells[8].Value.ToString(),
                password: selectedRow.Cells[9].Value.ToString()
               );
            return staff;
        }

        private void btn_updateStaff_Click(object sender, EventArgs e)
        {
            if (checkRowSelected(staffsGridView))
            {
                var selectedStaff = getCurrentSelectedStaff(staffsGridView);
                showUpdateStaffDialog(selectedStaff);

            }
            else
            {
                MessageBox.Show("You haven't selected any rows yet!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_createStaff_Click(object sender, EventArgs e)
        {
            AddNewStaff newStaffDialog = new AddNewStaff(staffsGridView, table);
            newStaffDialog.ShowDialog();
        }

        private async void deleteStaff(string id, IMongoCollection<BsonDocument> collection) 
        {
        }
        private void btn_deleteStaff_Click(object sender, EventArgs e)
        {
        }
    }
}
