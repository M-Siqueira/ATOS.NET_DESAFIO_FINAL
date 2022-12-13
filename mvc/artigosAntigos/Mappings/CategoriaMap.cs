using artigosAntigos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace artigosAntigos.Mappings
{
    public class CategoriaMap : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("Categoria");//definir nome da tabela

            builder.HasKey(p => p.IdCategoria);// definir a chave primeria

            builder.Property(p => p.NomeCategoria)//definir o tipo 
                .HasColumnType("varchar(100)")
                .IsRequired();
        }
    }
}
