using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            while (Visible)
            {
                for (int i = 0; i < 254 && Visible; i++)
                {
                    this.BackColor = Color.FromArgb(i, 255 - i, i);
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(3);
                }
                for (int j = 254; j >= 0 && Visible; j--)
                {
                    this.BackColor = Color.FromArgb(j, 255 - j, j);
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(3);
                }
            }            
        }
    }
}
