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
            Soldier marine = new Soldier { name = "TQT", occupation = "Rear Admiral", yearsOfService = 15};
            Console.WriteLine($"Marine infomation: {marine.FullName()}");
            Soldier formermarine = new Soldier { };
            DelegateFunct.ptrFuntion setSoldier = new DelegateFunct.ptrFuntion(DelegateFunct.InputSoldierInfo); 
            setSoldier(ref formermarine);
            setSoldier = DelegateFunct.OutputSoldierInfo;
            Console.WriteLine("-----------------------------------------");
            setSoldier(ref formermarine);
            return 0; // just like old times C++ :v
        }
    }
}
