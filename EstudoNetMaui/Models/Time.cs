using CommunityToolkit.Mvvm.ComponentModel;

namespace EstudoNetMaui.Models
{
    public partial class Time : ObservableObject
    {
        [ObservableProperty]
        private string nome;

        [ObservableProperty]
        private string escudo;
    }
}
