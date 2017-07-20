using System;
using static System.Console;
namespace Class_OOP
{
    class APerson
    {
        private String name;
        private int age;
        private String address;
        private string phoneNumber;

        /*public APerson()
        {
            // default constructor
            WriteLine("APerson default constructor");
        }*/
        public APerson(String initName = "No Name", int initAge = 0, String initAddress = "No Where", String initPhoneNum = "0000")
        {
            WriteLine("APerson constructor provided by user");
            name = initName;
            age = initAge;
            address = initAddress;
            phoneNumber = initPhoneNum;
        }
        public String GetName() => name;
        public void SetName(String newName) => name = newName;

    }
}
