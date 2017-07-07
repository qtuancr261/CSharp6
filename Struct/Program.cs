using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Struct
{
    class Program
    {
        static int Main(string[] args)
        {
            Soldier marine;
            marine.name = "TQT";
            marine.occupation = "Rear Admiral";
            Console.WriteLine($"Marine infomation: {marine.FullName()}");
            return 0; // just like old times C++ :v
        }
    }
}
