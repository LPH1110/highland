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
        
        public Drink(string id, string type, string nameE, string nameV, DrinkSize price)
        {
            this.Id = id;
            this.Type = type;
            this.NameE = nameE;
            this.NameV = nameV;
            this.Price = price;
        }


        [BsonRepresentation(BsonType.ObjectId)]

        private string Id { get; set; }
        private string Type { get; set; }
        private string NameE { get; set; }
        private string NameV { get; set; }
        private DrinkSize Price { get; set; }
    }
}
