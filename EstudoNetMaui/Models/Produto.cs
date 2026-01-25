using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace EstudoNetMaui.Models
{
    public class Produto : INotifyPropertyChanged
    {
        private string nome;
        private decimal preco;
        private int estoque;
        private bool ativo;
        private DateTime dataCompra;
        private double peso;

        public string Nome
        {
            get => nome;
            set
            {
                nome = value;
                OnPropertyChanged();
            }
        }
        public decimal Preco
        {
            get => preco;
            set
            {
                preco = value;
                OnPropertyChanged();
            }
        }

        public int Estoque
        {
            get => estoque;
            set
            {
                estoque = value;
                OnPropertyChanged();
            }
        }
        public bool Ativo
        {
            get => ativo;
            set
            {
                ativo = value;
                OnPropertyChanged();
            }
        }
        public DateTime DataCompra
        {
            get => dataCompra;
            set
            {
                dataCompra = value;
                OnPropertyChanged();
            }
        }
        public double Peso
        {
            get => peso;
            set
            {
                peso = value;
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
