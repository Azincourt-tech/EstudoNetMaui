namespace EstudoNetMaui.Controls.Collections;

public partial class TableViewDemo : ContentPage
{
	public TableViewDemo()
	{
		InitializeComponent();
	}

    private async void AlertaCinto_OnChanged(object sender, ToggledEventArgs e)
    {
		await DisplayAlertAsync("Alerta de Cinto", $"Alerta de cinto está {(e.Value ? "ativado" : "desativado")}.", "OK");
    }
}