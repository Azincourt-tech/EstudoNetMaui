using System.Threading.Tasks;

namespace EstudoNetMaui.Controls.Command;

public partial class MauiCommandControls : ContentPage
{
	public MauiCommandControls()
	{
		InitializeComponent();
	}

    private async void btnDemo_Clicked(object sender, EventArgs e)
    {
		await lblDemo.RelRotateToAsync(360, 2000);
		await DisplayAlertAsync("Comando", "Comando executado com sucesso!", "OK");
    }

    private async void imgBtnDemo_Clicked(object sender, EventArgs e)
    {
        await lblDemo.RelRotateToAsync(-360, 5000);
    }

    private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        RadioButton selectedRadioButton = (RadioButton)sender;

        if (lblSelectedPet != null)
        {
           lblSelectedPet.Text = $"Você selecionou: {selectedRadioButton.Value}";
        }
    }

    private void searchBarDemo_SearchButtonPressed(object sender, EventArgs e)
    {
        SearchBar searchBar = (SearchBar)sender;

        lblSearchResult.Text = $"Você pesquisou por: {searchBar.Text}";
    }

    private async void OnDeleteSwipeItem_Invoked(object sender, EventArgs e)
    {
        await DisplayAlertAsync("SwipeItem", "Item deletado com sucesso!", "OK");
    }

    private async void OnEditSwipeItem_Invoked(object sender, EventArgs e)
    {
        await DisplayAlertAsync("SwipeItem", "Item editado com sucesso!", "OK");
    }

    private async void OnShareSwipeItem_Invoked(object sender, EventArgs e)
    {
        await DisplayAlertAsync("SwipeItem", "Item compartilhado com sucesso!", "OK");
    }
}