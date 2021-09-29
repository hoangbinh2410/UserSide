using BookTaxi.Model;
using Prism.AppModel;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;

namespace BookTaxi.ViewModels
{
    public class DrawerBookTaxiViewModel : ViewModelBase
    {       
        List<VehicleLocations> vehicleLocations = new List<VehicleLocations>()
            {
                new VehicleLocations{Latitude=20.982909, Longitude=105.79314272654523},
                new VehicleLocations{Latitude=20.98305924661674, Longitude=105.79173521916367},
                new VehicleLocations{Latitude=20.98099641649253, Longitude=105.7909952083495},
                new VehicleLocations{Latitude=20.980441071345524, Longitude=105.79056118076547},
                new VehicleLocations{Latitude=20.98074125815366, Longitude=105.78879292092401}
            };
        private string _imagedrawer = string.Empty;
        public string ImageDrawer
        {
            get { return _imagedrawer; }
            set { SetProperty(ref _imagedrawer, value); }
        }
        private string _textdrawer = string.Empty;
        public string TextDrawer
        {
            get { return _textdrawer; }
            set { SetProperty(ref _textdrawer, value); }
        }
        //Select item list item
        private ListMenu _selectpage = new ListMenu();
        public ListMenu SelectPage
        {
            get { return _selectpage; }
            set { 
            if(_selectpage != value)
                {
                    _selectpage = value;
                }
                HandleSelectedItem();
            }
        }
        //Du lieu drawer
        private List<ListMenu> _listdrawer;
        public List<ListMenu> ListDrawer
        {
            get { return _listdrawer; }
            set { SetProperty(ref _listdrawer, value); }
        }
        private async void HandleSelectedItem()
        {
            
            if (SelectPage.TextDrawer == "Settings")
            {
                await _navigationService.NavigateAsync("AccountSetting");
            }
            if(SelectPage.TextDrawer== "Noticfications")
            {
                await _navigationService.NavigateAsync("Notifications");
            }
            if (SelectPage.TextDrawer == "Ride History")
            {
                await _navigationService.NavigateAsync("RideHistory");
            }
            if (SelectPage.TextDrawer == "Sign Off")
            {
                await _navigationService.NavigateAsync("/LoginBookTaxi");
            }

        }
        private Pin _pin = new Pin();
        //{
        //    Label = "Car",
        //    Position = new Position(20.98099641649253, 105.79173521916367),
        //    //Icon = BitmapDescriptorFactory.FromBundle("ic_taxi.png"),
        //    Icon = BitmapDescriptorFactory.FromBundle("ic_car.png"),
        //    Type = PinType.Place
        //};
        public Pin Pin
        {
            get => _pin;
            set => SetProperty(ref _pin, value);
        }                
        public ObservableCollection<Pin> _pins = new ObservableCollection<Pin>();
        public ObservableCollection<Pin> Pins
        {
            get => _pins;
            set => SetProperty(ref _pins, value);
        }
        public readonly INavigationService _navigationService;
        public Command ClickedLabel { get; }
        public Command ClickedImage { get; }
        public Command ClickedBoxview { get; }
        public Command ClickedEntry { get; }
        public DrawerBookTaxiViewModel(INavigationService navigationService) : base(navigationService)
        {
            ClickedLabel = new Command(ClickLabel);
            ClickedImage = new Command(ClickImage);
            ClickedBoxview = new Command(ClickBoxView);
            ClickedEntry = new Command(ClickEntry);
            _navigationService = navigationService;
            _selectpage.TextDrawer = "";
            ListDrawer = new List<ListMenu>
            {
                new ListMenu{ImageDrawer="home",TextDrawer="Home"},
                new ListMenu{ImageDrawer="card",TextDrawer="Payment History"},
                new ListMenu{ImageDrawer="car",TextDrawer="Ride History"},
                new ListMenu{ImageDrawer="tickit",TextDrawer="Promo Codes"},
                new ListMenu{ImageDrawer="pay",TextDrawer="Payment Methods"},
                new ListMenu{ImageDrawer="ring",TextDrawer="Noticfications"},
                new ListMenu{ImageDrawer="setting",TextDrawer="Settings"},
                new ListMenu{ImageDrawer="help",TextDrawer="Help & FAQ"},
                new ListMenu{ImageDrawer="logout",TextDrawer="Sign Off"}

            };         
        }
        public async void ClickLabel()
        {
            await Application.Current.MainPage.DisplayAlert("Thông báo", " Đây là Label", "ok");
        }
        public async void ClickImage()
        {
            await Application.Current.MainPage.DisplayAlert("Thông báo", " Đây là Image", "ok");
        }
        public async void ClickBoxView()
        {
            await Application.Current.MainPage.DisplayAlert("Thông báo", " Đây là Boxview", "ok");
        }
        public async void ClickEntry()
        {
            await Application.Current.MainPage.DisplayAlert("Thông báo", " Đây là Entry", "ok");
        }
        //protected override void OnAppearing()
        //{ 
        //    Console.WriteLine("We are appearing 1");
        //    foreach (var item in vehicleLocations)
        //    {
        //        Pins = new ObservableCollection<Pin>()
        //        {
        //            new Pin
        //            {
        //                Label = "car",
        //                Position = new Position(item.Latitude, item.Longitude),
        //                Icon = BitmapDescriptorFactory.FromBundle("ic_car.png"),
        //                Type = PinType.Place
        //            }
        //        };
        //        Pins?.Add(Pin);
        //    }
        //}

        //protected override void OnDisappearing()
        //{
        //    Console.WriteLine("We are disappearing 2");
        //}       
    }
}       
