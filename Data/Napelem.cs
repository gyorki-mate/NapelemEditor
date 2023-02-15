using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace NapelemEditor.Data;

public class Napelem
{
    [BsonRepresentation(BsonType.ObjectId)]
    public string id { get; } =ObjectId.GenerateNewId().ToString();
    public int width { get; set; }
    public int heigth { get; set; }
    public int output { get; set; }
}