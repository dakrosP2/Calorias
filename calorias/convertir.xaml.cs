using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace calorias
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class convertir : ContentPage
    {
        double peso;
        double talla;
        double edad;
        double calorias;
        public convertir()
        {
            InitializeComponent();
        }
        private void calcular()
        {
            peso = Convert.ToDouble(txtpeso.Text);
            talla = Convert.ToDouble(txttalla.Text);
            edad = Convert.ToDouble(txtedad.Text);
            calorias = 66 + (13.75 * peso) + (5 * talla) - (6.75 * edad);
            lblresultado.Text = calorias.ToString() + " kcal/dia ";

        }
        private void validar()
        {
            if (!string.IsNullOrEmpty(txttalla.Text))
            {
                calcular();
            }
            else
            {
                DisplayAlert("Error", "Ingrese su estatura", "OK");
            }
            if (!string.IsNullOrEmpty(txtpeso.Text))
            {
                calcular();
            }
            else
            {
                DisplayAlert("Error", "Ingrese su peso", "OK");
            }
            if (!string.IsNullOrEmpty(txtedad.Text))
            {
                calcular();
            }
            else
            {
                DisplayAlert("Error", "Ingrese su edad", "OK");
            }
        }
        private void btnvolver_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void btncalcular_Clicked(object sender, EventArgs e)
        {
            validar();
        }
    }
}