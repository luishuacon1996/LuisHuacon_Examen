using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LuisHuacon_Examen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Resumen : ContentPage
    {
        public Resumen(string usuario, string nombre, string pago)
        {
            InitializeComponent();
            txtNombre.Text = nombre;
            txtUsuario.Text = usuario;
            txtPagoTotal.Text = pago;
        }
    }
}