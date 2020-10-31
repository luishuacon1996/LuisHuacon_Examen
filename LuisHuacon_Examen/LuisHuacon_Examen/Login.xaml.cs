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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnIngresar_Clicked(System.Object sender, System.EventArgs e)
        {
            if (!txtUsuario.Text.Equals("estudiante2020") && !txtClave.Text.Equals("uisrael2020"))
            {
                DisplayAlert("Alerta!", "El usuario y contraseña son incorrectos", "Cerrar");
            }
            else
            {
                if (!txtUsuario.Text.Equals("estudiante2020"))
                {
                    DisplayAlert("Alerta!", "El usuario es incorrecto", "Cerrar");
                }
                else
                {
                    if (!txtClave.Text.Equals("uisrael2020"))
                    {
                        DisplayAlert("Alerta!", "La contraseña es incorrecta", "Cerrar");
                    }
                    else
                    {
                        await Navigation.PushAsync(new Registro(txtUsuario.Text));

                    }

                }
            }
            DisplayAlert("Alerta!", "Bienvenido al sistema de Cursos Online", "Cerrar");
        }
    }
}