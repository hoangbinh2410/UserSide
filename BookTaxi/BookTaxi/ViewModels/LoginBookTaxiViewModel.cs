using BookTaxi.Model;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace BookTaxi.ViewModels
{   
    public class LoginBookTaxiViewModel : ViewModelBase
    {
        private List<ListPhone> _listPhones = new List<ListPhone>();
        public List<ListPhone> PhoneCollection
        {
            get { return _listPhones; }
            set { _listPhones = value; }
        }
        public Command ClikedImage { get; }
        private readonly INavigationService _navigationService;
        public LoginBookTaxiViewModel(INavigationService navigationService):base(navigationService)
        {
            _navigationService = navigationService;
            ClikedImage = new Command(ImageClicked);
            PhoneCollection = new List<ListPhone>()
            {
                new ListPhone {  NumberPhone="+84"},
                new ListPhone { NumberPhone="+01"}
            };

        }
        public async void ImageClicked()
        {
            await _navigationService.NavigateAsync("/OTPBookTaxi");             
            //await Application.Current.MainPage.DisplayAlert("Error","Sai thong tin","ok");
        }
    }
}
