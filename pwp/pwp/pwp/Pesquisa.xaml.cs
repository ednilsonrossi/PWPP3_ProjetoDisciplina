using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Net.Http;
using Newtonsoft.Json;

namespace pwp
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pesquisa : ContentPage
    {
        public Pesquisa()
        {
            InitializeComponent();
        }

        async void btnBuscar_Clicked(object sender, System.EventArgs e)
        {
            var client = new HttpClient();
            string nomeFilme = txtNomeFilme.Text;
            var json = await client.GetStringAsync($"http://www.omdbapi.com/?Type=movie&apikey=29566135&t={nomeFilme}");
            var filme = JsonConvert.DeserializeObject<Filme>(json);

            if (filme.Response.Equals("True"))
            {
                await Navigation.PushAsync(new FilmeDetalhe(filme, false));
            }
            else
            {
                DisplayAlert("Ops", filme.Error, "OK");
            }
        }
    }
}