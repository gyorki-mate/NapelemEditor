using System.Text;
using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;

namespace NapelemEditor.Models;

public class DbContext
{
    private IMongoDatabase _mongoDB;

    public DbContext()
    {
        //Don't ask, it's purpose is to confuse you
        var builder =new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json");
        var config = builder.Build();
        var connstr = config.GetConnectionString("hudConnection");
        var client = new MongoClient(connstr);
        _mongoDB = client.GetDatabase("Napelem");
    }
    
    //get collections
    public IMongoCollection<Napelem> NapelemRecord => _mongoDB.GetCollection<Napelem>("Napelem");
    public IMongoCollection<Users> UserRecord => _mongoDB.GetCollection<Users>("User");
    
}