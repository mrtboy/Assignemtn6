using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment6.Data;
using Assignment6.Models;

namespace Assignment6.Controllers
{
    public class UserController : IUserController
    {
        IUserData userData;
        public UserController()
        {
            userData = new UserData();
        }
        public bool Login(User user)
        {
            List<User> users = new List<User>();
            users = userData.GetUser();
            foreach (User u in users)
            {
                if(user.Username == u.Username && user.Password == u.Password)
                {
                    return true;
                }
            }
            return false;
        }

        public string Register(User user)
        {
            return userData.AddNewUser(user);
        }
    }
}
