using BookTaxi.Model;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

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
        public LoginBookTaxiViewModel(INavigationService navigationService):base(navigationService)
        {
            PhoneCollection = new List<ListPhone>()
            {
                new ListPhone {  NumberPhone="+84"},
                new ListPhone { NumberPhone="+01"}
            };

        }
    }
}
