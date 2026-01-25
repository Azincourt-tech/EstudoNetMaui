using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace EstudoNetMaui.Models
{
    public class Time : INotifyPropertyChanged
    {
        private string nome;
        private string escudo;

        public string Nome
        {
            get => nome;
            set
            {
                nome = value;
                OnPropertyChanged();
            }
        }
        public string Escudo
        {
            get => escudo;
            set
            {
                escudo = value;
                OnPropertyChanged();
            }

        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName]
          string propName = null)
        {
            PropertyChanged?.Invoke(this,
                new PropertyChangedEventArgs(propName));
        }
    }
}
