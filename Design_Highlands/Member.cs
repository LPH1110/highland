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
    internal class Member
    {
        public Member(string id, string name, string phone, string rank)
        {
            this.Id = id;
            this.staffId = staffId;
            this.name = name;
            this.phone = phone;
            this.rank = rank;
        }

        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string staffId { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string rank { get; set; }

    }
}
