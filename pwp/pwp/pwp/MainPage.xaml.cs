using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace pwp
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();

        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            updateList();
        }

        /*
        protected void Salvar(object sender, EventArgs e)
        {
            if (sender == this.NovoFilme)
            {
                var filme = new Filme
                {
                    Title = "Titanic",
                    Year = "1997",
                    Genre = "Drama, Romance",
                    Plot = "A seventeen-year-old aristocrat falls in love with a kind but poor artist aboard the luxurious, ill-fated R.M.S. Titanic.",
                    Poster = "https://m.media-amazon.com/images/M/MV5BMDdmZGU3NDQtY2E5My00ZTliLWIzOTUtMTY4ZGI1YjdiNjk3XkEyXkFqcGdeQXVyNTA4NzY1MzY@._V1_SX300.jpg",
                    Production = "Paramount Pictures"
                };

                App.DataBase.Insert(filme);
                updateList();
            }
        }
        */

        private async void updateList()
        {
            Lista.ItemsSource = await App.DataBase.RecuperateAll();
        }

        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pesquisa());
        }

        private async void Lista_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Filme filmeClicado = e.SelectedItem as Filme;

            await Navigation.PushAsync(new FilmeDetalhe(filmeClicado, true));
        }
    }
}
