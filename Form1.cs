using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fun
{
    public partial class Form1 : Form
    {
        Guy joe;
        Guy bob;
        int bank = 100;

        public void UpdateForm()
        {
            joesCahLabel.Text = joe.Name + " has $" + joe.Cash;
            bobsCashLabel.Text = bob.Name + " has $" + bob.Cash;
            bankCashLabel.Text = "The bank has $" + bank;
        }

        public Form1()
        {
            InitializeComponent();
            joe = new Guy() { Name = "Joe", Cash = 50 };
            bob = new Guy() { Name = "Bob", Cash = 100 };

            UpdateForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bank>=10)
            {
                bank -= joe.ReciveCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("The bank is out of money.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bank += bob.GiveCash(5);
            UpdateForm();
        }

        private void joeGivesToBob_Click(object sender, EventArgs e)
        {
            if (joe.Cash>=10)
            {
                bob.Cash+=joe.GiveCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show(joe.Name + " not enough money to give Bob");
            }
        }

        private void bobGivesToJoe_Click(object sender, EventArgs e)
        {
            if (bob.Cash>=5)
            {
                joe.Cash += bob.GiveCash(5);
                UpdateForm();
            }
            else
            {
                MessageBox.Show(bob.Name + " not enough money to give Joe");
            }
        }
    }
}
