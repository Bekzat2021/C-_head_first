using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetiredJersey
{
    class JerseyNumber
    {
        public string Player { get; private set; }
        public int RetiredYear { get; private set; }

        public JerseyNumber(string player, int numberRetired)
        {
            Player = player;
            RetiredYear = numberRetired;
        }
    }
}
