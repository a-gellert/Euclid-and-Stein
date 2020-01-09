using EuclidAndStein.Classes;
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

namespace EuclidAndStein
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

        private void Calculate(object sender, RoutedEventArgs e)
        {
            string numberStr = textBox.Text;
            int result;
            if (radioButton.IsChecked.Value)
            {
                result = Solver.EuclidGCD(numberStr);
                textBox1.Text = result.ToString();
                textBox2.Text = Solver.Time.ToString();
            }
            else
            {
                int[] num = Converter.ConvertToInt(numberStr);
                if (num.Length >= 2)
                {
                    textBox.Text = $"{num[0]}, {num[1]}";
                    result = Solver.SteinGCD(num[0], num[1]);
                    textBox1.Text = result.ToString();
                    textBox2.Text = Solver.Time.ToString();
                    return;
                }
                MessageBox.Show("Проверьте правильность введенных данных!");
            }
        }
    }
}
