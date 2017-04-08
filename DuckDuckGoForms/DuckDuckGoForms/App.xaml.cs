using Plugin.Connectivity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;

using Xamarin.Forms;

namespace DuckDuckGoForms
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new DuckDuckGoForms.MainPage();

            HacerLlamada();
        }

        private async void HacerLlamada()
        {
            if (CrossConnectivity.Current.IsConnected)
            {
                var cliente = new HttpClient();
                cliente.BaseAddress = new Uri("http://api.duckduckgo.com");
                
                var json = await cliente.GetAsync("/?q=DuckDuckGo&format=json");
            }
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
