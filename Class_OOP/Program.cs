using static System.Console;
using System;
namespace Class_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            APerson peter = new APerson();
            WriteLine(peter.GetName() + "\n-------");

            APerson mary = new APerson("Mary", 20, "London", "985563");
            WriteLine(mary.GetName() + "\n-------");

            APerson havok = new APerson("Havok");
            WriteLine(havok.GetName() + "\n-------");

            Author IvorHorton = new Author();
            WriteLine(IvorHorton.GetName() + "\n-------");

            Author Teddy = new Author("Teddy", 35);
            WriteLine(Teddy.GetName() + "\n-------");
        }
    }
}
