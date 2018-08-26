using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using MvvmCross.Forms.Platforms.Android.Core;
using MvvmCross.ViewModels;
using Xamarin.Forms;

namespace XamarinPOC.Droid
{
    public class Setup : MvxFormsAndroidSetup<CoreApp,App>
    {
        public Setup(){
            
        }

        protected override IMvxApplication CreateApp()
        {
            return (IMvxApplication)new CoreApp();
        }

        public override IEnumerable<Assembly> GetViewAssemblies()
        {
            return new List<Assembly>(base.GetViewAssemblies()
               .Union(new[] { typeof(CoreApp).GetTypeInfo().Assembly })
                .Except(new[] { this.GetType().Assembly })
                );
        }
        protected override Application CreateFormsApplication()
        {
            return new App();
        }
    }
}
