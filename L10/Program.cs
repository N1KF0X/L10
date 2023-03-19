using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L10
{
    internal class Program
    {       
        static void Main(string[] args)
        {
            Car car = new Car("qq777q");
            Car car1 = new Car("qq111q");
            Car car2 = new Car("ww777w");
            Garage garage = new Garage();
            garage.AddCar(car);
            garage.AddCar(car1);
            garage.AddCar(car2);

            Washer washer = () => garage.WashCar();
            washer();

            Console.ReadKey();
        }
    }
}
