using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Space.Helpers;
using Space.ViewModels;
using Space.Views;
using Xamarin.Forms;

namespace Space
{
    public static class ViewModelLocator
    {
        static MonkeysViewModel monkeysVM;
        public static MonkeysViewModel MonkeysViewModel
        => monkeysVM ?? (monkeysVM = new MonkeysViewModel());

        static DetailsViewModel detailsVM;
        public static DetailsViewModel DetailsViewModel
        => detailsVM ?? (detailsVM = new DetailsViewModel(MonkeyHelper.Monkeys[0]));
    }

    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new HomePage())
            {
                BarTextColor = Color.White,
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
