using System.Collections.Generic;

namespace Models
{
    public interface IRepository
    {
        IEnumerable<Produto> Produtos{get;}
    }
}