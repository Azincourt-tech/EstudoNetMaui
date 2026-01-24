using EstudoNetMaui.Models;

namespace EstudoNetMaui.Controls.Collections;

public partial class CollectionViewDemo : ContentPage
{
	public CollectionViewDemo()
	{
		InitializeComponent();
        BindingContext = new FotoViewModel();
    }
}