using EstudoNetMaui.ViewModels;

namespace EstudoNetMaui.Views;

public partial class ProdutoView : ContentPage
{
	public ProdutoView()
	{
		InitializeComponent();
		BindingContext = new ProdutoViewModel();
    }
}