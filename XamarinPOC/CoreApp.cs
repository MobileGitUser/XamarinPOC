using System;
using MvvmCross.IoC;
using MvvmCross.ViewModels;

namespace XamarinPOC
{
    public class CoreApp:MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            //Starting point of app
            RegisterAppStart<ViewModels.MainViewModel>();
        }
    }
}
