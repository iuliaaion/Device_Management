using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace Management_APP.Models
{
    public class Device
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Name")]
        [JsonProperty("Name")]
        public string Device_Name { get; set; }

        public string Manufacturer { get; set; }

        public string Type { get; set; }

        public string OS { get; set; }

        public string OS_version { get; set; }

        public string Processor { get; set; }

        public string RAM { get; set; }
    }
}
