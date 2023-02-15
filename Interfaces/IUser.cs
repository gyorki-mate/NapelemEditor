using NapelemEditor.Data;

namespace NapelemEditor.Interfaces;

public interface IUser
{
    public Task<List<Users>> GetAllUsers();
    public Users GetUser(string userName);
    public void AddUser(Users user);
    public void UpdateUser(Users user);
    public void DeleteUser(string userID);
}