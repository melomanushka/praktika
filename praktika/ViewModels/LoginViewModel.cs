using GalaSoft.MvvmLight.Command;
using praktika.Model;
using praktika.Models;
using praktika.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace praktika.ViewModels
{
    internal class LoginViewModel : INotifyPropertyChanged
    {
        #region OnPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        public static LoginViewModel loginviewnodel;
        public static LoginModel loginmodel = new LoginModel();
        public static LoginView loginView = new LoginView();
        public static DataBaseModel dataBaseModel = new DataBaseModel();
        //string connect = DataBaseModel.Connect;

        public UserModel currentUser;
        public UserModel CurrentUser
        {
            get => currentUser;
            private set
            {
                currentUser = value;
                OnPropertyChanged(nameof(CurrentUser));
            }
        }


        private string _login;
        public string Login
        {
            get { return _login; }
            set
            {
                _login = value;
                OnPropertyChanged(nameof(Login));
            }
        }


        private string _password;
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }


        private string _firstname;
        public string Firstname
        {
            get { return _firstname; }
            set
            {
                _firstname = value;
                OnPropertyChanged(nameof(Firstname));
            }
        }


        private string _lastname;
        public string Lastname
        {
            get { return _lastname; }
            set
            {
                _lastname = value;
                OnPropertyChanged(nameof(Lastname));
            }
        }


        private string _errorMessage;
        public string Error
        {
            get { return _errorMessage; }
            set
            {
                _errorMessage = value;
                OnPropertyChanged(nameof(Error));
            }
        }
        private bool _isViewVisible = true;
        public bool IsViewVisible
        {
            get
            {
                return _isViewVisible;
            }
            set
            {
                _isViewVisible = value;
                OnPropertyChanged(nameof(IsViewVisible));
            }
        }

        public LoginViewModel()
        {
            loginviewnodel = this;
            LoginCommand = new RelayCommand(SignIn, CanSignIn);
        }

        public ICommand LoginCommand { get; private set; }

        private void SignIn(object parameter)
        {
            if (dataBaseModel.IsValidLogin(Login, Password))
            {
                CurrentUser = dataBaseModel.GetUserByLogin(Login);
                HomeView homeView = new HomeView();
                homeView.Show();
                loginView.Close();
            }
            else
            {
                Error = "Неправильный логин или пароль";
            }
        }

        private bool CanSignIn(object obj)
        {
            bool validData;
            if (string.IsNullOrWhiteSpace(Login) || Login.Length < 3 ||
                Password == null || Password.Length < 3)
                validData = false;
            else
                validData = true;
            return validData;
        }
    }
}
