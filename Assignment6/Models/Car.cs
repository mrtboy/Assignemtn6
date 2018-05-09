using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public DateTime ManufacturingYear { get; set; }
        public double Mileage { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }
        public int CompanyId { get; set; }

        public Car() { }

        public Car(int id, string brand, string model,
            DateTime manufacturingYear, double mileage, decimal price, bool isAvailable, int companyId)
        {
            Id = id;
            Brand = brand;
            Model = model;
            ManufacturingYear = manufacturingYear;
            Mileage = mileage;
            Price = price;
            IsAvailable = isAvailable;
            CompanyId = companyId;
        }

        public override string ToString()
        {
            string result = "Car Id: " + Id + " Brand: " + Brand + " Model: " + Model + " Manufacturing Year: " + ManufacturingYear + " Mileage: " + 
                Mileage + " Price: " + " Availability: " + IsAvailable + " Company ID: " + CompanyId;
            return result;
        }
    }
}
