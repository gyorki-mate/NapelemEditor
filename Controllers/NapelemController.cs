using NapelemEditor.Models;
using NapelemEditor.Interfaces;
using MongoDB.Driver;

namespace NapelemEditor.Controllers;

public class NapelemController : INapelem
{
    DbContext context = new DbContext();
    
    public async void AddNapelem(Napelem napelem)
    {
        try
        {
            await context.NapelemRecord.InsertOneAsync(napelem);
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
            var napelems = context.NapelemRecord.Find(FilterDefinition<Napelem>.Empty).ToListAsync();
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
        await context.NapelemRecord.ReplaceOneAsync(x => x.id == napelem.id, napelem);
    }

    public void DeleteNapelem(string napelemID)
    {
        throw new NotImplementedException();
    }
}