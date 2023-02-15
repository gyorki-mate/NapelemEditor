using NapelemEditor.Data;
using NapelemEditor.Interfaces;
using MongoDB.Driver;

namespace NapelemEditor.Controllers;

public class UserController : IUser
{
    private MongoClient _mongoClient = null;
    private IMongoDatabase _mongoDatabase = null;
    private IMongoCollection<Users> _mongoCollection = null;

    public UserController()
    {
        _mongoClient = new MongoClient("mongodb+srv://admin:admin@cluster0.sbu7tp5.mongodb.net/test");
        _mongoDatabase = _mongoClient.GetDatabase("Napelem");
        _mongoCollection = _mongoDatabase.GetCollection<Users>("User");
    }

    public async void AddUser(Users user)
    {
        try
        {
            await _mongoCollection.InsertOneAsync(user);
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
            var users = _mongoCollection.Find(FilterDefinition<Users>.Empty).ToListAsync();
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
            var User = _mongoCollection.Find(x => x.UserName == userName).FirstOrDefault();
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
        await _mongoCollection.ReplaceOneAsync(x => x.id == user.id, user);
    }

    public void DeleteUser(string userID)
    {
        throw new NotImplementedException();
    }
}