namespace MauiAppMinhasCompras.Views;
using MauiAppMinhasCompras.Models;
using MauiAppMinhasCompras.Helpers;
using static MauiAppMinhasCompras.Helpers.SQLiteDatabaseHelper;

public partial class RelatorioCategoria : ContentPage
{

    public RelatorioCategoria()
	{
		InitializeComponent();
	}

    protected async override void OnAppearing()
    {
        base.OnAppearing();

        List<GastoPorCategoria> dados = await App.Db.GetGastosPorCategoria();

        lst_relatorio.ItemsSource = dados;
    }
}