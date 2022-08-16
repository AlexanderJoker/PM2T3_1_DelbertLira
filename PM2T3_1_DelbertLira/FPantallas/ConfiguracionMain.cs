using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using PM2T3_1_DelbertLira.Pantallas;
using System.Windows.Input;
using Plugin.Media;
using System.IO;
using Plugin.Media.Abstractions;
using System.Threading.Tasks;

using Xamarin.Essentials;

namespace PM2T3_1_DelbertLira.FPantallas
{
    class ConfiguracionMain : MVVM
    {
        public ICommand verLista { get; set; }
        public ICommand addEmpleado { get; set; }
       public async void lista()
        {
         await Application.Current.MainPage.Navigation.PushAsync(new ListEmpleado());
        }
        public async void agregar()
        {
          await Application.Current.MainPage.Navigation.PushAsync(new AddEmpleado());
        }
        public ConfiguracionMain()
        {
            verLista = new Command(() => lista());
            addEmpleado = new Command(() => agregar());
            
        }
    }
}