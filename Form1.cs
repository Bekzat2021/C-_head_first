using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elephant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool swapped;

        Elephant lucinda = new Elephant { name = "Lucinda", EarSize = 33 };
        Elephant lloyd = new Elephant { name = "Lloyd", EarSize = 40 };

        private void button1_Click(object sender, EventArgs e)
        {
            lloyd.WhoIam();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lucinda.WhoIam();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Objects swapped!");
            swapped = !swapped;
            if (swapped)
            {
                Elephant temp = lloyd;
                lloyd = lucinda;
                lucinda = temp;
            }
            else
            {
                Elephant temp = lloyd;
                lloyd = lucinda;
                lucinda = temp;
            }
        }
    }
}
