using System;
using MoviesAp.Services;
using MoviesAp.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: ExportFont("FABrands.otf", Alias = "FABrands")]
[assembly: ExportFont("FADuotone.otf", Alias = "FADuotone")]
[assembly: ExportFont("FAProLight.otf", Alias = "FALight")]
[assembly: ExportFont("FARegular.otf", Alias = "FARegular")]
[assembly: ExportFont("FASolid.otf", Alias = "FASolid")]
namespace MoviesAp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MoviesPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
