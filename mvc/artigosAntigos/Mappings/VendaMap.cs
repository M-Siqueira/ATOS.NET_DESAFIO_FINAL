using artigosAntigos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace artigosAntigos.Mappings
{
    public class VendaMap : IEntityTypeConfiguration<Vendas>
    {
        public void Configure(EntityTypeBuilder<Vendas> builder)
        {
            builder.ToTable("Venda");//definir nome da tabela

            builder.HasKey(p => p.IdVenda);// definir a chave primeria

            builder.Property(p => p.DataVenda)//definir o tipo 
                .HasColumnType("datetime")
                .IsRequired();

            builder.Property(p => p.cliente)//definir o tipo 
               .HasColumnType("Cliente")
               .IsRequired();

        }
    }
}
