using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using MvvmCross.Forms.Core;
using MvvmCross.Forms.Platforms.Ios.Core;
using MvvmCross.Platforms.Ios.Core;
using MvvmCross.ViewModels;
using UIKit;

namespace XamarinPOC.iOS
{
    public class Setup : MvxFormsIosSetup
    {
        protected override IMvxApplication CreateApp()
        {
            return (IMvxApplication)new CoreApp();
        }
       

        public Setup()
        {
            
        }


        public override IEnumerable<Assembly> GetViewAssemblies()
        {
            return new List<Assembly>(base.GetViewAssemblies().Union(new[] { typeof(CoreApp).GetTypeInfo().Assembly }));
        }

      


        //Creating Forms Application
        protected override Xamarin.Forms.Application CreateFormsApplication()
        {
            return new App();
        }
    }
}
