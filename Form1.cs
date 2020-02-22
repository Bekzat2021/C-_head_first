using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SimpleTextEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string name;

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Open text file";
            openFileDialog1.InitialDirectory = @"D:\Videos\программирование\c#\C# 101";
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt";
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                name = openFileDialog1.FileName;
                textBox1.Clear();
                textBox1.Text = File.ReadAllText(name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Save text file";
            saveFileDialog1.Filter= "Text Files (*.txt)|*.txt";
            if (saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                name = saveFileDialog1.FileName;
                File.WriteAllText(name, textBox1.Text);
            }
        }
    }
}
