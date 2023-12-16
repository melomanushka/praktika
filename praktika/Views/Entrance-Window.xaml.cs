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
using System.Windows.Shapes;

namespace praktika.Views
{
    /// <summary>
    /// Логика взаимодействия для Entrance_Window.xaml
    /// </summary>
    public partial class Entrance_Window : Window
    {
        public static Entrance_Window entrance_Window;
        private readonly LoginRegistrViewModel loginRegistrViewModel;
        public Entrance_Window()
        {
            InitializeComponent();
            mainFrame.Content = new Login_Page();
            loginRegistrViewModel = new LoginRegistrViewModel();
            DataContext = loginRegistrViewModel;
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void btnclose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void btnmin_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
    }
}
