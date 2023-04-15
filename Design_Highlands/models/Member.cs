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
        public Member(string id, string memberId, string name, string phone, string address, string gender, string birthYear, string rank)
        {
            this.Id = id;
            this.memberId = memberId;
            this.name = name;
            this.phone = phone;
            this.address = address;
            this.gender = gender;
            this.birthYear = birthYear  ;
            this.rank = rank;
        }

        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string memberId { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public string gender { get; set; }
        public string birthYear { get; set; }
        public string rank { get; set; }

    }
}
