using System;
namespace Struct
{
    struct Soldier
    {
        public string name;
        public string occupation;
        public int yearsOfService;
        public string FullName() =>  occupation + " " + name; 
    }
}