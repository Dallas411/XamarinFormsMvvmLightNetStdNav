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
    public partial class ThirdPage : ContentPage
    {
        public ThirdPage(string parameter)
        {
            InitializeComponent();
            var viewModel = App.Locator.Third;
            BindingContext = viewModel;

            viewModel.ParameterText = string.IsNullOrEmpty(parameter) ? "No parameter set" : parameter;
        }
    }
}