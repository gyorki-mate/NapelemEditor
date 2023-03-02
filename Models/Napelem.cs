using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace NapelemEditor.Models;

public class Napelem
{
    [BsonRepresentation(BsonType.ObjectId)]
    public string id { get; } =ObjectId.GenerateNewId().ToString();
    public string type { get; set; }
    public string shape { get; set; }
    public int width { get; set; }
    public int height { get; set; }
    public int output { get; set; }
    public int price { get; set; }
}