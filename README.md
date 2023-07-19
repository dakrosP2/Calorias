# Calorias
CALCULO DE CALORIAS

PROYECTO SEGUNDO PARCIAL


trabajo realizado por:
  -Miranda M. Jhonn C.
  -Catucuago V. Juan P.

Para ver mis repositorios puedes acceder a mi perfil y conocer más sobre mis proyectos

Perfil GitHub: Dzhon251 (github.com)

Construcción de un aplocativo en Visual Studio en Xamarin.

![Screenshot_2023-07-18-07-44-02-282_com companyname conversor](https://github.com/dakrosP2/Calorias/assets/133244354/f7a910cf-2c16-4293-ab2e-5d0948450c1f)
![Screenshot_2023-07-18-07-43-57-695_com companyname conversor](https://github.com/dakrosP2/Calorias/assets/133244354/3362519b-d4bf-47f2-b81f-5a541d64d8d8)
![Diagrama de flujo](https://github.com/dakrosP2/Calorias/assets/133244354/2a2b8eaa-4530-4c52-9d00-362aa9d6c98d)


CÓDIGO DEL PROYECTO

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace conversor.Vistas
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
            talla= Convert.ToDouble(txttalla.Text);
            edad = Convert.ToDouble(txtedad.Text);
            calorias = 66 + (13.75 * peso) + (5 * talla) - (6.75 * edad);
            lblresultado.Text = calorias.ToString() + " kcal/dia ";

        }
        private void validar()
        {
            if(!string.IsNullOrEmpty(txttalla.Text))
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
