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
    /// Логика взаимодействия для Registration_Page.xaml
    /// </summary>
    public partial class Registration_Page : Page
    {
        public Registration_Page()
        {
            InitializeComponent();
        }

        bool isPressed = false;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Login_Page());
        }
    }
}
