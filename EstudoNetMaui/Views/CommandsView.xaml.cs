using EstudoNetMaui.ViewModels;

namespace EstudoNetMaui.Views;

public partial class CommandsView : ContentPage
{
    public CommandsView()
    {
        InitializeComponent();
        BindingContext = new CommandsViewModel();
    }
}