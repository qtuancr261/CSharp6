using System;
using static System.Console;

namespace Vehicles
{
    public abstract class AVehicle
    {
        public AVehicle()
        {
            WriteLine("" +
                "AVehicle default constructor");
        }
        public abstract void GetInfo();
    }
}
