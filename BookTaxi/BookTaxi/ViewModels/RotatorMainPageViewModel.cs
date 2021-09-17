using BookTaxi.Model;
using BookTaxi.Views;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;

namespace BookTaxi.ViewModels
{
    public class RotatorMainPageViewModel :ViewModelBase
    {
        private List<ViewRotator> _rotatorCollection = new List<ViewRotator>();
        public List<ViewRotator> RotatorCollection
        {
            get { return _rotatorCollection; }
            set { _rotatorCollection = value; }
        }
        private string _imagerotator = string.Empty;
        public string ImgageRotator
        {
            get { return _imagerotator; }
            set { SetProperty(ref _imagerotator, value); }
        }
        private string _textrotator = string.Empty;
        public string TextRotator
        {
            get { return _textrotator; }
            set { SetProperty(ref _textrotator, value); }
        }
        private string _namebtn = string.Empty;
        public string NameBtn
        {
            get { return _namebtn; }
            set { SetProperty(ref _namebtn, value); }
        }
        private string _textrotator2 = string.Empty;
        public string TextRotator2
        {
            get { return _textrotator2; }
            set { SetProperty(ref _textrotator2, value); }
        }
        //public ObservableCollection<Type> RotatorPages { get; set; }
        public RotatorMainPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            RotatorCollection = new List<ViewRotator>()
            {
                new ViewRotator {ImgageRotator ="taxi2", TextRotator="Request Rider", NameBtn="SKIP", TextRotator2="Request a ride get picked up by a nearby community dỉver", ColorBtn="Transparent", TextColer="Yellow"},
                new ViewRotator {ImgageRotator="driver", TextRotator="Confirm Your Driver",NameBtn="SKIP", TextRotator2 ="Huge Drivers network helps, find comfortable, safe and cheap ride", ColorBtn="Transparent",TextColer="Yellow"},
                new ViewRotator {ImgageRotator="taxi", TextRotator="Track Your Ride", NameBtn="GET STARTED", TextRotator2="Know your driver in advance and ba oble to view curenl location", ColorBtn="Green",TextColer="White"}
            };
         }
        
    }

}
