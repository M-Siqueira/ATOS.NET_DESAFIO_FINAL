using artigosAntigos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace artigosAntigos.Mappings
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Cliente");//definir nome da tabela

            builder.HasKey(p => p.IdCliente);// definir a chave primeria

            builder.Property(p => p.NomeCliente)//definir o tipo 
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(p => p.CpfCliente)//definir o tipo 
               .HasColumnType("varchar(20)")
               .IsRequired();

            
        }
    }
}
