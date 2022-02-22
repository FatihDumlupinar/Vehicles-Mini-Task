
using System;

namespace Vehicles
{
    public abstract class Vehicle
    {
        #region Ctor
        
        public Vehicle()
        {

        }

        protected Vehicle(string brand, string model, string year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }

        #endregion

        #region Getters&Setters
        
        public string Year { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }

        #endregion

        #region Functions
        
        public void StartDrive()
        {
            Console.WriteLine("Start Driving...");
        }

        public void StopDrive()
        {
            Console.WriteLine("Stop Driving...");
        }

        #endregion
    }
}
