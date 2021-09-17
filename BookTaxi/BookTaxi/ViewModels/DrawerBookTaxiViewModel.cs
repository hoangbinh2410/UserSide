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
        //internal async Task<List<VehicleLocations>> LoadVehicels()
        //{
        //    List<VehicleLocations> vehicleLocations = new List<VehicleLocations>()
        //    {
        //        new VehicleLocations{Latitude="20.982909", Longitude="105.79314272654523"},
        //        new VehicleLocations{Latitude="20.98305924661674", Longitude="105.79173521916367"},
        //        new VehicleLocations{Latitude="20.98099641649253", Longitude="105.7909952083495"},
        //        new VehicleLocations{Latitude="20.980441071345524", Longitude="105.79056118076547"},
        //        new VehicleLocations{Latitude="20.98074125815366", Longitude="105.78879292092401"}
        //    };
        //    return vehicleLocations;
        //}
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
        private List<ListMenu> _listdrawer;
        public List<ListMenu> ListDrawer
        {
            get { return _listdrawer; }
            set { SetProperty(ref _listdrawer, value); }
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
        public DrawerBookTaxiViewModel(INavigationService navigationService) : base(navigationService)
        {
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
