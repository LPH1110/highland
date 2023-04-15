using Design_Highlands.components;
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
    internal partial class OrderScreen : Form
    {
        Staff staff;
        public OrderScreen()
        {
            InitializeComponent();
        }

        public OrderScreen(Staff staff)
        {
            InitializeComponent();
            this.staff = staff;
        }

        // Event handlers
        private void backToHome()
        {
            this.Hide();
            Home home = new Home(this.staff);
            home.ShowDialog();
        }

        private List<Drink> getDrinks()
        {
            List<Drink> drinks = new List<Drink>();
            var client = new MongoClient("mongodb+srv://52000797:tQ!mTK6NW74wexq@highlandcluster.fc5jjn4.mongodb.net");
            var db = client.GetDatabase("highland");
            IMongoCollection<BsonDocument> collection = db.GetCollection<BsonDocument>("drinks");
            List<BsonDocument> results = collection.Find(new BsonDocument()).ToList();

            foreach (BsonDocument result in results)
            {
                Drink drink = BsonSerializer.Deserialize<Drink>(result);
                drinks.Add(drink);
            }

            return drinks;
        }


        // Events
        private void lb_back_Click(object sender, EventArgs e)
        {
            backToHome();
        }

        private void pb_back_Click(object sender, EventArgs e)
        {
            backToHome();
        }

        private void OrderScreen_Load(object sender, EventArgs e)
        {
            // Get all drinks from db
            List<Drink> drinks = getDrinks();

            foreach (Drink drink in drinks)
            {
                DrinkWidget widget = new DrinkWidget(drink, flp_bill);
                flp_menu.Controls.Add(widget);
            }
        }

        private void flp_menu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
