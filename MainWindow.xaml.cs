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

namespace Fibonacci_Sequence_Calculation
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            N.Focus();
        }

        private void CALC_Click(object sender, RoutedEventArgs e)
        {
            if (N.Text!="")
            {
                int n = Convert.ToInt32(N.Text);
                if (n==1||n==2)
                {
                    RESULT.Content = "1";
                }
                else
                {
                    ulong p2 = 1, p1 = 1, res = 0;
                    for (int i = 2; i < n; i++)
                    {
                        res = p1 + p2;
                        p2 = p1;
                        p1 = res;
                    }
                    RESULT.Content = res;
                }
            }
            else
            {
                MessageBox.Show("PLEASE INPUT THE N!!!", "ERROR:", MessageBoxButton.OK, MessageBoxImage.Error);
                N.Focus();
            }
        }
    }
}
