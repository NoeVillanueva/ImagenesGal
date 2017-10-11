using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ImagenesGal
{
    public partial class MainPage : CarouselPage
    {
        int img1, imagen2, imagen3, imagen4, imagen5, imagen6, imagen7, imagen8, imagen9, imagen10;
       
       
        int imag1, imagen2n, imagen3n, imagen4n, imagen5n, imagen6n, imagen7n, imagen8n, imagen9n, imagen10n;

        int rs;

        public MainPage()
        {
            InitializeComponent();
        }


        private void MabelS_Clicked(object sender, EventArgs e)
        {

            img1 = 1;
            if (img1 == 1)
            {
                rs = rs + 1;


            }
        }

        private void MabelN_Clicked(object sender, EventArgs e)
        {

            imag1 = 0;
            if (imag1 == 0)
            {
                rs = rs + 0;


            }
        }

        private void Im2S_Clicked(object sender, EventArgs e)
        {

            imagen2 = 1;
            if (imagen2 == 1)
            {
                rs = rs + 1;
            }
        }

        private void Im2N_Clicked(object sender, EventArgs e)
        {
            imagen2n = 0;
            if (imagen2n == 0)
            {
                rs = rs + 0;
            }
        }
        private void Im3S_Clicked(object sender, EventArgs e)
        {
            imagen3 = 1;
            if (imagen3 == 1)
            {
                rs = rs + 1;
            }
        }

        private void Im3N_Clicked(object sender, EventArgs e)
        {
            imagen3n = 0;
            if (imagen3n == 0)
            {
                rs = rs + 0;
            }
        }

        private void Im4S_Clicked(object sender, EventArgs e)
        {
            imagen4 = 1;
            if (imagen4 == 1)
            {
                rs = rs + 1;
            }
        }
        private void Im4N_Clicked(object sender, EventArgs e)
        {
            imagen4n = 0;
            if (imagen4n == 0)
            {
                rs = rs + 0;
            }
        }
        private void Im5S_Clicked(object sender, EventArgs e)
        {
            imagen5 = 1;
            if (imagen5 == 1)
            {
                rs = rs + 1;
            }
        }
        private void Im5N_Clicked(object sender, EventArgs e)
        {
            imagen5n = 0;
            if (imagen5n == 0)
            {
                rs = rs + 0;
            }

        }

        private void Im6S_Clicked(object sender, EventArgs e)
        {
            imagen6 = 1;
            if (imagen6 == 1)
            {
                rs = rs + 1;
            }
        }
        private void Im6N_Clicked(object sender, EventArgs e)
        {
            imagen6n = 0;
            if (imagen6n == 0)
            {
                rs = rs + 0;
            }

        }
        private void Im7S_Clicked(object sender, EventArgs e)
        {
            imagen7 = 1;
            if (imagen7 == 1)
            {
                rs = rs + 1;
            }
        }
        private void Im7N_Clicked(object sender, EventArgs e)
        {
            imagen7n = 0;
            if (imagen7n == 0)
            {
                rs = rs + 0;
            }
        }
        private void Im8S_Clicked(object sender, EventArgs e)
        {
            imagen8 = 1;
            if (imagen8 == 1)
            {
                rs = rs + 1;
            }
        }
        private void Im8N_Clicked(object sender, EventArgs e)
        {
            imagen8n = 0;
            if (imagen8n == 0)
            {
                rs = rs + 0;
            }
        }
        private void Im9S_Clicked(object sender, EventArgs e)
        {
            imagen9 = 1;
            if (imagen9 == 1)
            {
                rs = rs + 1;
            }
        }
        private void Im9N_Clicked(object sender, EventArgs e)
        {
            imagen9n = 0;
            if (imagen9n == 0)
            {
                rs = rs + 0;
            }

        }
        private void Im10S_Clicked(object sender, EventArgs e)
        {
            imagen10 = 1;
            if (imagen10 == 1)
            {
                rs = rs + 1;
            }
        }
        private void Im10N_Clicked(object sender, EventArgs e)
        {
            imagen10n = 0;
            if (imagen10n == 0)
            {
                rs = rs + 0;
            }
        }

        private void Evaluar_Clicked(object sender, EventArgs e)
        {
            if (img1 == 1)
            {
                DisplayAlert("", "Android Me Gusta", "Aceptar");
            
            }


            if (imagen2 == 1)
            {
                DisplayAlert("", "Bart  Me Gusta", "Aceptar");
            
            }

            if (imagen3 == 1)
            {
                DisplayAlert("", "Cara Me Gusta", "Aceptar");
            
            }
            if (imagen4 == 1)
            {
                DisplayAlert("", "Gohan Me Gusta", "Aceptar");
            
            }
            if (imagen5 == 1)
            {
                DisplayAlert("", "Goku Me Gusta", "Aceptar");
           
            }
            if (imagen6 == 1)
            {
                DisplayAlert("", "Golf Me Gusta", "Aceptar");
            
            }
            if (imagen7 == 1)
            {
                DisplayAlert("", "Homero Me Gusta", "Aceptar");
            
            }
            if (imagen8 == 1)
            {
                DisplayAlert("", "Linux Me Gusta", "Aceptar");
            
            }
            if (imagen9 == 1)
            {
                DisplayAlert("", "Gohan Me Gusta", "Aceptar");
            
            }
            if (imagen10 == 1)
            {
                DisplayAlert("", "Golf Me Gusta", "Aceptar");
            
            }

        }

        private void EvaluarDL_Clicked(object sender, EventArgs e)
        {
            if (imag1 == 0)
            {
                DisplayAlert("", "Android No Me Gusta", "Aceptar");
            
            }

            if (imagen2n == 0)
            {
                DisplayAlert("", "Bart No Me Gusta", "Aceptar");
            
            }

            if (imagen3n == 0)
            {
                DisplayAlert("", "Cara No Me Gusta", "Aceptar");
           
            }

            if (imagen4n == 0)
            {
                DisplayAlert("", "Gohan No Me Gusta", "Aceptar");
            
            }

            if (imagen5n == 0)
            {
                DisplayAlert("", "Goku No Me Gusta", "Aceptar");
            
            }

            if (imagen6n == 0)
            {
                DisplayAlert("", "Golf No Me Gusta", "Aceptar");
            
            }

            if (imagen7n == 0)
            {
                DisplayAlert("", "Homero No Me Gusta", "Aceptar");
           
            }

            if (imagen8n == 0)
            {
                DisplayAlert("", "Linux No Me Gusta", "Aceptar");
            
            }

            if (imagen9n == 0)
            {
                DisplayAlert("", "Gohan No Me Gusta", "Aceptar");
            
            }

            if (imagen10n == 0)
            {
                DisplayAlert("", "Golf No Me Gusta", "Aceptar");
            
            }


        }



    }
}
