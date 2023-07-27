using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DriverApp.Models
{
    public class Driver
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("name")]
        public string DriverName { get; set; } = string.Empty;

        [BsonElement("number")]
        public int Number { get; set; }

        [BsonElement("team")]
        public string Team { get; set; } = string.Empty;
    }
}
