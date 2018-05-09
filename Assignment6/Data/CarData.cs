using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment6.Models;

namespace Assignment6.Data
{
    class CarData : ICarData
    {
        string path = String.Format(@".\{0}.xml", "Car");
        public string AddCar(Car car)
        {
            List<Car> cars = new List<Car>();
            if (File.Exists(path))
            {
                cars = XMLReadWrite.ReadXML<List<Car>>(path);
            }

            cars.Add(car);
            return XMLReadWrite.WriteXML<List<Car>>(cars, path);
        }

        public string DeleteCar(int id)
        {
            List<Car> newCars = new List<Car>();
            List<Car> cars = XMLReadWrite.ReadXML<List<Car>>(path);
            foreach (Car c in cars)
            {
                if (c.Id != id)
                {
                    newCars.Add(c);
                }
            }
            XMLReadWrite.WriteXML<List<Car>>(newCars, path);
            return "";
        }

        public List<Car> GetCars()
        {
            return XMLReadWrite.ReadXML<List<Car>>(path);
        }

        public string UpdateCar(Car car)
        {
            List<Car> newCars = new List<Car>();
            List<Car> cars = XMLReadWrite.ReadXML<List<Car>>(path);
            foreach(Car c in cars)
            {
                if(c.Id != car.Id)
                {
                    newCars.Add(c);
                }
            }
            return "";
        }
    }
}
