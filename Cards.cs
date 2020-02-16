using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsAndCollections
{
    class Cards
    {
        public Suits Suit { get; set; }
        public Values Value { get; set; }

        public Cards(Suits suits, Values value)
        {
            this.Suit = suits;
            this.Value = value;
        }

        public string Name
        {
            get
            {
                return Value.ToString() + " of " + Suit.ToString();
            }
        }
    }
}
