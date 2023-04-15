using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Highlands.models
{
    internal class Food
    {
        private string id;
        private string type;
        private string nameE;
        private string nameV;
        private int price;
        public Food(string id, string type, string nameE, string nameV, int price)
        {
            this.id = id;
            this.type = type;
            this.nameE = nameE;
            this.nameV = nameV;
            this.price = price;
        }


        [BsonRepresentation(BsonType.ObjectId)]

        public string Id { get { return this.id; } set { this.id = value; } }
        public string Type { get { return this.type; } set { this.type = value; } }
        public string NameE { get { return this.nameE; } set { this.nameE = value; } }
        public string NameV { get { return this.nameV; } set { this.nameV = value; } }
        public int Price { get { return this.price; } set { this.price = value; } }
    }
}
