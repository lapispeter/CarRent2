using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace CarRent2.Models
{
    internal class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public List<Car> RentedCars { get; set; } = new List<Car>();

        public void RentCar(Car car)
        {
            if (car.isAvailable)
            {

                car.isAvailable = false;
                RentedCars.Add(car);
            }
        }
        public void ReturnCar(Car car)
        {
            if (RentedCars.Contains(car))
            {
                car.isAvailable = true;
                RentedCars.Remove(car);
                Console.WriteLine($"{car.Title} sikeresen visszaadva!");
            }
            else
            {
                Console.WriteLine($"{car.Title} nem volt kikölcsönözve!");
            }
        }


    }
}
