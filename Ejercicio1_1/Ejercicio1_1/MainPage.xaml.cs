using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio1_1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnSuma_Clicked(object sender, EventArgs e)
        {
            var operaciones = new Models.Operaciones
            {
                Titulo = "La Suma es:",
                Num1 = Convert.ToInt32(txtNum1.Text),
                Num2 = Convert.ToInt32(txtNum2.Text),
                Operar = Convert.ToInt32(txtNum1.Text) + Convert.ToInt32(txtNum2.Text),
            };

            var resultado = new Resultados();
            resultado.BindingContext = operaciones;
            await Navigation.PushAsync(resultado);
        }

        private async void btnResta_Clicked(object sender, EventArgs e)
        {
            var operaciones = new Models.Operaciones
            {
                Titulo = "La Resta es:",
                Num1 = Convert.ToInt32(txtNum1.Text),
                Num2 = Convert.ToInt32(txtNum2.Text),
                Operar = Convert.ToInt32(txtNum1.Text) - Convert.ToInt32(txtNum2.Text),
            };

            var resultado = new Resultados();
            resultado.BindingContext = operaciones;
            await Navigation.PushAsync(resultado);

        }

        private async void btnMulti_Clicked(object sender, EventArgs e)
        {

            var operaciones = new Models.Operaciones
            {
                Titulo = " La Multiplicacion es:",
                Num1 = Convert.ToInt32(txtNum1.Text),
                Num2 = Convert.ToInt32(txtNum2.Text),
                Operar = Convert.ToInt32(txtNum1.Text) * Convert.ToInt32(txtNum2.Text),
            };

            var resultado = new Resultados();
            resultado.BindingContext = operaciones;
            await Navigation.PushAsync(resultado);
        }

        private async void btnDiv_Clicked(object sender, EventArgs e)
        {
            var operaciones = new Models.Operaciones
            {
                Titulo = "La Division es:",
                Num1 = Convert.ToInt32(txtNum1.Text),
                Num2 = Convert.ToInt32(txtNum2.Text),
                Operar = Convert.ToInt32(txtNum1.Text) / Convert.ToInt32(txtNum2.Text),
            };

            var resultado = new Resultados();
            resultado.BindingContext = operaciones;
            await Navigation.PushAsync(resultado);
        }
    }
}
