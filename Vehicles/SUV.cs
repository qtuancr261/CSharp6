using System;
using static System.Console;

namespace Vehicles
{
    public class SUV : ACar, IPassengerCarry
    {
        public SUV() : base()
        {
            WriteLine("SUV default constructor");
        }
        public override void GetInfo()
        {
            WriteLine("SUV CAR");
        }

    }
}
