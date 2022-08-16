using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PM2T3_1_DelbertLira.FPantallas;

namespace PM2T3_1_DelbertLira.Pantallas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddEmpleado : ContentPage
    {
        public AddEmpleado(string opcion = "Guardar")
        {
            InitializeComponent();
           

                if (opcion.Equals("Guardar"))
                {
                    BindingContext = new Configuracionaddempleado(imagen, opcion);
                }
                else
                {
                    BindingContext = new Configuracionaddempleado(imagen2, opcion);
                }
            }
        }
    }
