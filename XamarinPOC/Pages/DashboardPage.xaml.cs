using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MvvmCross.Forms.Views;
using XamarinPOC.Models;
using XamarinPOC.ViewModels;

namespace XamarinPOC.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DashboardPage : MvxContentPage
    {
		public DashboardPage()
		{
			InitializeComponent ();

        }
    }
}