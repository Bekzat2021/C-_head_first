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

            dinnerParty = new DinnerParty((int)numericUpDown1.Value, HealtyhBox.Checked, FancyBox.Checked);
            
        }

        private void FancyBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.FancyDecorations = FancyBox.Checked;
            DisplayDinnerPartyCost();
        }
        
        private void HealtyhBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.HealthyOption = HealtyhBox.Checked;
            DisplayDinnerPartyCost();
        }
        
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)numericUpDown1.Value;
            DisplayDinnerPartyCost();
        }

        private void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.Cost;
            label3.Text = Cost.ToString("c");
        }
    }
}
