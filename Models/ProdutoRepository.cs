using System.Collections.Generic;

using mvc1.Models;

namespace AspNetCoreDocker.Models
{
    public class ProdutoRepository : IRepository
    {
        private AppDbContext context;

        public ProdutoRepository(AppDbContext ctx){
            context = ctx;
        }

        public IEnumerable<Produto> Produtos => context.Produtos;
    }
}