using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elephant
{
    class Elephant
    {
        public string name;
        public int EarSize;

        public void WhoIam()
        {
            MessageBox.Show("My ears are " + EarSize + " inches tall.", name + " says");
        }
    }
}
