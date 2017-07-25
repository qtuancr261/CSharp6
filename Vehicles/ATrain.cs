using System;
using static System.Console;

namespace Vehicles
{
    public abstract class ATrain : AVehicle
    {
        public ATrain() : base()
        {
            WriteLine($"ATrain default constructor");
        }
    }
}
