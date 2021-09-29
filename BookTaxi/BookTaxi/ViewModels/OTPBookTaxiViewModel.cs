using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace BookTaxi.ViewModels
{
    public class OTPBookTaxiViewModel : ViewModelBase
    {
        public Command BntOTP { get; }
        private readonly INavigationService _navigationService;
        public OTPBookTaxiViewModel(INavigationService navigationService) : base(navigationService)
        {
            _navigationService = navigationService;
            BntOTP = new Command(Login);
        }
        private async void Login()
        {
            await _navigationService.NavigateAsync("/DrawerBookTaxi");
        }
    }
}
