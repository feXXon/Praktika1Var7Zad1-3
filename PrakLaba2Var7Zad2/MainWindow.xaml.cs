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

namespace PrakLaba2Var7Zad2
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
            int seconds;
            if (int.TryParse(txtSeconds.Text, out seconds))
            {
                if (seconds >= 0)
                {
                    int hours = seconds / 3600;
                    txtHours.Text = hours.ToString();
                    lblError.Content = "";
                }
                else
                {
                    lblError.Content = "Не может быть отрицательным";
                }
            }
            else
            {
                lblError.Content = "Введите число";
            }
        }
    }
}
