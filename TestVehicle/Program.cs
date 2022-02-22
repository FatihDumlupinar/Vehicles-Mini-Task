using System;
using Vehicles;

namespace TestVehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            Minivan vehicle = new();
            vehicle.Brand = "Kia";
            vehicle.Model = "Sedona";
            vehicle.Year = "2021";
            vehicle.DualSlidingDoors = true;

            Console.WriteLine(vehicle.ToString());

            vehicle.StartDrive();
            vehicle.StopDrive();
        }
    }
}
