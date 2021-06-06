using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using KeisanKyou.ViewModels;
using KeisanKyou.Views;

namespace KeisanKyou
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new MainPage();
            var MainVM = new MainPageViewModel();
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
