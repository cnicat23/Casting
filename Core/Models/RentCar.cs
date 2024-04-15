using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class RentCar
    {
        private Car[] _cars = { };
        private Truck[] _trucks = { };
        private Vehicle[] _vehicles = { };

        public int CarLimit { get; set; }
        public int TruckLimit { get; set; }

        public void AddVehicle(Vehicle vehicle)
        {
            if (vehicle is Truck)
            {
                if (_trucks.Length < TruckLimit)
                {
                    Array.Resize(ref _trucks, _trucks.Length + 1);
                    _trucks[_trucks.Length - 1] = (Truck)vehicle;

                    Array.Resize(ref _vehicles, _vehicles.Length + 1);
                    _vehicles[_vehicles.Length - 1] = vehicle;
                }
                else
                {
                    Console.WriteLine("Truck limiti ashildi");
                }
            }




            if (vehicle is Car)
            {
                if (_cars.Length < CarLimit)
                {
                    Array.Resize(ref _cars, _cars.Length + 1);
                    _cars[_cars.Length - 1] = (Car)vehicle;

                    Array.Resize(ref _vehicles, _vehicles.Length + 1);
                    _vehicles[_vehicles.Length - 1] = vehicle;
                }
                else
                {
                    Console.WriteLine("Car limiti ashildi");
                }
            }

        }

        public void ShowAllVehicles()
        {
            foreach (Vehicle item in _vehicles)
            {
                if (item is Car)
                {
                    item.ShowInfo();
                    Console.WriteLine("----------------------------");
                }
                else if (item is Truck)
                {
                    item.ShowInfo();
                }
            }
        }


    }
}
