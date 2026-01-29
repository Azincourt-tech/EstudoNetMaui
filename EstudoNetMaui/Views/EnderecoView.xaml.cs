using EstudoNetMaui.ViewModels;

namespace EstudoNetMaui.Views;

public partial class EnderecoView : ContentPage
{
    public EnderecoView()
    {
        InitializeComponent();
        BindingContext = new EnderecoViewModel();
    }
}