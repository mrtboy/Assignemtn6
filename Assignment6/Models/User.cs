using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6.Models
{
    [DataContract]
    public class User
    {
        [DataMember]
        public string Username { get; set; }
        [DataMember]
        public string Password { get; set; }

        public User()
        {
        }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
