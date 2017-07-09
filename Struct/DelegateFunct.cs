using System;
namespace Struct
{
    class DelegateFunct
    {
        public delegate void ptrFuntion(ref Soldier marine); // function pointer in C#:v
        public static void InputSoldierInfo(ref Soldier marine)
        {
            Console.Write("Your name: ");
            marine.name = Console.ReadLine();
            Console.Write("You current occupation: ");
            marine.occupation = Console.ReadLine();
            Console.Write($"{marine.FullName()}, please input the year you began your duty and the year you finished(seperated with a comma): ");
            string inputYears = Console.ReadLine();
            int firstYear = Convert.ToInt16(inputYears.Substring(0, inputYears.IndexOf(',')));
            int lastYear = Convert.ToInt16(inputYears.Substring(inputYears.IndexOf(',') + 1));
            //Console.WriteLine($"{firstYear} {lastYear}");
            marine.yearsOfService = lastYear - firstYear;

        }
        public static void OutputSoldierInfo(ref Soldier marine)
        {
            Console.WriteLine("Marine Infomation:");
            Console.WriteLine($"Name: {marine.name}");
            Console.WriteLine($"Occupation: {marine.occupation}");
            Console.WriteLine($"Years of service: {marine.yearsOfService}");
        }
    }
}