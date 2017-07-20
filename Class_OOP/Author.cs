using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Class_OOP
{
    class Author : APerson
    {
        public Author()
        {
            // default constructor
            WriteLine("Author default constructor");
        }
        public Author(String initName = "No Name", int initAge = 0, String initAddress = "No Where", String initPhoneNum = "0000")
            : base(initName, initAge, initAddress, initPhoneNum)
        {
            WriteLine("Author constructor provided by user");
        }
    }
}
