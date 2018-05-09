using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public Company() { }

        public Company(int id, string name, string address, string phoneNumber)
        {
            Id = id;
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
        }

        public override string ToString()
        {
            string result = "Company ID: " + Id + " Name: "+ Name  + " Address: " + Address + " Phone Number: " + PhoneNumber;
            return result;
        }
    }
}
