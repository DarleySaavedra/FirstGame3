using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Repository;

namespace WebApplication1.Servicios
{
    public class UserService : IUserServices
    {
        IUserRepository usres;
        public UserService()
        {
            usres = new UserRepository();
        }
        public bool updateUser(int id, int score)
        {
            return usres.updateUser(id, score);
        }
    }
}