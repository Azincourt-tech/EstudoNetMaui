using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace EstudoNetMaui.ViewModels
{
    public partial class CommandsViewModel : ObservableObject
    {
        [ObservableProperty]
        private string? searchTerm;

        [RelayCommand]
        private async Task ButtonClick()
        {
            await App.Current.MainPage.DisplayAlertAsync("Alerta", "Mensagem", "Ok");
        }

        [RelayCommand]
        private void Search(string searchText)
        {
            Alerta(searchText);
        }

        private void Alerta(string mensagem)
        {
            App.Current.MainPage.DisplayAlertAsync("Alerta", mensagem, "Ok");
        }
    }
}
