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
using CloudinaryDotNet.Actions;
using CloudinaryDotNet;

namespace Design_Highlands
{
    internal partial class AddNewDrink : Form
    {
        Drink drink;
        string option;
        string filePath;
        DataGridView menuGridView;
        public AddNewDrink()
        {
            InitializeComponent();
        }

        public AddNewDrink(Drink drink, string option, DataGridView menuGridView)
        {
            InitializeComponent();
            this.drink = drink;
            this.option = option;
            this.menuGridView = menuGridView;
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

        private Drink findDrinkById(ObjectId id, IMongoCollection<BsonDocument> collection)
        {
            List<BsonDocument> results = collection.Find(new BsonDocument()).ToList();
            foreach (BsonDocument result in results)
            {
                if (result.ContainsValue(id))
                {
                    Drink drink = BsonSerializer.Deserialize<Drink>(result);
                    return drink;
                }
            }
            return null;
        }

        // Events

        private void pb_drinkImage_Click(object sender, EventArgs e)
        {
            openDrinkFileDialog.ShowDialog();
            this.filePath = openDrinkFileDialog.FileName;
            if (filePath != null)
            {
                pb_drinkImage.Image = Image.FromFile(filePath);
            }
        }

        private void btn_addNewDrink_Click(object sender, EventArgs e)
        {
            if (true)
            {
                // Connect to db
                var client = new MongoClient("mongodb+srv://52000797:tQ!mTK6NW74wexq@highlandcluster.fc5jjn4.mongodb.net");
                var db = client.GetDatabase("highland");
                IMongoCollection<BsonDocument> collection = db.GetCollection<BsonDocument>("drinks");

                var _id = ObjectId.GenerateNewId();

                // Upload picture if exists
                
                var cloudinary = new Cloudinary(new Account("dzzv49yec", "135785993356753", "n8KzEThKCgPBGHuk3gFPnQPsvx4"));

                // Upload
                var uploadParams = new ImageUploadParams()
                {
                    File = new FileDescription(@"https://upload.wikimedia.org/wikipedia/commons/a/ae/Olympic_flag.jpg"),
                    PublicId = "drink_image"
                };

                var uploadResult = cloudinary.Upload(uploadParams);

                // Create BsonDocument
                var document = new BsonDocument
                {
                    {"_id", _id },
                    { "Type", option != "All drinks" ? option : "" },
                    { "NameE", tb_drinkNameEng.Text },
                    { "NameV", tb_drinkNameViet.Text },
                    { "Thumbnail", uploadResult.SecureUrl.ToString() },
                };


                // write staff to database
                createDrink(document, collection);

                Drink drink = findDrinkById(_id, collection);
                if (drink != null)
                {
                    // Update grid view 

                    DataTable dataTable = (DataTable)menuGridView.DataSource;
                    DataRow newRow = dataTable.NewRow();

                    newRow["Id"] = drink.Id;
                    newRow["Type"] = drink.Type;
                    newRow["English Name"] = drink.NameE;
                    newRow["Vietnamese Name"] = drink.NameV;
                    newRow["Size S (đ)"] = drink.Price.S;
                    newRow["Size M (đ)"] = drink.Price.M;
                    newRow["Size L (đ)"] = drink.Price.L;
                    newRow["Materials"] = drink.Material;

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

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
