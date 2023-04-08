using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdParty.Json.LitJson;

namespace Design_Highlands
{
    internal class Drink
    {

        private string id;
        private string type;
        private string nameE;
        private string nameV;
        private DrinkSize price;
        private string material;
        public Drink(string id, string type, string nameE, string nameV, DrinkSize price, string material)
        {
            this.id = id;
            this.type = type;
            this.nameE = nameE;
            this.nameV = nameV;
            this.price = price;
            this.material = material;
        }


        [BsonRepresentation(BsonType.ObjectId)]

        public string Id { get { return this.id; } set { this.id = value; } }
        public string Type { get { return this.type; } set { this.type = value; } }
        public string NameE { get { return this.nameE; } set { this.nameE = value; } }
        public string NameV { get { return this.nameV; } set { this.nameV = value; } }
        public DrinkSize Price { get { return this.price; } set { this.price = value; } }
        public string Material { get { return this.material; } set { this.material = value; } }
    }
}
