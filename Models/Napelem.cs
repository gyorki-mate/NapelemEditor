using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace NapelemEditor.Models;

public class Napelem
{
    [BsonRepresentation(BsonType.ObjectId)]
    public string id { get; } =ObjectId.GenerateNewId().ToString();
    public string Type { get; set; }
    public string Shape { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public int Output { get; set; }
    public int Price { get; set; }
    
}