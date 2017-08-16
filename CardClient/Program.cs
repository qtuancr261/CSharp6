using System;
using static System.Console;
using CardLib;
namespace CardClient
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Deck myDeck = new Deck();
            myDeck.Shuffle();
            for (int i = 0; i < 52; i++)
                WriteLine(myDeck.GetCard(i).ToString());
        }
    }
}
