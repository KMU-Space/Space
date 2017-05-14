using Space.Helpers;
using Space.ViewModels;
using Space.Views;
using Xamarin.Forms;

namespace Space
{
    public static class ViewModelLocator
    {
        static UniversitiesViewModel UniversitiesVM;
        public static UniversitiesViewModel UniversitiesViewModel
        => UniversitiesVM ?? (UniversitiesVM = new UniversitiesViewModel());

        static DetailsViewModel2 detailsVM;
        public static DetailsViewModel2 DetailsViewModel2
        => detailsVM ?? (detailsVM = new DetailsViewModel2(UniversityHelper.Universities[0]));
    }

    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new HomePage())
            {
                BarTextColor = Color.Black,
                BarBackgroundColor = Color.FromHex("#F2C500")
            };
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
