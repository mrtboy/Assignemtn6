using Assignment6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6.Data
{
    interface ICarData
    {
        string AddCar(Car car);
        List<Car> GetCars();
        string UpdateCar(Car car);
        string DeleteCar(int id);
    }
}
