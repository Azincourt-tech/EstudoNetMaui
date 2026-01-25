using EstudoNetMaui.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstudoNetMaui.ViewModels
{
    public class ProdutoViewModel
    {
        public Produto Produto { get; set; }
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
