using EstudoNetMaui.Models;

namespace EstudoNetMaui.Controls.Collections;

public partial class CarouselViewEIndicatorView : ContentPage
{
	public CarouselViewEIndicatorView()
	{
		InitializeComponent();
		BindingContext = new FotoViewModel();
    }

    private async void carouselImages_CurrentItemChanged(object sender, CurrentItemChangedEventArgs e)
    {
        if (e.CurrentItem != null && e.PreviousItem != null)
        {
            var currentFoto = e.CurrentItem as Foto;
            var previousFoto = e.PreviousItem as Foto;

            await DisplayAlertAsync("Item Changed", $"Current: {currentFoto?.Nome}\nPrevious: {previousFoto?.Nome}", "OK");
        }
    }
}