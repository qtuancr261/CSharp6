using System;
using static System.Console;
namespace Vehicles
{
    public class CompactCar : ACar, IPassengerCarry
    {
        public CompactCar() : base()
        {
            WriteLine("CompactCar default constructor");
        }
        public override void GetInfo()
        {
            WriteLine("COMPACT CAR");
        }
    }
}
