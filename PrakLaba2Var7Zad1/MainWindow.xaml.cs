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

namespace PrakLaba2Var7Zad1
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
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int number;
            if (int.TryParse(txtNumber.Text, out number))
            {
                if (number >= 10 && number <= 99)
                {
                    int digit1 = number / 10;
                    int digit2 = number % 10;
                    int sum = digit1 + digit2;
                    int product = digit1 * digit2;
                    txtSum.Text = sum.ToString();
                    txtProduct.Text = product.ToString();
                    lblError.Content = "";
                }
                else
                {
                    lblError.Content = "Необходимо двузначное число";
                }
            }
            else
            {
                lblError.Content = "Введите число";
            }
        }
    }
}
