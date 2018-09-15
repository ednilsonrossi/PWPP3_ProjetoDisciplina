using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace pwp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FilmeDetalhe : ContentPage
	{
        private bool isFavorite = false;
        private Filme movie;
		public FilmeDetalhe (Filme filme, bool isFavorite)
		{
			InitializeComponent ();

            this.movie = filme;
            this.isFavorite = isFavorite;
            lblNomeFilme.Text = filme.Title;
            lblAnoFilme.Text = filme.Year;
            lblGeneroFilme.Text = filme.Genre;
            lblDescricaoFilme.Text = filme.Plot;
            lblProdutoraFilme.Text = filme.Production;
            imgPosterFilme.Source = filme.Poster;

            btnFilme.Text = isFavorite ? "Remover dos favoritos" : "Adicionar aos favoritos";
        }

        async void btnSalvarFavorito_Clicked(object sender, System.EventArgs e)
        {
            if (this.isFavorite)
            {
                //Apagar
                App.DataBase.Delete(movie);
                await DisplayAlert("Apagado", "Filme apagado dos favoritos", "OK");
                await Navigation.PopToRootAsync(true);
            }
            else
            {
                //Salvar
                App.DataBase.Insert(movie);
                await DisplayAlert("Salvo", "Filme favoritado", "OK");
                await Navigation.PopToRootAsync(true);
            }
        }
	}
}