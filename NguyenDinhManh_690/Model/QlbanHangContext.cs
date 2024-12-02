using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NguyenDinhManh_690.Model;

public partial class QlbanHangContext : DbContext
{
    public QlbanHangContext()
    {
    }

    public QlbanHangContext(DbContextOptions<QlbanHangContext> options)
        : base(options)
    {
    }

    public virtual DbSet<DanhMucHang> DanhMucHangs { get; set; }

    public virtual DbSet<Hang> Hangs { get; set; }

    public virtual DbSet<NhaNcc> NhaNccs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-BO68SJN\\DINHMANH;Initial Catalog=QLBanHang;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DanhMucHang>(entity =>
        {
            entity.HasKey(e => e.MaDm).HasName("PK__DanhMucH__2725866E5FB8232A");

            entity.ToTable("DanhMucHang");

            entity.Property(e => e.MaDm)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MaDM");
            entity.Property(e => e.TenDm)
                .HasMaxLength(50)
                .HasColumnName("TenDM");
        });

        modelBuilder.Entity<Hang>(entity =>
        {
            entity.HasKey(e => e.MaHang).HasName("PK__Hang__19C0DB1D168C89BC");

            entity.ToTable("Hang");

            entity.Property(e => e.MaHang)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MaDm)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MaDM");
            entity.Property(e => e.TenHang).HasMaxLength(30);

            entity.HasOne(d => d.MaDmNavigation).WithMany(p => p.Hangs)
                .HasForeignKey(d => d.MaDm)
                .HasConstraintName("FK__Hang__MaDM__398D8EEE");
        });

        modelBuilder.Entity<NhaNcc>(entity =>
        {
            entity.HasKey(e => e.MaNcc).HasName("PK__NhaNCC__3A185DEB8C1513D5");

            entity.ToTable("NhaNCC");

            entity.Property(e => e.MaNcc)
                .HasMaxLength(30)
                .HasColumnName("MaNCC");
            entity.Property(e => e.SoDt)
                .HasMaxLength(20)
                .HasColumnName("SoDT");
            entity.Property(e => e.TenNcc)
                .HasMaxLength(50)
                .HasColumnName("TenNCC");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
