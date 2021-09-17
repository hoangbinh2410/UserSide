using BookTaxi.Model;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BookTaxi.ViewModels
{
    public class NotificationsViewModel : ViewModelBase
    {
        private string _imagenotification = string.Empty;
        public string ImageNotification
        {
            get { return _imagenotification; }
            set { SetProperty(ref _imagenotification, value); }
        }
        private string _textnotification = string.Empty;
        public string TextNotificaton
        {
            get { return _textnotification; }
            set { SetProperty(ref _textnotification, value); }

        }
        private string _colornotification = string.Empty;
        public string ColorNotification
        {
            get { return _colornotification; }
            set { SetProperty(ref _colornotification, value); }
        }
        private List<ModelNotificaitons> _datanotificaiton = new List<ModelNotificaitons>();
        public List<ModelNotificaitons> DataNotificaiton
        {
            get { return _datanotificaiton; }
            set { _datanotificaiton = value; }
        }
        public NotificationsViewModel(INavigationService navigationService) : base(navigationService)
        {
            DataNotificaiton = new List<ModelNotificaitons>()
            {
                new ModelNotificaitons{ ImageNotification="done", TextNotificaton="Your Booking #42342343423423 is compledled successfully",ColorNotification= "Green"},
                new ModelNotificaitons{ ImageNotification="close", TextNotificaton="Your Booking #54534534534534534 is cancelled by you",ColorNotification= "Red"},
                new ModelNotificaitons{ ImageNotification="done", TextNotificaton="Your coupon code #ADDJADJDAJDJJAJDJA is applied successfully",ColorNotification= "Green"},
                new ModelNotificaitons{ ImageNotification="payment", TextNotificaton="Your debit card ended with ** 453453 is added successfully",ColorNotification= "Yellow"},
                 new ModelNotificaitons{ ImageNotification="close", TextNotificaton="Your Booking #54534534534534534 is cancelled by you",ColorNotification= "Red"},
                  new ModelNotificaitons{ ImageNotification="payment", TextNotificaton="Your Booking #54534534534534534 is cancelled by you",ColorNotification= "Yellow"},
                  new ModelNotificaitons{ ImageNotification="done", TextNotificaton="Your debit card ended with ** 453453 is added successfully",ColorNotification= "Green"},
                   new ModelNotificaitons{ ImageNotification="close", TextNotificaton="Your Booking #54534534534534534 is cancelled by you",ColorNotification= "Red"},
            };

        }
    }
}
