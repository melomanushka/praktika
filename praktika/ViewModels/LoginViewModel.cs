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
        string connect = DataBaseModel.Connect;

        public LoginViewModel()
        {
            loginviewnodel = this;
            LoginCommand = new RelayCommand(SignIn, CanSignIn);
        }

        private bool CanSignIn()
        {
            throw new NotImplementedException();
        }

        private void SignIn()
        {
            throw new NotImplementedException();
        }

        public ICommand LoginCommand { get; private set; }

        private void SignIn(object parameter)
        {
            if (dataBaseModel.IsValidLogin(loginmodel.Login, loginmodel.Password))
            {
                loginmodel.ErrorMessage = "Неправильный логин или пароль";
            }
            else
            {
                //CurrentUser = dbLogic.GetUserByLogin(loginmodel.Login);
                //PersonalAccountView window = new PersonalAccountView();
                //window.Show();
                loginView.Close();
            }
        }

        private bool CanSignIn(object parameter)
        {
            return !string.IsNullOrWhiteSpace(loginmodel.Login) && !string.IsNullOrWhiteSpace(loginmodel.Password);
        }
    }
}
