using BookTaxi.ViewModels;
using BookTaxi.Views;
using Prism;
using Prism.Ioc;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;

namespace BookTaxi
{
    public partial class App
    {
        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("/DrawerBookTaxi");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<RotatorMainPage, RotatorMainPageViewModel>();           
            containerRegistry.RegisterForNavigation<BookTaxiLanguage, BookTaxiLanguageViewModel>();
            containerRegistry.RegisterForNavigation<LocationBookTaxi, LocationBookTaxiViewModel>();
            containerRegistry.RegisterForNavigation<LoginBookTaxi, LoginBookTaxiViewModel>();
            containerRegistry.RegisterForNavigation<OTPBookTaxi, OTPBookTaxiViewModel>();
            containerRegistry.RegisterForNavigation<DrawerBookTaxi, DrawerBookTaxiViewModel>();
            containerRegistry.RegisterForNavigation<AccountSetting, AccountSettingViewModel>();
            containerRegistry.RegisterForNavigation<RideHistory, RideHistoryViewModel>();
            containerRegistry.RegisterForNavigation<Notifications, NotificationsViewModel>();
            containerRegistry.RegisterForNavigation<MapBookTaxi, MapBookTaxiViewModel>();
        }
    }
}
