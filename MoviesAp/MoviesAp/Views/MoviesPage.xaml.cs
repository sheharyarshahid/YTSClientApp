using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoviesAp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MoviesAp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MoviesPage : ContentPage
    {
        public MoviesViewModel MoviesVM { get; set; }
        private int _pageNum = 1;


        public MoviesPage()
        {
            InitializeComponent();

            this.BindingContext = MoviesVM = new MoviesViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            // Subscribe event handlers
            LoadNextMoviesBtn.Clicked += LoadNextMoviesBtn_Clicked;

            MoviesVM.IsBusy = true;
            MoviesCarousel.ItemsSource = await MoviesVM.GetMovies();
            MoviesVM.IsBusy = false;
        }

        protected override void OnDisappearing()
        {
            // Unsubscribe event handlers
            LoadNextMoviesBtn.Clicked -= LoadNextMoviesBtn_Clicked;

            base.OnDisappearing();
        }

        private async void LoadNextMoviesBtn_Clicked(object sender, EventArgs e)
        {
            MoviesVM.IsBusy = true;

            // Fetch next 10 movies
            _pageNum++;
            MoviesCarousel.ItemsSource = await MoviesVM.GetMovies(_pageNum);
            MoviesCarousel.Position = 0;

            MoviesVM.IsBusy = false;
        }
    }
}