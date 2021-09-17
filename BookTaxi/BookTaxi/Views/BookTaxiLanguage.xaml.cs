using Xamarin.Forms;

namespace BookTaxi.Views
{
    public partial class BookTaxiLanguage : ContentPage
    {
        public bool IHideImage
        {
            get;
            set;
        }

        public BookTaxiLanguage()
        {
            InitializeComponent();
            IHideImage = true;
    }

        private void SwipeListView_ItemTapped(object sender, Syncfusion.ListView.XForms.ItemTappedEventArgs e)
        {

        }
    }
}
