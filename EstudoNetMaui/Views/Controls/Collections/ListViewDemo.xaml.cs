using EstudoNetMaui.Models;
using EstudoNetMaui.ViewModels;

namespace EstudoNetMaui.Views.Controls.Collections;

public partial class ListViewDemo : ContentPage
{
	public ListViewDemo()
	{
		InitializeComponent();
		this.BindingContext = new FotoViewModel();
    }
}
