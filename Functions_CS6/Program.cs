using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions_CS6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing github extension on Visual Studio 2017");
            Console.WriteLine($"The sum of four values: 110, 520, 78, -120  is : {SumParaArrays(110, 520, 78, -120)}  {CS6.NewFeaturesCS6.StringInterpolation}"); // a new feature from C# 6.0 
            Console.WriteLine("Or we can use this normal method: " + SumParaArrays(110, 520, 78, -120)); // normal method
            double[] arrayA = new double[4];
            foreach (double value in arrayA)
            {
                Console.Write($"{value} - > ");
                //value = Convert.ToDouble(Console.ReadLine());
                // foreach in C# is a read-only loop, you cannot change the values of any of the elements
            }
            InputArray(arrayA);
            Console.WriteLine($"The sum of all values in arrayA: {SumArray(arrayA)}");
            //---------------------------------------------------------------------------------------------------------------
            short aNum = 10, bNum = 22;
            PassBy(aNum, bNum);
            Console.WriteLine($"Now OUTSIDE: {aNum} | {bNum}");
            PassBy(ref aNum, ref bNum); // C# differs from C++ - you must include ref keywork with the argument
            Console.WriteLine($"Now OUTSIDE: {aNum} | {bNum}");

        }
        public static int SumParaArrays(params int[] vals)
        {
            int sum = 0;
            foreach (int val in vals)
            {
                sum += val;
            }
            return sum;
        }
        public static void InputArray(double[] array)
        {
            Console.WriteLine("INPUT>>>>>>>>>");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Input element [{i}]: ");
                array[i] = Convert.ToDouble(Console.ReadLine());
            }

        }
        public static double SumArray(double[] array)
        {
            double sum = 0;
            for(int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
        public static void OutPut2Value(short aValue, short bValue) => Console.WriteLine($"{aValue} | {bValue}"); // new Features from C# 6.0 - expression bodied method
        public static void PassBy(short aValue, short bValue)
        {
            Console.Write($"Original Values is: ");
            OutPut2Value(aValue, bValue);
            aValue += 100;
            bValue -= 100;
            Console.WriteLine($"Temporary Values after being passed by value in PassByValue funtion: {aValue} | {bValue}  - INSIDE");
        }
        public static void PassBy(ref short aValue, ref short bValue)
        {
            Console.Write($"Original Values is: ");
            OutPut2Value(aValue, bValue);
            aValue += 100;
            bValue -= 100;
            Console.WriteLine($"Values after being passed by reference in PassByRef funtion: {aValue} | {bValue}  - INSIDE");
        }
    }
}
