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

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        private void button1_Click(object sender, RoutedEventArgs e) 
        {
            label1.Content = (e.Source as Button).Content; 
        }
        private void button5_Click(object sender, RoutedEventArgs e)
        {
            e.Handled = true;
            double x = 0, x1, x2;
            if (!double.TryParse(textBox1.Text, out x1) ||
                !double.TryParse(textBox2.Text, out x2)) 
            { 
                label2.Content = "= ERROR"; 
                return; 
            }
            switch (label1.Content as string) 
            {
                case "+":
                    x = x1 + x2; break;
                case "-": 
                    x = x1 - x2; break;
                case "x":
                    x = x1 * x2; break;
                case "/":
                    x = x1 / x2; break; 
            }
            label2.Content = "= " + x;
        }
    }

}
