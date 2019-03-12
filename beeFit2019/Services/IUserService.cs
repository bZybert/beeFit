using beeFit2019.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace beeFit2019.Services
{
    interface IUserService
    {
        List<User> GetAllUsers();
        void AddUser(User user);
        User GetSingleUserById(int id);
        void UpdateUser(User user);
        void DeleteUser(int id);
        //UserViewModel UserDeletionConfirmation(int id);
    }
}
