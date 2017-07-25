using System;
using static System.Console;

namespace Vehicles
{
    public class PickupCar : ACar, IHeavyLoadCarrier
    {
        public PickupCar() : base()
        {
            WriteLine("Pickup Car default constructor");
        }
        public override void GetInfo()
        {
            WriteLine("PICKUP CAR");
        }
    }
}
