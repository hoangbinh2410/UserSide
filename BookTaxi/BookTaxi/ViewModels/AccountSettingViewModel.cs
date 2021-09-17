using BookTaxi.Model;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BookTaxi.ViewModels
{
    public class AccountSettingViewModel : ViewModelBase
    {
        private List<ProfileUser> _profileusers;
        public List<ProfileUser> Profile
        {
            get { return _profileusers; }
            set { SetProperty(ref _profileusers, value); }
        }
        public AccountSettingViewModel(INavigationService navigationService) : base(navigationService)
        {
            Profile = new List<ProfileUser>()
            {
                new ProfileUser{ NameUser="Tony Stack", EmailUser="123213@gmail.com", PassWord="3123213", FavouritePlace="New York"}
            };
        }
    }
}
