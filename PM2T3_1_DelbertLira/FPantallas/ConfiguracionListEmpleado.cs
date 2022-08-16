using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using PM2T3_1_DelbertLira.Models;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace PM2T3_1_DelbertLira.FPantallas
{
    class ConfiguracionListEmpleado : MVVM
    {
        private ObservableCollection<Empleado> empleados;

        public ObservableCollection<Empleado> Empleados
        {
            get { return empleados; }
            set { empleados = value; OnPropertyChanged(); }
        }

        private Empleado _selectedempleado;

        public Empleado Selectedempleado
        {
            get { return _selectedempleado; }
            set { _selectedempleado = value; OnPropertyChanged(); }
        }
        public ICommand DetalleLista { private set; get; }
        public INavigation Navigation { get; set; }

        public ConfiguracionListEmpleado(INavigation navigation)
        {
            Navigation = navigation;
            DetalleLista = new Command<Type>(async (pageType) => await GoToDetails(pageType));

            carga();
        }
        public async void carga()
        {
            Empleados = new ObservableCollection<Empleado>();

            List<Empleado> empleado = new List<Empleado>();
            empleado = await App.BaseDato.ObtenerListaEmpleados();

            for (int i = 0; i < empleado.Count; i++)
            {
                Empleados.Add(new Empleado()
                {

                    id = empleado[i].id,
                    nombre = empleado[i].nombre,
                    apellido = empleado[i].apellido,
                    edad = empleado[i].edad,
                    direccion = empleado[i].direccion,
                    puesto = empleado[i].puesto
                });
            }
        }
        async Task GoToDetails(Type pageType)
        {
            if (Selectedempleado != null)
            {
                var page = (Page)Activator.CreateInstance(pageType);

                page.BindingContext = new Configuracionaddempleado()
                {

                    ID = Selectedempleado.id,
                    Nombre = Selectedempleado.nombre,
                    Apellido = Selectedempleado.apellido,
                    Edad = Selectedempleado.edad,
                    Direccion = Selectedempleado.direccion,
                    Puesto = Selectedempleado.puesto,

                };

                await Navigation.PushAsync(page);
            }
        }
    }
}
    

