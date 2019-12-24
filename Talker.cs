using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Talker
{
    class Talker
    {
        public static int BlahBlahBlah(string thingToSay, int numberOfTimer)
        {
            string finalString = "";
            for (int count = 0; count < numberOfTimer; count++)
            {
                finalString = finalString + thingToSay + "\n";
            }
            MessageBox.Show(finalString);
            return finalString.Length;
        }
    }
}
