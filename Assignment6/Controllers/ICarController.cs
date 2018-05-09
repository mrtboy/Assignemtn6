using Assignment6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6.Controllers
{
    public interface ICarController 
    {
        string AddNewCar(Car car);
        string EditCar(Car car);
        List<Car> GetCars();
        string DeleteCar(int id);

    }
}
