using System.Globalization;

namespace EstudoNetMaui.Controls.SetValue;

public partial class MauiSetValueControls : ContentPage
{
	public MauiSetValueControls()
	{
		InitializeComponent();
    }

    private async void chkTerms_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
		if (e.Value)
			await DisplayAlertAsync("Terms Accepted", "You have accepted the terms and conditions.", "OK");
		else
			await DisplayAlertAsync("Terms Not Accepted", "You must accept the terms and conditions to proceed.", "OK");
    }

    private void sldVolume_ValueChanged(object sender, ValueChangedEventArgs e)
    {
		lblVolume.Text = $"Volume: {e.NewValue:F0}";
    }

    private void stpQuantity_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        lblQuantity.Text = $"Quantidade: {e.NewValue:F0}";
    }

    private void swcNotifications_Toggled(object sender, ToggledEventArgs e)
    {
      lblNotifications.Text = e.Value ? "Notificações Ativadas" : "Notificações Desativadas";
    }

    private void dtpDate_DateSelected(object sender, DateChangedEventArgs e)
    {
        lblDate.Text = $"Data Selecionada: {e.NewDate:dd/MM/yyyy}";
    }

    private void tmpTime_TimeSelected(object sender, TimeChangedEventArgs e)
    {
        lblTime.Text = $"Hora Selecionada: {e.NewTime:h\\:mm}";
    }
}