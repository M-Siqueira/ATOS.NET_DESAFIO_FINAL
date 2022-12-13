using artigosAntigos.Models;
using Microsoft.EntityFrameworkCore;

namespace artigosAntigos.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) { }


        
        public DbSet<Item> items { get; set; }
        public DbSet<Categoria> categoria { get; set; }
        public DbSet<Cliente> cliente { get; set; }
        public DbSet<Vendas> vendas { get; set; }

    }
}
