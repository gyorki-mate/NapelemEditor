using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace NapelemEditor.Models;

public class Users
{
    [BsonRepresentation(BsonType.ObjectId)]
    public string id { get; set; } 
    [BsonElement("userName")]  public string UserName { get; set; }
    [BsonElement("password")]  public string Password { get; set; }
    [BsonElement("salt")] public string Salt { get; set; }
}