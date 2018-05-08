using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment6.Data;
using Assignment6.Models;

namespace Assignment6.Controllers
{
    public class CarController : ICarController
    {
        ICarData data;

        public CarController()
        {
            data = new CarData();
        }

        public string AddNewCar(Car car)
        {
            return data.AddCar(car);
        }

        public string DeleteCar(int id)
        {
            throw new NotImplementedException();
        }

        public string EditCar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCars()
        {
            throw new NotImplementedException();
        }
    }
}
