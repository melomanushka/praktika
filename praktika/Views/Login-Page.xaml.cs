using praktika.ViewModels;
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
        public static Login_Page logP;
        private readonly LoginViewModel viewModel;
        public Login_Page()
        {
            InitializeComponent();
            logP = this;
            viewModel = new LoginViewModel();
            DataContext = viewModel;

        }

        private void nextPageButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Registration_Page());
        }
    }
}
