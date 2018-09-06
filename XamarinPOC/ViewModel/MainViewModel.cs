using MvvmCross.Commands;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XamarinPOC.Models;
using System.ComponentModel;
using System.Diagnostics;
using XamarinPOC.Pages;
using XamarinPOC.Pages.Vijaytile;

namespace XamarinPOC.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        public Action DisplayAlertPrompt;
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        public MainViewModel()
        {
        }


        private string _entryEmail;
        public string EntryEmail
        {
            get { return _entryEmail; }
            set
            {
                _entryEmail = value;
                RaisePropertyChanged(() => EntryEmail);
            }
        }

        ///
        private string _entrypassword;
        public string EntryPassword
        {
            get { return _entrypassword; }
            set
            {
                _entrypassword = value;
                RaisePropertyChanged(() => EntryPassword);
            }
        }


        public MvxCommand _loginCommand;
        public IMvxCommand LoginCommand
        {
            get
            {
                return _loginCommand;
            }
        }

        public override void Start()
        {

            _loginCommand = new MvxCommand(() => StartLogin());
            base.Start();

        }

        private void StartLogin()
        {
            if(!string.IsNullOrEmpty(EntryEmail) && !string.IsNullOrEmpty(EntryPassword))
            {
                Debug.WriteLine("Filds are not empty");
                validateLoginAsync();
            }
            else
            {
                Debug.WriteLine("Filds are empty");
                App.Current.MainPage.DisplayAlert("", "Fields can't be empty", "Ok");

            }

        }

        private async void validateLoginAsync()
        {

            if (EntryEmail.Contains("@gmail.com"))
            {
                //App.Current.MainPage.DisplayAlert("Login", "Successfully Login", "Ok
                await App.Current.MainPage.Navigation.PushAsync(new LmsDashPage());


            }
            else
            {
                //DisplayAlertPrompt();
                App.Current.MainPage.DisplayAlert("Login", "Enter user name with @gmail.com", "Ok");
            }
        }


        private async void dummyNavigation()
        {
            await App.Current.MainPage.Navigation.PushAsync(new LmsDashPage());

        }

        public override Task Initialize()
        {
            //TODO: Add logic here
            return base.Initialize();
        }

       /* private string _eyText = "Hello EY";
        public string EYText
        {
            get { return _eyText; }
            set { SetProperty(ref _eyText, value); }
        }

        private string _eyText1 = "Hello EY1";
        public string EYText1
        {
            get { return _eyText1; }
            set { SetProperty(ref _eyText1, value); }
        }
        */
    }
}
