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
using Design_Highlands.models;

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

        private List<Drink> getCoffees()
        {
            List<Drink> drinks = new List<Drink>();
            var client = new MongoClient("mongodb+srv://52000797:tQ!mTK6NW74wexq@highlandcluster.fc5jjn4.mongodb.net");
            var db = client.GetDatabase("highland");
            IMongoCollection<BsonDocument> collection = db.GetCollection<BsonDocument>("drinks");
            List<BsonDocument> results = collection.Find(new BsonDocument()).ToList();

            foreach (BsonDocument result in results)
            {
                Drink drink = BsonSerializer.Deserialize<Drink>(result);
                if (drink.Type.Equals("coffee"))
                {
                    drinks.Add(drink);
                }
            }

            return drinks;
        }

        private List<Food> getFoods()
        {
            List<Food> foods = new List<Food>();
            var client = new MongoClient("mongodb+srv://52000797:tQ!mTK6NW74wexq@highlandcluster.fc5jjn4.mongodb.net");
            var db = client.GetDatabase("highland");
            IMongoCollection<BsonDocument> collection = db.GetCollection<BsonDocument>("foods");
            List<BsonDocument> results = collection.Find(new BsonDocument()).ToList();

            foreach (BsonDocument result in results)
            {
                Food food = BsonSerializer.Deserialize<Food>(result);
                foods.Add(food);
            }

            return foods;
        }

        private void loadCoffees()
        {
            // Get all coffees from db
            List<Drink> drinks = getCoffees();

            foreach (Drink drink in drinks)
            {
                DrinkWidget widget = new DrinkWidget(drink, flp_bill);
                flp_menu.Controls.Add(widget);
            }
        }
        private void loadDrinks()
        {
            // Get all drinks from db
            List<Drink> drinks = getDrinks();

            foreach (Drink drink in drinks)
            {
                DrinkWidget widget = new DrinkWidget(drink, flp_bill);
                flp_menu.Controls.Add(widget);
            }
        }

        private void loadFoods()
        {
            // Get all foods from db
            List<Food> foods = getFoods();

            foreach (Food food in foods)
            {
                FoodWidget widget = new FoodWidget(food, flp_bill);
                flp_menu.Controls.Add(widget);
            }
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

        private void btn_drink_Click(object sender, EventArgs e)
        {
            flp_menu.Controls.Clear();
            loadDrinks();
        }

        private void OrderScreen_Load(object sender, EventArgs e)
        {
            loadDrinks();
        }

        private void btn_food_Click(object sender, EventArgs e)
        {
            flp_menu.Controls.Clear();
            loadFoods();
        }

        private void btn_coffee_Click(object sender, EventArgs e)
        {
            flp_menu.Controls.Clear();
            loadCoffees();
        }
    }
}
