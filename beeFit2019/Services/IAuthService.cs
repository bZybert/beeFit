﻿using beeFit2019.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace beeFit2019.Services
{
    interface IAuthService
    {
        Task<User> Register(User user, string password);

        Task<User> Login(string username, string password);

        Task<bool> UserExist(string username);
    }
}
