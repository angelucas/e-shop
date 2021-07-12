using e_shop.API.Models;
using Microsoft.EntityFrameworkCore;

namespace e_shop.Context
{
    public class CRUDContext : DbContext
    {
        public CRUDContext(DbContextOptions<CRUDContext> options) : base(options)
        {

        }

        public DbSet<Produto> Produtos { get; set; }
    }
}
