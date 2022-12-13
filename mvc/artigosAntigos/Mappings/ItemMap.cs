using artigosAntigos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace artigosAntigos.Mappings
{
    public class ItemMap : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.ToTable("Item");//definir nome da tabela

            builder.HasKey(p => p.IdItem);// definir a chave primeria

            builder.Property(p => p.NomeItem)//definir o tipo 
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(p => p.CategoriaId)//definir o tipo 
                .HasColumnType("int")
                .IsRequired();

            builder.Property(p => p.DataItem)//definir o tipo 
                .HasColumnType("dateTime")
                .IsRequired();

            builder.Property(p => p.CustoItem)//definir o tipo 
                .HasColumnType("numeric(38,2)")
                .IsRequired();

            builder.Property(p => p.PrecoItem)//definir o tipo 
                .HasColumnType("numeric(38,2)")
                .IsRequired();

            builder.Property(p => p.Foto)//definir o tipo 
                .HasColumnType("varchar(MAX)");
        }
    }
}
