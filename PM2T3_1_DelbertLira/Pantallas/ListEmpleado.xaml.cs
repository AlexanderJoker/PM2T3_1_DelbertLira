using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PM2T3_1_DelbertLira.Pantallas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListEmpleado : ContentPage
    {
        public ListEmpleado()
        {
            InitializeComponent();
            BindingContext = new FPantallas.ConfiguracionListEmpleado(Navigation);
        }
    }
}