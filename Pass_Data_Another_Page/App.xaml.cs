using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pass_Data_Another_Page
{
    public partial class App : Application
    {
        ModelEmployerList emp = new ModelEmployerList();
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage(emp));
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
