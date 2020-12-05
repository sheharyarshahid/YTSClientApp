using System.ComponentModel;
using MoviesAp.ViewModels;
using Xamarin.Forms;

namespace MoviesAp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}