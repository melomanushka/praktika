using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        private string login;
        private string password;
        private string errorMessage;
        private string firstName;
        private string lastName;
        private string firstPasswordForSignUp;
        private string secondPasswordForSignUp;

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
