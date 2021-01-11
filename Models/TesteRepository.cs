using System.Collections.Generic;

namespace Models
{
    public class TesteRepository : IRepository
    {
        private static Produto[] produtos = new Produto[]{
        new Produto { ProdutoId = 10, Nome = "Caneta", Categoria = "Papelaria", Preco = 3 },
        new Produto { ProdutoId = 20, Nome = "Borracha", Categoria = "Papelaria", Preco = 2 },
        new Produto { ProdutoId = 30, Nome = "Estojo", Categoria = "Papelaria", Preco = 10 },
        };
        public IEnumerable<Produto> Produtos { get => produtos; }
    }
}