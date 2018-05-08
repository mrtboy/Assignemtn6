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
        public string AddCar(Car car)
        {
            string path = String.Format(@".\{0}.xml", "Car");
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
            throw new NotImplementedException();
        }

        public List<Car> GetCars()
        {
            throw new NotImplementedException();
        }

        public string UpdateCar(int id)
        {
            throw new NotImplementedException();
        }
    }
}
