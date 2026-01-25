using EstudoNetMaui.Models;
using EstudoNetMaui.ViewModels;

namespace EstudoNetMaui.Views.Controls.Collections;

public partial class CollectionViewDemo : ContentPage
{
	public CollectionViewDemo()
	{
		InitializeComponent();
        BindingContext = new FotoViewModel();
    }
}
