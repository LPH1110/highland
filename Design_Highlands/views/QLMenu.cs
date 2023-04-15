﻿using MongoDB.Bson.Serialization;
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
    internal partial class QLMenu: Form
    {
        Staff staff;
        List<String> drinkOptions = new List<String>();
        public QLMenu()
        {
            InitializeComponent();
            initiateDrinkOptions();
        }

        public QLMenu(Staff staff)
        {
            InitializeComponent();
            this.staff = staff;
            initiateDrinkOptions();


        }

        private void initiateDrinkOptions()
        {
            drinkOptions.Add("Coffee");
            drinkOptions.Add("Tea");
            drinkOptions.Add("Phindi");
            drinkOptions.Add("Freeze");
            drinkOptions.Add("Expresso");
            drinkOptions.Add("All drinks");
        }

        // Event handlers

        private void showUpdateDrinkDialog(Drink drink)
        {
            UpdateDrink updateDrinkDialog = new UpdateDrink(drink, menuGridView);
            updateDrinkDialog.ShowDialog();
        }
        private void loadDrinks()
        {
            DataTable table = new DataTable();

            table.Columns.Add(new DataColumn("ID", typeof(string)));
            table.Columns.Add(new DataColumn("Type", typeof(string)));
            table.Columns.Add(new DataColumn("English Name", typeof(string)));
            table.Columns.Add(new DataColumn("Vietnamese Name", typeof(string)));
            table.Columns.Add(new DataColumn("Size S (đ)", typeof(string)));
            table.Columns.Add(new DataColumn("Size M (đ)", typeof(string)));
            table.Columns.Add(new DataColumn("Size L (đ)", typeof(string)));
            table.Columns.Add(new DataColumn("Materials", typeof(string)));


            var client = new MongoClient("mongodb+srv://52000797:tQ!mTK6NW74wexq@highlandcluster.fc5jjn4.mongodb.net");
            var db = client.GetDatabase("highland");
            IMongoCollection<BsonDocument> collection = db.GetCollection<BsonDocument>("drinks");
            List<BsonDocument> results = collection.Find(new BsonDocument()).ToList();

            foreach (BsonDocument result in results)
            {
                Drink drink = BsonSerializer.Deserialize<Drink>(result);
                table.Rows.Add(drink.Id, drink.Type, drink.NameE, drink.NameV, drink.Price.S, drink.Price.M, drink.Price.L, drink.Material);
            }

            menuGridView.DataSource = table;
        }
        
        private void showAddNewMenu()
        {
            
            var option = cbb_menuOptions.SelectedItem.ToString();
            if (drinkOptions.Contains(option))
            {
                Drink selectedDrink = getCurrentSelectedDrink();
                AddNewDrink addNewDrinkView = new AddNewDrink(selectedDrink, option, menuGridView);
                addNewDrinkView.ShowDialog();

            }
            else
            {
                MessageBox.Show("Food dialog");
            }
        }

        private Drink getCurrentSelectedDrink()
        {
            int rowIndex = menuGridView.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = menuGridView.Rows[rowIndex];
            var drink = new Drink(
                id: selectedRow.Cells[0].Value.ToString(),
                type: selectedRow.Cells[1].Value.ToString(),
                nameE: selectedRow.Cells[2].Value.ToString(),
                nameV: selectedRow.Cells[3].Value.ToString(),
                price: new DrinkSize(
                        Int32.Parse(selectedRow.Cells[4].Value.ToString()),
                        Int32.Parse(selectedRow.Cells[5].Value.ToString()),
                        Int32.Parse(selectedRow.Cells[6].Value.ToString())
                    ),
                material: selectedRow.Cells[7].Value.ToString()
               );
            return drink;
        }

        private void backToHome()
        {
            this.Hide();
            Home homeView = new Home(this.staff);
            homeView.ShowDialog();
        }

        private async void deleteDrink(ObjectId id, IMongoCollection<BsonDocument> collection)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("_id", id);
            DeleteResult result = await collection.DeleteOneAsync(filter);
            if (result.IsAcknowledged)
            {
                MessageBox.Show("Deleted drink successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to delete drink!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Events

        private void lb_back_Click(object sender, EventArgs e)
        {
            backToHome();
        }


        private void QLMenu_Load(object sender, EventArgs e)
        {
            loadDrinks();
        }

        private void pb_back_Click(object sender, EventArgs e)
        {
            backToHome();

        }

        private void btn_addMenu_Click(object sender, EventArgs e)
        {
            showAddNewMenu();
        }

        private void btn_updateMenu_Click(object sender, EventArgs e)
        {
            if (menuGridView.SelectedRows.Count > 0)
            {
                var selectedMember = getCurrentSelectedDrink();
                showUpdateDrinkDialog(selectedMember);
            }
            else
            {
                MessageBox.Show("You haven't selected any rows", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void menuGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedDrink = getCurrentSelectedDrink();
            showUpdateDrinkDialog(selectedDrink);
        }

        private void btn_deleteMenu_Click(object sender, EventArgs e)
        {
            if (menuGridView.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Permanently remove this mem?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                switch (dialogResult)
                {
                    case DialogResult.Yes:
                        // Connect to mongo client and get collection
                        var client = new MongoClient("mongodb+srv://52000797:tQ!mTK6NW74wexq@highlandcluster.fc5jjn4.mongodb.net");
                        var db = client.GetDatabase("highland");
                        IMongoCollection<BsonDocument> collection = db.GetCollection<BsonDocument>("drinks");

                        // Find selected row then get staff _id
                        int rowIndex = menuGridView.CurrentCell.RowIndex;
                        DataGridViewRow selectedRow = menuGridView.Rows[rowIndex];
                        ObjectId id = ObjectId.Parse(selectedRow.Cells[0].Value.ToString());


                        // Remove row
                        DataTable dataTable = (DataTable)menuGridView.DataSource;
                        DataRow row = (menuGridView.Rows[rowIndex].DataBoundItem as DataRowView).Row;
                        dataTable.Rows.Remove(row);

                        deleteDrink(id, collection);
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