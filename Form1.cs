using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MileageCalcilator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int startingMileage = 0;
        int endingMileage = 0;

        double milesTraveled = 0;
        double reimburseRate = 0.39;
        double amountOwned = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            startingMileage = (int)numericUpDown1.Value;
            endingMileage = (int)numericUpDown2.Value;

            if (startingMileage<endingMileage)
            {
                milesTraveled = endingMileage - startingMileage;
                amountOwned = milesTraveled *= reimburseRate;
                label4.Text = "$" + amountOwned;
            }
            else
            {
                MessageBox.Show("The starting mileage must be less " +
                    "than the ending mileage", "Cannot calculate mileage");
            }
        }
    }
}
