using System;
using static System.Console;

namespace Vehicles
{
    public abstract class ACar : AVehicle
    {
        public ACar() : base()
        {
            WriteLine("ACar default constructor");
        }
    }
}
