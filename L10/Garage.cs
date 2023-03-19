using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L10
{
    internal class Garage
    {
        List<Car> cars = new List<Car>();
        public void AddCar(Car car)
        {
            cars.Add(car);
        }

        public void DeleteCar(Car car)
        {
            cars.Remove(car);
        }

        public void WashCar()
        {
            foreach (Car car in cars)
            {
                Console.WriteLine($"Машина с номерами \"{car.Numbers}\" была вымыта");
            }
        }
    }
}
