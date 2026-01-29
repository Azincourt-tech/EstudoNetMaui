using CommunityToolkit.Mvvm.ComponentModel;

namespace EstudoNetMaui.Models
{
    public partial class Produto : ObservableObject
    {
        [ObservableProperty]
        private string nome;

        [ObservableProperty]
        private decimal preco;

        [ObservableProperty]
        private int estoque;

        [ObservableProperty]
        private bool ativo;

        [ObservableProperty]
        private DateTime dataCompra;

        [ObservableProperty]
        private double peso;
    }
}
