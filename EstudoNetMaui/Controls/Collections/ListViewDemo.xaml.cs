using EstudoNetMaui.Models;

namespace EstudoNetMaui.Controls.Collections;

public partial class ListViewDemo : ContentPage
{
	public ListViewDemo()
	{
		InitializeComponent();
		this.BindingContext = new FotoViewModel();
    }
}