using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DeMauGuiSV.Models;

public partial class SalesmanagementContext : DbContext
{
    public SalesmanagementContext()
    {
    }

    public SalesmanagementContext(DbContextOptions<SalesmanagementContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-BO68SJN\\DINHMANH;Initial Catalog=SALESMANAGEMENT;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.CatId).HasName("PK__Category__6A1C8ADA9D854DC1");

            entity.ToTable("Category");

            entity.Property(e => e.CatId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CatID");
            entity.Property(e => e.CatName).HasMaxLength(50);
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__Product__B40CC6EDCD2EF109");

            entity.ToTable("Product");

            entity.Property(e => e.ProductId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ProductID");
            entity.Property(e => e.CatId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CatID");
            entity.Property(e => e.ProductName).HasMaxLength(30);

            entity.HasOne(d => d.Cat).WithMany(p => p.Products)
                .HasForeignKey(d => d.CatId)
                .HasConstraintName("FK__Product__CatID__398D8EEE");
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.HasKey(e => e.SupplierId).HasName("PK__Supplier__4BE66694FC1B72DC");

            entity.ToTable("Supplier");

            entity.Property(e => e.SupplierId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SupplierID");
            entity.Property(e => e.SupplierName).HasMaxLength(50);
            entity.Property(e => e.SupplierTelephone).HasMaxLength(10);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
