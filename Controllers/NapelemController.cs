using NapelemEditor.Data;
using NapelemEditor.Interfaces;
using MongoDB.Driver;

namespace NapelemEditor.Controllers;

public class NapelemController : INapelem
{
    private MongoClient _mongoClient = null;
    private IMongoDatabase _mongoDatabase = null;
    private IMongoCollection<Napelem> _mongoCollection = null;

    public NapelemController()
    {
        _mongoClient = new MongoClient("mongodb+srv://admin:admin@cluster0.sbu7tp5.mongodb.net/test");
        _mongoDatabase = _mongoClient.GetDatabase("Napelem");
        _mongoCollection = _mongoDatabase.GetCollection<Napelem>("Napelem");
    }

    public async void AddNapelem(Napelem napelem)
    {
        try
        {
            await _mongoCollection.InsertOneAsync(napelem);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task<List<Napelem>> GetAllNapelem()
    {
        try
        {
            var napelems = _mongoCollection.Find(FilterDefinition<Napelem>.Empty).ToListAsync();
            return await napelems;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public async void UpdateNapelem(Napelem napelem)
    {
        await _mongoCollection.ReplaceOneAsync(x => x.id == napelem.id, napelem);
    }

    public void DeleteNapelem(string napelemID)
    {
        throw new NotImplementedException();
    }
}