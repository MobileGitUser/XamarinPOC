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
        private List<String> productArrayList;
        private String[] listItems = {   "Abin"," Arjun",  "Archana", "Basheer", "Chandrika",
            "Ravi", "Ruby", "Saket",  "Sibinesh", "Sreejith", "Sundeep", "Vijay" };

        //private String[] listItems = {"Temp converter","Bp Converter","Glucose converter", "Distance converter", "Volume Converter" };

        public DashboardPage()
		{
            NavigationPage.SetHasBackButton(this, true);

            InitializeComponent();

            productArrayList = new List<String>(listItems);

            gridLayout.RowDefinitions.Add(new RowDefinition());
            gridLayout.RowDefinitions.Add(new RowDefinition());
            gridLayout.ColumnDefinitions.Add(new ColumnDefinition());
            gridLayout.ColumnDefinitions.Add(new ColumnDefinition());
            gridLayout.ColumnDefinitions.Add(new ColumnDefinition());
            TapGestureRecognizer tap = new TapGestureRecognizer();
            tap.Tapped += (object sender, EventArgs e) => {
                //DisplayAlert("", "Item selected", "ok");
            };

            var productIndex = 0;
            for (int rowIndex = 0; rowIndex < 4; rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < 3; columnIndex++)
                {
                    if (productIndex >= productArrayList.Count)
                    {
                        break;
                    }
                    var product = productArrayList[productIndex];
                    productIndex += 1;
                    var button = new Button
                    {
                        Text = product,
                        VerticalOptions = LayoutOptions.Center,
                        HorizontalOptions = LayoutOptions.Center,
                        TextColor = Color.White,
                        BackgroundColor= Color.Brown,
                        FontSize = 12,
                        FontAttributes = FontAttributes.None,
                        WidthRequest = 100,
                        HeightRequest = 100,

                    };
                    button.Clicked += async (sender, args) =>
                    {
                        //await Navigation.PushAsync(new HelloXamlPage());
                         this.navigateToNextPage(sender,null);
                    };
                    gridLayout.Children.Add(button, columnIndex, rowIndex);
                }
            }
            //gridLayout.GestureRecognizers.Add(tap);

        }

        private void navigateToNextPage(object sender, EventArgs e)
        {
            //DisplayAlert("", "Item selected", "ok");

            switch ((sender as Button).Text)
            {
                case "Abin":
                    //Do something
                    navigateToFirstTile(null);
                    break;
                case "Arjun":
                    //Do something
                   break;
            }
        }

        private async void navigateToFirstTile(EventArgs e)
        {
            //await Navigation.PushAsync(new SecondPage());
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}  

