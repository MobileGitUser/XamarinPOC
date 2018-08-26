using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace XamarinPOC.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        public MainViewModel()
        {
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
