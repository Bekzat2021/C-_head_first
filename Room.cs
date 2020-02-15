using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Room : Location
    {
        private string decoration;

        public Room(string name, string decoraton) : base(name)
        {
            this.decoration = decoration;
        }

        public override string Description
        {
            get
            {
                return base.Description + "You see " + decoration + ".";
            }
        }
    }
}
