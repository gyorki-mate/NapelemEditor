using NapelemEditor.Models;
using NapelemEditor.Interfaces;
using MongoDB.Driver;

namespace NapelemEditor.Controllers;

public class UserController : IUser
{
    DbContext context = new DbContext();

    public UserController()
    {
      
    }

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

        return null;
    }
    
    //get user by username
    public  Users GetUser(string userName)
    {
        try
        {
            var User = context.UserRecord.Find(x => x.UserName == userName).FirstOrDefault();
            return  User;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public async void UpdateUser(Users user)
    {
        await context.UserRecord.ReplaceOneAsync(x => x.id == user.id, user);
    }

    public void DeleteUser(string userID)
    {
        throw new NotImplementedException();
    }
}