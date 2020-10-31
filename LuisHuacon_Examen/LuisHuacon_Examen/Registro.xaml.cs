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
    public partial class Registro : ContentPage
    {
        public Registro(string usurio)
        {

            InitializeComponent();
            txtlabelUsuario.Text = usurio;
        }

        async void btnCalcular_Clicked(System.Object sender, System.EventArgs e)
        {
            double monto = Convert.ToDouble(txtMonto.Text);
            if (monto > 1800)
            {
                DisplayAlert("Mensaje de alerta", "No puede ser superior a $1800", "Cerrar");
            }
            else
            {
                if (monto < 0)
                {

                }
                else
                {
                    if (monto <= 1800)
                    {
                        Console.WriteLine("Entrar al if ");
                        double pago = Convert.ToDouble(txtMonto.Text);
                        double restante = 1800 - pago;
                        restante = restante + (restante * 0.05);
                        restante = restante / 3;
                        txtPago.Text = restante.ToString();


                    }
                }
            }
        }
        async void btnResumen_Clicked(System.Object sender, System.EventArgs e)
        {

            double totalPago = Convert.ToDouble(txtMonto.Text) + Convert.ToDouble(txtPago.Text) * 3;
            DisplayAlert("Mensaje de alerta", "El registro fue guardado correctamente", "Cerrar");
            await Navigation.PushAsync(new Resumen(txtlabelUsuario.Text, txtNombre.Text, totalPago.ToString()));
        }
    }
}