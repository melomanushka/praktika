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

namespace praktika.Views
{
    /// <summary>
    /// Логика взаимодействия для Login_Page.xaml
    /// </summary>
    public partial class Login_Page : Page
    {
        public Login_Page()
        {
            InitializeComponent();
        }

        private void nextPageButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Registration_Page());
        }
        private void btn(object sender, RoutedEventArgs e)
        {
            Home home = new Home();
            home.Show();
        }
    }
}
