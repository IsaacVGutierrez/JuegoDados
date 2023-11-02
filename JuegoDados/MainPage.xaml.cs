using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace JuegoDados
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnLanzar_Clicked(object sender, EventArgs e)
        {

            Random random = new Random();
            int dado1 = random.Next(1, 7);
            int dado2 = random.Next(1, 7);


            // Obtén el número ingresado por el usuario
            if (int.TryParse(TxtNumeroAdivinanza.Text, out int numeroAdivinado))
            {
                if (numeroAdivinado >= 2 && numeroAdivinado <= 12)
                {
                    ImgDado1.Source = "dado" + dado1.ToString() + ".png";
                    ImgDado2.Source = "dado" + dado2.ToString() + ".png";
                    int sumaDados = dado1 + dado2;
                    LblResultado.Text = sumaDados.ToString();

                    if (numeroAdivinado == sumaDados)
                    {
                        DisplayAlert("GANASTE", "¡Adivinaste!", "OK");
                    }
                    else
                    {
                        DisplayAlert("PERDISTE", "Intenta de nuevo", "OK");
                    }
                }
                else
                {
                    DisplayAlert("Error", "Ingresa un número dentro del rango 2 al 12.", "OK");
                }
            }
            else
            {
                DisplayAlert("Error", "Ingresa un número válido del 2 al 12.", "OK");
            }
        }
    }
    }

