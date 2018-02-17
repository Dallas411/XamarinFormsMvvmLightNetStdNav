using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace XfMvvmLnetStdNav.ViewModel
{
    public class FirstViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        public FirstViewModel(INavigationService navigationService)
        {
            if (navigationService == null) throw new ArgumentNullException("navigationService");
            _navigationService = navigationService;

            NavigationCommand = new RelayCommand(() => { _navigationService.NavigateTo(Locator.SecondPage); });
        }

        public ICommand NavigationCommand { get; set; }
    }
}
