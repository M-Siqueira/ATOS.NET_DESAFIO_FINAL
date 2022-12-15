using artigosAntigos.Mappings;
using artigosAntigos.Models;
using Microsoft.EntityFrameworkCore;

namespace artigosAntigos.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) { }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=localhost;initial Catalog=artigosAntigos;User ID=userAtos;password=12345;language=Portuguese;Trusted_Connection=True;");
            optionsBuilder.UseLazyLoadingProxies();
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
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
