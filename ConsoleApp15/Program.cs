using Core.Models;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Marka = "Bmw";
            car.Year = 2026;
            car.PassengerCapacity = 4;
            car.Model = "F30";

            Car car1 = new Car();
            car1.Marka = "Kia Rio";
            car1.Year = 2020;
            car1.PassengerCapacity = 4;
            car1.Model = "A10";


            Car car2 = new Car();
            car2.Marka = "Carolla";
            car2.Year = 2023;
            car2.PassengerCapacity = 4;
            car2.Model = "A1";


            Truck truck = new Truck();
            truck.Marka = "Kamaz";
            truck.Year = 2002;
            truck.CarryingCapacity = 76;
            truck.Model = "A555";

            Truck truck1 = new Truck();
            truck1.Marka = "Tir";
            truck1.Year = 1990;
            truck1.CarryingCapacity = 99;
            truck1.Model = "A55";

            Truck truck2 = new Truck();
            truck2.Marka = "Qazel";
            truck2.Year = 1999;
            truck2.CarryingCapacity = 20;
            truck2.Model = "A555";

            Truck truck3 = new Truck();
            truck3.Marka = "Qaz 31";
            truck3.Year = 1900;
            truck3.CarryingCapacity = 10;
            truck3.Model = "A00001";

            RentCar rentCar = new RentCar();
            rentCar.CarLimit = 2;
            rentCar.TruckLimit = 3;

            rentCar.AddVehicle(car);
            rentCar.AddVehicle(car1);
            //rentCar.AddVehicle(car2);

            rentCar.AddVehicle(truck);
            rentCar.AddVehicle(truck1);
            rentCar.AddVehicle(truck2);
            //rentCar.AddVehicle(truck3);

            rentCar.ShowAllVehicles();




        }
    }
}
