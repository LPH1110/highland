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
    internal partial class AddNewDrink : Form
    {
        Drink drink;
        string option;
        public AddNewDrink()
        {
            InitializeComponent();
        }

        public AddNewDrink(Drink drink, string option)
        {
            InitializeComponent();
            this.drink = drink;
            this.option = option;
        }

        // Event Handlers
        private async void createDrink(BsonDocument document, IMongoCollection<BsonDocument> collection)
        {
            if (document != null)
            {
                await collection.InsertOneAsync(document);
                MessageBox.Show("Create new drink successfully!", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                this.Hide();

            }
            else
            {
                MessageBox.Show("Failed to create new drink. Please try again!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                this.Hide();
            }
        }

        private Staff findDrinkById(string id, IMongoCollection<BsonDocument> collection)
        {
            List<BsonDocument> results = collection.Find(new BsonDocument()).ToList();
            foreach (BsonDocument result in results)
            {
                if (result.ContainsValue(id))
                {
                    Staff staff = BsonSerializer.Deserialize<Staff>(result);
                    return staff;
                }
            }
            return null;
        }

        // Events

        private void pb_drinkImage_Click(object sender, EventArgs e)
        {
            openDrinkFileDialog.ShowDialog();
            string filePath = openDrinkFileDialog.FileName;
            if (filePath != null)
            {
                pb_drinkImage.Image = Image.FromFile(filePath);
            }
        }

        private void btn_addNewDrink_Click(object sender, EventArgs e)
        {
           
        }
    }
}
