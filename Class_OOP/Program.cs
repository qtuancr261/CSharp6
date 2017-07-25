using static System.Console;
using System;
using ClassLib;
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

            MyExternalLib lib = new MyExternalLib();

            int a = 10, b = 50;
            WriteLine($"ref a + ref b = {lib.SumRef(ref a, ref b)} => a = {a} | b = {b}");

            int c = 10, d = 50;
            WriteLine($"out c + out d = {lib.SumOut(out c, out d)} => c = {c} | d = {d}");

            MyStruct strt = new MyStruct();
            strt.num = 10;
            MyStruct strtCpy = strt;
            strtCpy.num = 20;
            WriteLine($"struct: str.num = {strt.num} | strCpy.num = {strtCpy.num}");

            MyExternalLib libCpy = lib;
            lib.info = "Thieu Quang Tuan";
            libCpy.info = "Windows 10 Creator";
            WriteLine($"class: lib.info = {lib.info} | libCpy.info = {libCpy.info}");
        }
    }
}
