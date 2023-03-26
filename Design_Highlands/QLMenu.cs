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
    internal partial class QLMenu: Form
    {
        Staff staff;
        public QLMenu()
        {
            InitializeComponent();
        }

        public QLMenu(Staff staff)
        {
            InitializeComponent();
            this.staff = staff;
        }

        // Event handlers
        private void loadDrinks()
        {
            DataTable table = new DataTable();

            table.Columns.Add(new DataColumn("ID", typeof(string)));
            table.Columns.Add(new DataColumn("Type", typeof(string)));
            table.Columns.Add(new DataColumn("English Name", typeof(string)));
            table.Columns.Add(new DataColumn("Vietnamese Name", typeof(string)));
            table.Columns.Add(new DataColumn("Size S", typeof(string)));
            table.Columns.Add(new DataColumn("Size M", typeof(string)));
            table.Columns.Add(new DataColumn("Size L", typeof(string)));
            

            var client = new MongoClient("mongodb+srv://52000797:tQ!mTK6NW74wexq@highlandcluster.fc5jjn4.mongodb.net");
            var db = client.GetDatabase("highland");
            IMongoCollection<BsonDocument> collection = db.GetCollection<BsonDocument>("drinks");
            List<BsonDocument> results = collection.Find(new BsonDocument()).ToList();

            foreach (BsonDocument result in results)
            {
                Drink drink = BsonSerializer.Deserialize<Drink>(result);
                table.Rows.Add(drink.Id, drink.Type, drink.NameE, drink.NameV, drink.Price.S, drink.Price.M, drink.Price.L);
            }

            menuGridview.DataSource = table;
        }

        // Events

        private void lb_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home homeView = new Home(staff);
            homeView.ShowDialog();
        }


        private void QLMenu_Load(object sender, EventArgs e)
        {
            loadDrinks();
        }

    }
}
