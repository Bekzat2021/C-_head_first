using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample2
{
    class TallGuy : IClown
    { 
        public string Name;
        public int Height;

        public void TalkAboutYourself()
        {
            Console.WriteLine("My name is " + Name + " and I'm " + Height + " inches tall.");
        }

        public void Honk()
        {
            
        }

        public string FunnyThingIHave { get; }
    }
}
