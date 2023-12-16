using praktika.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace praktika.ViewModels
{
    internal class UserViewModel : INotifyPropertyChanged
    {
        #region OnPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        //private string selectedStyle;

        private int id;
        public int Id 
        {
            get => id;           
            set 
            { 
                id = value;
                OnPropertyChanged(nameof(Id));
            } 
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

        private UserModel selectedUser;
        public UserModel SelectedUser
        {
            get => selectedUser;
            set
            {
                if (selectedUser != value)
                {
                    selectedUser = value;
                    OnPropertyChanged(nameof(SelectedUser));
                }
            }
        }


        private UserModel CurrentUser;
        public int CurrentAccessLevel
        {
            get => CurrentUser.AccessLevel;
        }
        private void LoadCurrentUser()
        {
            LoginRegistrViewModel loginRegistrViewModel = LoginRegistrViewModel.loginRegistrViewModel;
            CurrentUser = loginRegistrViewModel.CurrentUser;
        }

        private int accessLevel;
        public int AccessLevel
        {
            get => accessLevel;
            set
            {
                if (InputValidCheckAccessLevel(value))
                {
                    accessLevel = value;
                    OnPropertyChanged(nameof(AccessLevel));
                }
                else
                {
                    accessLevel = 2;
                }
            }
        }
        private bool InputValidCheckAccessLevel(int accessLevel)
        {
            return accessLevel == 1 || accessLevel == 2;
        }


        private Visibility  levelVisibility = Visibility.Hidden;
        public Visibility LevelVisibility
        {
            get => levelVisibility;
            set
            {
                levelVisibility = value;
                OnPropertyChanged(nameof(LevelVisibility));
            }
        }
    
        
    }
}
