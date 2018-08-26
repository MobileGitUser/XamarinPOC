using System;
using System.Threading.Tasks;
using MvvmCross.ViewModels;

namespace XamarinPOC.ViewModels
{
    public class WelcomeViewModel :MvxViewModel
    {
        public WelcomeViewModel()
        {
        }


        public override Task Initialize()
        {
            //TODO: Add logic here
            return base.Initialize();
        }


        private string _eyText = "Hello EY";
        public string EYText
        {
            get { return _eyText; }
            set { SetProperty(ref _eyText, value); }
        }
    }
}
