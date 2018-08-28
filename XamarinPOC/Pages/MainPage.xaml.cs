using MvvmCross.Forms.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinPOC.Models;
using XamarinPOC.ViewModels;

namespace XamarinPOC.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : MvxContentPage
    {
        MainViewModel vm;
		public MainPage ()
		{
             vm = new MainViewModel();

            vm.DisplayAlertPrompt += () => DisplayAlert("Error", "Invalid Login, try again", "OK");

            InitializeComponent ();


        }

    }
}