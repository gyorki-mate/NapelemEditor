using NapelemEditor.Models;
using NapelemEditor.Interfaces;
using MongoDB.Driver;

namespace NapelemEditor.Controllers;

public class UserController : IUser
{
    DbContext context = new();
    
    public async void AddUser(Users user)
    {
        try
        {
            await context.UserRecord.InsertOneAsync(user);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task<List<Users>> GetAllUsers()
    {
        try
        {
            var users = context.UserRecord.Find(FilterDefinition<Users>.Empty).ToListAsync();
            return await users;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    
    //get user by username
    public async Task<Users?> GetUser(string userName)
    {
        Users? user;
        try
        {
            user =  await context.UserRecord.Find(x => x.UserName == userName).FirstOrDefaultAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        return  user;

    }

    public async Task UpdateUser(Users user)
    {
        try
        {
            await context.UserRecord.ReplaceOneAsync(x => x.id == user.id, user);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public void DeleteUser(string userID)
    {
        try
        {
            context.UserRecord.DeleteOneAsync(x => x.id == userID);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}