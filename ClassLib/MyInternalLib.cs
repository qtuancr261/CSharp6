using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    class MyInternalLib
    {
        public int Sub(ref int a, ref int b) => a - b;
    }
}
