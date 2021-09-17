using BookTaxi.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;
namespace BookTaxi.Views
{
    public partial class DrawerBookTaxi : ContentPage
    {      
        public DrawerBookTaxi()
        {
            InitializeComponent();
            //UploadData();
            //        new VehicleLocations{Latitude="20.982909", Longitude="105.79314272654523"},
            //        new VehicleLocations{Latitude="20.98305924661674", Longitude="105.79173521916367"},
            //        new VehicleLocations{Latitude="20.98099641649253", Longitude="105.7909952083495"},
            //        new VehicleLocations{Latitude="20.980441071345524", Longitude="105.79056118076547"},
            //        new VehicleLocations{Latitude="20.98074125815366", Longitude="105.78879292092401"}
            Pin one = new Pin()
            {
                Label = "Home",
                Position = new Position(20.979934, 105.790728),
                //Icon = BitmapDescriptorFactory.FromBundle("ic_taxi.png"),
                Icon = BitmapDescriptorFactory.FromBundle("car2.png"),
                Type = PinType.Place,
                //Icon= (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("ic_taxi.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "ic_taxi.png", WidthRequest = 25, HeightRequest = 25 })
            };
            Pin two = new Pin()
            {
                Label = "Home",
                Position = new Position(20.973148, 105.779602),
                //Icon = BitmapDescriptorFactory.FromBundle("ic_taxi.png"),
                Icon = BitmapDescriptorFactory.FromBundle("car2.png"),
                Type = PinType.Place,
                //Icon= (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("ic_taxi.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "ic_taxi.png", WidthRequest = 25, HeightRequest = 25 })
            };
            Pin theew = new Pin()
            {
                Label = "Home",
                Position = new Position(20.980882, 105.784452),
                //Icon = BitmapDescriptorFactory.FromBundle("ic_taxi.png"),
                Icon = BitmapDescriptorFactory.FromBundle("car2.png"),
                Type = PinType.Place,
                //Icon= (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("ic_taxi.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "ic_taxi.png", WidthRequest = 25, HeightRequest = 25 })
            };
            map.Pins.Add(one);
            map.Pins.Add(two);
            map.Pins.Add(theew);
            map.MoveToRegion(MapSpan.FromCenterAndRadius(one.Position, Distance.FromMeters(5000)));
        }
        //public async void UploadData()
        //{
        //    var contents = await LoadVehicels();
        //    if (contents != null)
        //    {
        //        foreach (var item in contents)
        //        {
        //            Pin VehiclePins = new Pin()
        //            {
        //                Label = "Car",
        //                Type = PinType.Place,
        //                Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("ic_taxi.png") : BitmapDescriptorFactory.FromView(new Image() { Source = "ic_taxi.png", WidthRequest = 25, HeightRequest = 25 }),
        //                Position = new Position(Convert.ToDouble(item.Latitude), Convert.ToDouble(item.Longitude))
        //            };
        //            map.Pins.Add(VehiclePins);
        //        }
        //    }
        //    var positions = new Position(20.979934, 105.790728);
        //    map.MoveToRegion(MapSpan.FromCenterAndRadius(positions, Distance.FromMeters(5000)));
        //}
        private void hamburgerButton_Clicked(object sender, System.EventArgs e)
        {
            navigationDrawer.ToggleDrawer();
        }

        private async void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem.ToString() == "Home")
            {
                await Navigation.PushAsync(new DrawerBookTaxi());
            }
            else if (e.SelectedItem.ToString() == "Ride History")
            {
                await Navigation.PushAsync(new RideHistory());
            }
            else if (e.SelectedItem.ToString() == "Noticfications")
            {
                await Navigation.PushAsync(new Notifications());
            }
            else if (e.SelectedItem.ToString() == "Settings")
            {
                await Navigation.PushAsync(new AccountSetting());
            }

            navigationDrawer.ToggleDrawer();

        }
    }
}
