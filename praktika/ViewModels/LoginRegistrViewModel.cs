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
    internal class LoginRegistrViewModel : INotifyPropertyChanged
    {
        #region OnPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        //public static LoginRegistrViewModel loginRegistrViewModel;
        //public static Entrance_Window entrance_Window = Entrance_Window.entrance_Window;
        //readonly public DataBaseModel dbm = new DataBaseModel("Data Source=_MELOMANUSHKA_;Initial Catalog=Praktika;Integrated Security=True");
        //public LoginRegistrViewModel()
        //{
        //    loginRegistrViewModel = this;
        //    LoginCommand = new RelayCommand();
        //}

        private UserModel currentUser; 
        public UserModel CurrentUser
        {
            get => currentUser;
            private set
            {
                currentUser = value;
                OnPropertyChanged(nameof(CurrentUser));
            }
        }

        public ICommand LoginCommand { get; private set; }

        //private void SignUpContinue(object parameter)
        //{
        //    if (dbLogic.LoginExists(Login))
        //    {
        //        ErrorMessage = "Такой пользователь уже существует";
        //    }
        //    else if (FirstPasswordForSignUp != SecondPasswordForSignUp)
        //    {
        //        ErrorMessage = "Первый пароль не совпадает с вторым";
        //    }
        //    else
        //    {
        //        ErrorMessage = "";
        //        SwapVisibility();
        //    }
        //}

        //private void SignUp(object parameter)
        //{
        //    dbLogic.CreateUser(Login, FirstPasswordForSignUp, FirstName, LastName, MiddleName);
        //    SwapTabItemOnSignIn();
        //    SwapVisibility();
        //    ClearFields();
        //    string message = "Пользователь зарегистрирован. Войдите в аккаунт.";
        //    MessageBoxViewModel messageBox = new MessageBoxViewModel();
        //    messageBox.ShowMessageBox(message);
        //}

    }
}
