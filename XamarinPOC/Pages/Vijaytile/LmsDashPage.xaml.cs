using MvvmCross.Forms.Views;
using System.Collections.Generic;
using Xamarin.Forms.Xaml;
using SkiaSharp;
using Entry = Microcharts.Entry;
using Microcharts;

namespace XamarinPOC.Pages.Vijaytile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LmsDashPage : MvxContentPage
    {
        List<Entry> entries = new List<Entry>
        {
            new Entry(200)
            {
                Color=SKColor.Parse("#FF1943"),
                Label ="Annual Leave",
                ValueLabel = "200",
            },
            new Entry(400)
            {
                Color = SKColor.Parse("00BFFF"),
                Label = "Personal leave",
                ValueLabel = "400"
            },
            new Entry(-100)
            {
                Color =  SKColor.Parse("#00CED1"),
                Label = "Special Leave",
                ValueLabel = "-100"
            },
            };

        public LmsDashPage()
        {
            InitializeComponent();
            //var chart = new BarChart() { Entries = entries };
            Chart4.Chart = new BarChart() { Entries = entries };

        }


    }
}