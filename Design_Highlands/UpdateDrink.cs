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
    internal partial class UpdateDrink : Form
    {
        Drink drink;
        DataGridView menuGridView;
        int priceS;
        int priceM;
        int priceL;
        public UpdateDrink()
        {
            InitializeComponent();
        }

        public UpdateDrink(Drink drink, DataGridView menuGridView)
        {
            InitializeComponent();
            this.drink = drink;
            this.menuGridView = menuGridView;
            this.priceS = drink.Price.S;
            this.priceM = drink.Price.M;
            this.priceL = drink.Price.L;
        }

        // Event handlers



        // Events
        private void UpdateDrink_Load(object sender, EventArgs e)
        {
            tb_drinkNameEng.Text = drink.NameE;
            tb_drinkNameViet.Text = drink.NameV;
        }

        private void rdb_drinkSizeS_CheckedChanged(object sender, EventArgs e)
        {
            if(rdb_drinkSizeS.Checked)
            {
                tb_drinkPrice.Text = this.priceS.ToString();
            }
        }
        private void rdb_drinkSizeM_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_drinkSizeM.Checked)
            {
                tb_drinkPrice.Text = this.priceM.ToString();
            }
        }
        private void rdb_drinkSizeL_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_drinkSizeL.Checked)
            {
                tb_drinkPrice.Text = this.priceL.ToString();
            }
        }

        private void tb_drinkPrice_TextChanged(object sender, EventArgs e)
        {
            var value = tb_drinkPrice.Text;
            int price;
            var isNumeric = int.TryParse(value, out price);
            if (isNumeric)
            {
                if (rdb_drinkSizeS.Checked)
                {
                    this.priceS = Int32.Parse(value);
                }
                else if (rdb_drinkSizeM.Checked)
                {
                    this.priceM = Int32.Parse(value);
                }
                else if (rdb_drinkSizeL.Checked)
                {
                    this.priceL = Int32.Parse(value);
                }
            }
            else
            {
                MessageBox.Show("Price must be number!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_updateDrink_Click(object sender, EventArgs e)
        {
            // Connect to db
            var client = new MongoClient("mongodb+srv://52000797:tQ!mTK6NW74wexq@highlandcluster.fc5jjn4.mongodb.net");
            var db = client.GetDatabase("highland");
            IMongoCollection<BsonDocument> collection = db.GetCollection<BsonDocument>("members");

            // Find doc and update
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(drink.Id));
            var update = Builders<BsonDocument>.Update.Set("NameE", tb_drinkNameEng.Text).Set("NameV", tb_drinkNameViet.Text).Set("S", this.priceS).Set("M", this.priceM).Set("L", this.priceL);

            UpdateResult result = collection.UpdateOne(filter, update);

            if (result.IsAcknowledged)
            {
                // Update grid view
                int rowIndex = menuGridView.CurrentCell.RowIndex;
                DataGridViewRow selectedRow = menuGridView.Rows[rowIndex];

                selectedRow.Cells[2].Value = tb_drinkNameEng.Text;
                selectedRow.Cells[3].Value = tb_drinkNameViet.Text;
                selectedRow.Cells[4].Value = this.priceS.ToString();
                selectedRow.Cells[5].Value = this.priceM.ToString();
                selectedRow.Cells[6].Value = this.priceL.ToString();

                DialogResult dialogResult = MessageBox.Show("Updated drink's info successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
