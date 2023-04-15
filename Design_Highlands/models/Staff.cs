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
    internal class Staff
    {

       
        public Staff(string id, string staffId, string name, string phone, string birthYear, string identity, string address, string username, string password, string role)
        {
            this.Id = id;
            this.staffId = staffId;
            this.name = name;
            this.phone = phone;
            this.birthYear = birthYear;
            this.identity = identity;
            this.address = address;
            this.username = username;
            this.password = password;
            this.role = role;
        }

        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string staffId { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string birthYear { get; set; }
        public string identity { get; set; }
        public string address { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string role { get; set; }

    }
}
