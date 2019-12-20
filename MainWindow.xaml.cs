using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PracticeUsingIfElse
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (EnableLabelChange.IsChecked==true)
            {
                if (Label1.HorizontalAlignment==HorizontalAlignment.Right)
                {
                    Label1.HorizontalAlignment = HorizontalAlignment.Left;
                    Label1.Text = "Left";
                }
                else
                {
                    Label1.HorizontalAlignment = HorizontalAlignment.Right;
                    Label1.Text = "Right";
                }
            }
            else
            {
                Label1.Text = "Text changing is disabled";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
