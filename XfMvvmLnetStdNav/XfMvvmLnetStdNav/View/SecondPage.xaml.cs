using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XfMvvmLnetStdNav.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SecondPage : ContentPage
    {
        public SecondPage()
        {
            InitializeComponent();
            BindingContext = App.Locator.Second;
        }

        protected override void OnAppearing()
        {
            
            base.OnAppearing();
            var currentPageKeyString = SimpleIoc.Default.GetInstance<INavigationService>().CurrentPageKey;
            System.Diagnostics.Debug.WriteLine("Current page key: " + currentPageKeyString);
        }
    }
}