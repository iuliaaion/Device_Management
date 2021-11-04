using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace Management_APP.Models
{
    public class Employees
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Name")]
        [JsonProperty("Name")]
        public string EmployeeName { get; set; }

        public string Role { get; set; }

        public string Location { get; set; }

        public string Device_ID { get; set; }
    }
}
