﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace loginApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            MainPage = new NavigationPage (new LoginUI());
            //MainPage = new MyFlyoutPage(new FlyoutPage());
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
