using System.Windows.Input;

namespace EstudoNetMaui.ViewModels
{
    public class CommandsViewModel
    {
        public ICommand ButtonClickCommand { get; }
        public ICommand SearchCommand { get; }
        public string? SearchTerm { get; set; }

        public CommandsViewModel()
        {
            ButtonClickCommand = new Command(() =>
               App.Current.MainPage.DisplayAlertAsync("Alerta", "Mensagem", "Ok"));

            SearchCommand = new Command((searchText) =>
            {
                var texto = searchText;
                Alerta(texto.ToString());
            });
        }

        private void Alerta(string mensagem)
        {
            App.Current.MainPage.DisplayAlertAsync("Alerta", mensagem, "Ok");
        }
    }
}
