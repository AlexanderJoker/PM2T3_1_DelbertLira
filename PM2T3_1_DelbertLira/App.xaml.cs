﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PM2T3_1_DelbertLira
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
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