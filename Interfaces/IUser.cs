﻿using NapelemEditor.Models;

namespace NapelemEditor.Interfaces;

public interface IUser
{
    public Task<List<Users>> GetAllUsers();
    public Task<Users?> GetUser(string userName);
    public void AddUser(Users user);
    public Task UpdateUser(Users user);
    public void DeleteUser(string userID);
}