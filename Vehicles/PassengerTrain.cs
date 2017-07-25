using System;
using static System.Console;
namespace Vehicles
{
    public class PassengerTrain : ATrain, IPassengerCarry
    {
        public PassengerTrain() : base()
        {
            WriteLine("PassengerTrain default constructor");
        }
        public override void GetInfo()
        {
            WriteLine("PASSENGER TRAIN");
        }
    }
}
