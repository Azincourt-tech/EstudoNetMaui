using CommunityToolkit.Mvvm.ComponentModel;
using EstudoNetMaui.Models;

namespace EstudoNetMaui.ViewModels
{
    public partial class ProdutoViewModel : ObservableObject
    {
        [ObservableProperty]
        private Produto produto;

        public ProdutoViewModel()
        {
            Produto = new Produto
            {
                Nome = "Notebook",
                Preco = 3500.00m,
                Estoque = 10,
                Ativo = true,
                DataCompra = DateTime.Now,
                Peso = 2.5
            };
        }
    }
}
