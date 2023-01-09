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

namespace WorldSkills_WPF
{
    /// <summary>
    /// Логика взаимодействия для HotelsPage.xaml
    /// </summary>
    public partial class HotelsPage : Page
    {
        public HotelsPage()
        {
            InitializeComponent();
        }

        private void Page_1(object sender, RoutedEventArgs e)
        {
           Manager.MainFrame.Navigate(new Page_1());
        }

        private void Page_2(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Page_2());
        }

        private void Page_3(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Page_3());
        }

        private void Page_4(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Page_4());
        }

        private void Page_5(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Page_5());
        }

        private void Page_6(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Page_6());
        }
    }
}
