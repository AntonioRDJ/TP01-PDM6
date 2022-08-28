using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TP01_PDM
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void OnClickConfirm(object sender, EventArgs args)
        {
            Console.WriteLine("sender ", sender);
            Console.WriteLine("args ", args);

            if(id.Text.Equals("admin") && pass.Text.Equals("senha@dmin"))
            {
                await DisplayAlert("Alerta", "Login realizado com sucesso", "OK");
            } else
            {
                await DisplayAlert("Alerta", "Login não autorizado", "OK");
            }
        }

        void OnClickClear(object sender, EventArgs args)
        {
            id.Text = "";
            pass.Text = "";
            id.Focus();
        }

        async void OnClickCredits(object sender, EventArgs args)
        {
            await DisplayAlert("Autores", "Antonio Rodrigues Dantas Junior \nVitor Hugo Chaves Silva Reis", "OK");
        }
    }
}
