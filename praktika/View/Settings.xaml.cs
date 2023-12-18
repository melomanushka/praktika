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

namespace praktika.View
{
    /// <summary>
    /// Логика взаимодействия для Settings.xaml
    /// </summary>
    public partial class Settings : Page
    {
        public Settings()
        {
            InitializeComponent();
        }
        private void Theme_Change_Click(object sender, RoutedEventArgs e)
        {
            var currentTheme = Application.Current.Resources.MergedDictionaries[0];

            // Переключаем между темами
            if (currentTheme.Source.OriginalString == "Theme/WhiteTheme.xaml")
            {
                Application.Current.Resources.MergedDictionaries[0] = new ResourceDictionary { Source = new Uri("Theme/BlackTheme.xaml", UriKind.Relative) };
            }
            else
            {
                Application.Current.Resources.MergedDictionaries[0] = new ResourceDictionary { Source = new Uri("Theme/WhiteTheme.xaml", UriKind.Relative) };
            }
        }
    }
}
