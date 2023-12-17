using GalaSoft.MvvmLight.Command;
using praktika.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace praktika.ViewModels
{
    internal class HomeViewModel : INotifyPropertyChanged
    {
        #region OnPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        private bool isPage1Selected = true;
        private bool isPage2Selected;
        private bool isPage3Selected;
        private object currentPage;

        public ICommand ChangePageCommand { get; }

        public bool IsPage1Selected
        {
            get { return isPage1Selected; }
            set
            {
                isPage1Selected = value;
                OnPropertyChanged(nameof(IsPage1Selected));
                if (value)
                    CurrentPage = new HomePage();
            }
        }

        public bool IsPage2Selected
        {
            get { return isPage2Selected; }
            set
            {
                isPage2Selected = value;
                OnPropertyChanged(nameof(IsPage2Selected));
                if (value)
                    CurrentPage = new UserListPage();
            }
        }

        public bool IsPage3Selected
        {
            get { return isPage3Selected; }
            set
            {
                isPage3Selected = value;
                OnPropertyChanged(nameof(IsPage3Selected));
                if (value)
                    CurrentPage = new Settings();
            }
        }

        public object CurrentPage
        {
            get { return currentPage; }
            set
            {
                currentPage = value;
                OnPropertyChanged(nameof(CurrentPage));
            }
        }

        public HomeViewModel()
        {
            ChangePageCommand = new RelayCommand(ChangePage);
            CurrentPage = new HomePage();
            IsPage1Selected = true;
        }

        private void ChangePage(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
