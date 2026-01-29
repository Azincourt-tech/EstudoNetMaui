using System.Threading.Tasks;
using EstudoNetMaui.Views;

namespace EstudoNetMaui.Views.Pages;

public partial class NavigationPageDemo : ContentPage
{
	public NavigationPageDemo()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new MainPage());
    }
}
