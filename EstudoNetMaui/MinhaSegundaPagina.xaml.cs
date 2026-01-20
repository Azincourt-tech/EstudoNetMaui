using System.Threading.Tasks;

namespace EstudoNetMaui;

public partial class MinhaSegundaPagina : ContentPage
{
	public MinhaSegundaPagina()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new MainPage());
    }
}