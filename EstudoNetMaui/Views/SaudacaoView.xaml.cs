using EstudoNetMaui.ViewModels;

namespace EstudoNetMaui.Views;

public partial class SaudacaoView : ContentPage
{
    public SaudacaoView()
    {
        InitializeComponent();
        BindingContext = new SaudacaoViewModel();
    }
}