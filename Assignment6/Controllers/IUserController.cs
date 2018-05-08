using Assignment6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6.Controllers
{
    public interface IUserController
    {
        string Register(User user);
        bool Login(User user);
    }
}
