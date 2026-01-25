using EstudoNetMaui.ViewModels;

namespace EstudoNetMaui.Views;

public partial class TimesView : ContentPage
{
    public TimesView()
    {
        InitializeComponent();
        BindingContext = new TimesViewModel();
    }
}