using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class MyExternalLib
    {
        public string info;
        public int SumRef(ref int a , ref int b)
        {
            a *= 2;
            b *= 2;
            return a + b;
        }
        public int SumOut(out int a, out int b)
        {
            a = 10;
            b = 20;
            return a + b;
        }
    }
}
