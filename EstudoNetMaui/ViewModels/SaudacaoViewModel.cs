using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace EstudoNetMaui.ViewModels
{
    public partial class SaudacaoViewModel : ObservableObject
    {
        [ObservableProperty]
        private string nome = string.Empty;

        [ObservableProperty]
        private string _mensagem;

        [RelayCommand]
        private void Saudacao()
        {
            Mensagem = $"Bem-Vindo {Nome}";
        }
    }
}
