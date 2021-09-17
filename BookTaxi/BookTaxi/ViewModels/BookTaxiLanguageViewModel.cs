using BookTaxi.Model;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BookTaxi.ViewModels
{
    public class BookTaxiLanguageViewModel : ViewModelBase
    {
        private bool _hideimage = true;
        public bool IHideImage
        {
            get { return _hideimage; }
            set { SetProperty(ref _hideimage, value); }
        }
        private ListLanguage _selectedName;
        public ListLanguage SelectedName
        {
            get { return _selectedName; }
            set
            {
                //SetProperty(ref _selectedName, value);
                if (_selectedName != null)
                {
                    _selectedName = value;
                    IHideImage = true;
                    HandleSelectedItem();
                    //_navigationService.NavigateAsync("RotatorMainPage");
                }
            }
        }
        private async void HandleSelectedItem()
        {
           await  _navigationService.NavigateAsync("RotatorMainPage");
        }
        private readonly INavigationService _navigationService;
        //private readonly IPageDialogService _dialogService;
        public List<ListLanguage> languages { get; set; }
       
        public BookTaxiLanguageViewModel(INavigationService navigationService) : base(navigationService)
        {
           _navigationService = navigationService;
            languages = new List<ListLanguage>() {
                new ListLanguage { Language ="Arobic"},
                new ListLanguage { Language = "Chinese"},
                new ListLanguage { Language = "English" },
                new ListLanguage { Language = "Korean" },
                new ListLanguage { Language = "Urdu" }
            };

            //if (SelectedName != null)
            //{              
            //    _navigationService.NavigateAsync("RotatorMainPage");
            //}
        }
    }
}
