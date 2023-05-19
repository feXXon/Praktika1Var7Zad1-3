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

namespace PrakLaba2Var7Zad3
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
            int day;
            if (int.TryParse(txtDay.Text, out day))
            {
                if (day >= 1 && day <= 365)
                {
                    int weekday = (3 + day) % 7;
                    txtWeekday.Text = weekday.ToString();
                    lblError.Content = "";
                }
                else
                {
                    lblError.Content = "В году 365 дней";
                }
            }
            else
            {
                lblError.Content = "Введите число";
            }
        }
    }
}
