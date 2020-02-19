using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreakfastForLumberjacks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Queue<Lumberjack> breakfastLine = new Queue<Lumberjack>();

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(LumberjackName.Text))
            {
                return;
            }
            breakfastLine.Enqueue(new Lumberjack(LumberjackName.Text));
            LumberjackName.Text = "";
            RedrawList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (breakfastLine.Count==0)
            {
                return;
            }
            Flapjack food;
            if (CrispyRb.Checked)
            {
                food = Flapjack.Crispy;
            }
            else if (SoggyRb.Checked)
            {
                food = Flapjack.Soggy;
            }
            else if (BrownedRb.Checked)
            {
                food = Flapjack.Browned;
            }
            else
            {
                food = Flapjack.Banana;
            }

            Lumberjack currentLumberJack = breakfastLine.Peek();
            currentLumberJack.TakeFlapjacks(food, (int)HowMany.Value);
            RedrawList();
        }

        private void RedrawList()
        {
            int number = 1;
            BreakfastLine.Items.Clear();
            foreach (Lumberjack lumberjack in breakfastLine)
            {
                BreakfastLine.Items.Add(number + ". " + lumberjack.Name);
                number++;
            }

            if (breakfastLine.Count==0)
            {
                groupBox1.Enabled = false;
                label3.Text = "";
            }
            else
            {
                groupBox1.Enabled = true;
                Lumberjack currentLumberjack = breakfastLine.Peek();
                label3.Text = currentLumberjack.Name + " has " + currentLumberjack.FlapjackCount + " flapjacks";
            }
        }

        private void nextLumberkack_Click(object sender, EventArgs e)
        {
            if (breakfastLine.Count==0)
            {
                return;
            }
            Lumberjack nextLumberjack = breakfastLine.Dequeue();
            nextLumberjack.EatFlapjacks();
            label3.Text = "";
            RedrawList();
        }
    }
}
