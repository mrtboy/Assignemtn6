using Assignment6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6.Data
{
    public interface IUserData
    {
        string AddNewUser(User user);
        List<User> GetUser();
    }
}
