using artigosAntigos.Mappings;
using artigosAntigos.Models;
using Microsoft.EntityFrameworkCore;

namespace artigosAntigos.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) { }

        protected override void OnModelBuilber(ModelBuilder modelBuilder)
        {
            ModelBuilder modelBuilder1 = modelBuilder.ApplyConfigurationsFromAssembly();
            //lincando com as Maps 

        }
        
        public DbSet<Item> items { get; set; }
        public DbSet<Categoria> categoria { get; set; }
        public DbSet<Categoria> cliente { get; set; }
        public DbSet<Vendas> vendas { get; set; }

    }
}
