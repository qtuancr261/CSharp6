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
            Console.WriteLine($"The sum of four values: 110, 520, 78, -120  is : {SumParaArrays(110, 520, 78, -120)}"); // a new feature from C# 6.0 
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
        public static double SumArray(double[] array)
        {
            return 4.5;
        }
    }
}
