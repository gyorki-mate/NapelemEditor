using NapelemEditor.Models;
using NapelemEditor.Interfaces;
using MongoDB.Driver;

namespace NapelemEditor.Controllers;

public class NapelemController : INapelem
{
    DbContext context = new DbContext();
    //TODO lehet máshogy kéne megoldani a hibakezelést, ez volt a legegyszerűbb :/
    public async Task<bool> AddNapelem(Napelem napelem)
    {
        try
        {
            await context.NapelemRecord.InsertOneAsync(napelem);
            return true;
        }
        catch (Exception)
        {
            return false;
            
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

    public async Task UpdateNapelem(Napelem napelem)
    {
        try
        {
            await context.NapelemRecord.ReplaceOneAsync(x => x.id == napelem.id, napelem);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public void DeleteNapelem(string napelemID)
    {
        try
        {
            context.NapelemRecord.DeleteOne(x => x.id == napelemID);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}