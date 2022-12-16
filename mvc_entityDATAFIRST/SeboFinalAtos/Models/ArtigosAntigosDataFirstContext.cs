using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SeboFinalAtos.Models;

public partial class ArtigosAntigosDataFirstContext : DbContext
{
    public ArtigosAntigosDataFirstContext()
    {
    }

    public ArtigosAntigosDataFirstContext(DbContextOptions<ArtigosAntigosDataFirstContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Categorium> Categoria { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Item> Items { get; set; }

    public virtual DbSet<Vendum> Venda { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=localhost;initial Catalog=artigosAntigos_dataFirst;language=Portuguese;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Categorium>(entity =>
        {
            entity.HasKey(e => e.IdCategoria).HasName("PK__Categori__A3C02A10709F05AD");

            entity.Property(e => e.NomeCategoria)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.IdCliente).HasName("PK__Cliente__D5946642F8F0DFCA");

            entity.ToTable("Cliente");

            entity.Property(e => e.CpfCliente)
                .HasMaxLength(14)
                .IsUnicode(false);
            entity.Property(e => e.NomeCliente)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Item>(entity =>
        {
            entity.HasKey(e => e.IdItem).HasName("PK__Item__51E8426212D77472");

            entity.ToTable("Item");

            entity.Property(e => e.CustoItem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DataItem).HasColumnType("date");
            entity.Property(e => e.Foto).HasMaxLength(250);
            entity.Property(e => e.NomeItem)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PrecoItem).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Categoria).WithMany(p => p.Items)
                .HasForeignKey(d => d.CategoriaId)
                .HasConstraintName("FK__Item__CategoriaI__267ABA7A");
        });

        modelBuilder.Entity<Vendum>(entity =>
        {
            entity.HasKey(e => e.IdVenda).HasName("PK__Venda__BC1DC6A987EFAC5C");

            entity.Property(e => e.DataVenda).HasColumnType("date");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.Venda)
                .HasForeignKey(d => d.IdCliente)
                .HasConstraintName("FK__Venda__IdCliente__2B3F6F97");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
