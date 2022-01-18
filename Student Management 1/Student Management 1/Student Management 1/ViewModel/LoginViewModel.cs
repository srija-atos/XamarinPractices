using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Student_Management_1.ViewModel
{
    public class LoginViewModel : BaseViewModel
    {
        public LoginViewModel()
        {



        }

        private string _userName;
        private string _password;


        private bool IsEnabled;

        public string UserName
        {
            get => _userName;
            set
            {
                if (value != _userName)
                {
                    _userName = value;
                    OnPropertyChanged(nameof(UserName));
                }
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                if (value != _password)
                {
                    _password = value;
                    OnPropertyChanged(nameof(Password));
                }
            }
        }





        public ICommand LoginCommand
        {
            get
            {
                return new Command(async () =>
                {
                    IsEnabled = false;

                    await Application.Current.MainPage.Navigation.PushAsync(new ViewFlyoutPage());
                    await Task.Delay(500);

                    IsEnabled = true;

                });

            }
        }
    }
}

