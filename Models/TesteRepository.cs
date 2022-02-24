using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc1.Models
{
    public class TesteRepository : IRepository
    {
        private static Produto[] produtos = new Produto[]{
            new Produto {ProdutoId=10,Nome="Caneta",Categoria="Material"},
            new Produto {ProdutoId=20,Nome="Caneta",Categoria="Material"},
            new Produto {ProdutoId=40,Nome="Caneta",Categoria="Material"},
        };
        public IEnumerable<Produto> Produtos {get => produtos;}
    }
}