using System;
using static System.Console;

namespace Vehicles
{
    public class FreightTrain : ATrain, IHeavyLoadCarrier
    {
        public FreightTrain() : base() // actually, if you dont specify a construtor initializer for a constructor
            // the compiler will adds one for you: base()
        {
            WriteLine("FreightTrain default constructor");
        }
        public override void GetInfo()
        {
            WriteLine("FREIGHT TRAIN");
        }
    }
}
