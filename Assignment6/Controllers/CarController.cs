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
            return data.DeleteCar(id);
        }

        public string EditCar(Car car)
        {
            return data.UpdateCar(car);
        }

        public List<Car> GetCars()
        {
            return data.GetCars();
        }
    }
}
