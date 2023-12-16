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
        public static LoginRegistrViewModel loginRegistrViewModel;
        public static Entrance_Window entrance_Window = Entrance_Window.entrance_Window;
        readonly public DataBaseModel dbm = new DataBaseModel("Data Source=_MELOMANUSHKA_;Initial Catalog=Praktika;Integrated Security=True");
        public LoginRegistrViewModel()
        {
            loginRegistrViewModel = this;
            LoginCommand = new RelayCommand();
        }


        private string login;
        public string Login
        {
            get => login;
            set
            {
                login = value;
                OnPropertyChanged(nameof(Login));
            }
        }


        private string password;
        public string Password
        {
            get => password;
            set
            {
                password = value;
                OnPropertyChanged(nameof(Password));
            }
        }


        private string errorMessage;
        public string ErrorMessage
        {
            get => errorMessage;
            set
            {
                errorMessage = value;
                OnPropertyChanged(nameof(ErrorMessage));
            }
        }


        private string firstName;
        public string FirstName
        {
            get => firstName;
            set
            {
                firstName = value;
                OnPropertyChanged(nameof(FirstName));
            }
        }


        private string lastName;
        public string LastName
        {
            get => lastName;
            set
            {
                lastName = value;
                OnPropertyChanged(nameof(LastName));
            }
        }


        private string firstPasswordReg;
        public string FirstPasswordReg
        {
            get => firstPasswordReg;
            set
            {
                firstPasswordReg = value;
                OnPropertyChanged(nameof(FirstPasswordReg));
            }
        }


        private string secondPasswordForSignUp;
        public string SecondPasswordForSignUp
        {
            get => secondPasswordForSignUp;
            set
            {
                secondPasswordForSignUp = value;
                OnPropertyChanged(nameof(SecondPasswordForSignUp));
            }
        }

        public ICommand LoginCommand { get; private set; }


        private void SignIn(object parameter)
        {
            if (dbm.IsValidLogin(Login, Password))
            {
                CurrentUser = dbLogic.GetUserByLogin(Login);
                PersonalAccountView window = new PersonalAccountView();
                window.Show();
                entrance_Window.Close();
            }
            else
            {
                ErrorMessage = "Неправильный логин или пароль";
            }
        }

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
