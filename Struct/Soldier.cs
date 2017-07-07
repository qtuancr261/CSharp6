using System;
namespace Struct
{
    struct Soldier
    {
        public string name;
        public string occupation;
        public string FullName() =>  occupation + " " + name; 
    }
}