using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Text;

namespace EstudoNetMaui.ViewModels;

public partial class EnderecoViewModel : ObservableObject
{
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(Endereco))]
    private string _nome;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(Endereco))]
    private string _sobrenome;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(Endereco))]
    private string _rua;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(Endereco))]
    private string _cep;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(Endereco))]
    private string _cidade;

    public string Endereco
    {
        get
        {
            var stringBuilder = new StringBuilder();
            stringBuilder
                .AppendLine($"{Nome} {Sobrenome}")
                .AppendLine(Rua)
                .AppendLine($"{Cep} - {Cidade}");
            return stringBuilder.ToString();
        }
    }

    [RelayCommand]
    private void ImprimirEndereco(string endereco)
    {
        App.Current.MainPage.DisplayAlertAsync("Endereço", endereco, "Ok");
    }
}

