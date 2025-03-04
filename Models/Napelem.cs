﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace NapelemEditor.Models;

public class Napelem
{
    [BsonRepresentation(BsonType.ObjectId)]
    public string id { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public int Output { get; set; }
    public int Price { get; set; }
    
}