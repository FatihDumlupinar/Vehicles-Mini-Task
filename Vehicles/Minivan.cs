using System;

namespace Vehicles
{
    public class Minivan : Vehicle
    {
        #region Ctor

        public Minivan()
        {
        }

        public Minivan(bool dualSlidingDoors) 
        {
            DualSlidingDoors = dualSlidingDoors;
        }

        #endregion

        #region Getters&Setters

        public bool DualSlidingDoors { get; set; }

        #endregion

        #region Functions

        public static void OpenDualSlidingDoors()
        {
            Console.WriteLine("Dual Sliding Doors opening..");
        }

        public override string ToString()
        {
            return $"{Brand}-{Model}-{Year}-{DualSlidingDoors}";
        }

        #endregion

    }
}
