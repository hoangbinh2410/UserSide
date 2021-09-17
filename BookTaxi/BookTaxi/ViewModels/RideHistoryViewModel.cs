using BookTaxi.Model;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BookTaxi.ViewModels
{
    public class RideHistoryViewModel : ViewModelBase
    {
        //Binding Data ToAdress
        private string _toadress = string.Empty;
        public string ToAdress
        {
            get { return _toadress; }
            set { SetProperty(ref _toadress, value); }
        }
        // Binding Data From Adress
        private string _fromadress = string.Empty;
        public string FromAdress
        {
            get { return _fromadress; }
            set { SetProperty(ref _fromadress, value); }
        }
        private List<ModelHistoryRide> _datahistoryride = new List<ModelHistoryRide>();
        public List<ModelHistoryRide> DataHistoryRide
        {
            get { return _datahistoryride; }
            set { _datahistoryride = value; }
        }
        public RideHistoryViewModel(INavigationService navigationService):base(navigationService)
        {
            DataHistoryRide = new List<ModelHistoryRide>()
            {
                new ModelHistoryRide{ FromAdress="Bonaraska City Centrer", ToAdress="My Home"},
                new ModelHistoryRide{ FromAdress="Planitium Gym", ToAdress="Bonaraska City Centrer"},
                new ModelHistoryRide{ FromAdress="Bonaraska City Centrer", ToAdress="My Home"}
            };
        }
    }
}
