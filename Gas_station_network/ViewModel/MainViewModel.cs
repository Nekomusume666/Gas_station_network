using Gas_station_network.Core;
using Gas_station_network.DataBase.Storage;
using Gas_station_network.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Gas_station_network.ViewModel
{
    class MainViewModel : ObservableObject
    {
        //public SelectionSheetViewModel SelectionSheetVM { get; set; }

        //private object _currentView;

        //public object CurrentView
        //{
        //    get { return _currentView; }
        //    set 
        //    { 
        //        _currentView = value; 
        //        OnPropertyChanged();
        //    }
        //}

        public MainViewModel() 
        {
            PersonStorage = new PersonStorage();
        }

        private string _username;
        private string _password;

        public string Username {
            get { return _username; }
            set 
            {
                _username = value;
                OnPropertyChanged("Username");
            }
        }
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged("Password");
            }
        }

        private readonly IPersonStorage PersonStorage;
        public ICommand Enter => new RelayCommand((obj) =>
        {
            if (PersonStorage.CheckPerson(Username, Password))
            {
                Model.Role role = PersonStorage.TakeRoleByLogin(Username);

                switch (role)
                {
                    case Model.Role.Client:
                    case Model.Role.Administrator:
                        SelectionSheetWindow selectionSheetWindow = new SelectionSheetWindow();
                        //selectionSheetWindow.Show();
                        Application.Current.MainWindow = selectionSheetWindow;
                        break;
                    case Model.Role.Technician:
                        break;
                    case Model.Role.Operator:
                        break;
                    case Model.Role.None:
                    default:
                        MessageBox.Show("Something wrong");
                        break;
                }

            }
            else MessageBox.Show("Неверные данные!");
        });


    }
}
