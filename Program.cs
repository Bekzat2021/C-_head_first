using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Owner owner = new Owner();
            Safe safe = new Safe();
            JewelTheif jewelTheif = new JewelTheif();
            jewelTheif.OpenSafe(safe, owner);
            Console.ReadKey();
        }
    }
}
