using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinnerParty
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;

        public Form1()
        {
            InitializeComponent();

            dinnerParty = new DinnerParty() { NumberOfPeople = 5 };
            dinnerParty.SetHalthyOption(HealtyhBox.Checked);
            dinnerParty.CalculateCostOfDecorations(FancyBox.Checked);
            DisplayDinnerPartyCost();
        }

        public void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.CalculateCost(HealtyhBox.Checked);
            label3.Text = Cost.ToString("c");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)numericUpDown1.Value;
            DisplayDinnerPartyCost();
        }

        private void FancyBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.CalculateCostOfDecorations(FancyBox.Checked);
            DisplayDinnerPartyCost();
        }

        private void HealtyhBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.SetHalthyOption(HealtyhBox.Checked);
            DisplayDinnerPartyCost();
        }
    }
}
