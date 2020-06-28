using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XmlToModel.Models;

namespace XmlToModel.Services
{
    public interface IAuthService
    {
        Task<User> Login(string username, string password);
        Task<User> Register(User user, string password);
        Task<bool> UserExists(string username);
    }
}
