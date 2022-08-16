using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PM2T3_1_DelbertLira.Controller;
using System.IO;

namespace PM2T3_1_DelbertLira
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }
        static BaseDatos basedatos;
        public static BaseDatos BaseDato
        {
            get
            {
                if (basedatos == null)
                {
                    basedatos = new BaseDatos(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Data.db3"));
                }
                return basedatos;
            }
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
