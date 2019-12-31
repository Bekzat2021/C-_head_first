using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sloppy_Joe
{
    class MenuMaker
    {
        public Random randomizer;

        string[] Meats = { "Roast beef", "Salami", "Turkey", "Ham", "Pastrami" };

        string[] Condiments = {"yellow mustard", "brown mustard", "honey mustard", "amyo",
                                "relish", "french dressing"};

        string[] Breads = { "rye", "white", "wheat", "pumpernickel", "italian bread", "a roll" };

        public string GetMenuItem()
        {
            string randomMeat = Meats[randomizer.Next(Meats.Length)];
            string randomCondiments = Condiments[randomizer.Next(Condiments.Length)];
            string randomBreads = Breads[randomizer.Next(Breads.Length)];
            return randomMeat + " with " + randomCondiments + " on " + randomBreads;
        }
    }
}
