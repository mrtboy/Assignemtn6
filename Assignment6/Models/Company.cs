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
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public Company() { }

        public Company(int id, string address, string phoneNumber)
        {
            Id = id;
            Address = address;
            PhoneNumber = phoneNumber;
        }
    }
}
