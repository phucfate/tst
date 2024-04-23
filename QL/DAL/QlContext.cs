using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DAL;

public partial class QlContext : DbContext
{
    public QlContext()
    {
    }

    public QlContext(DbContextOptions<QlContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Taikhoan> Taikhoans { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-TJJ6R0L;Initial Catalog=QL;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Taikhoan>(entity =>
        {
            entity.HasKey(e => e.Ten).HasName("PK__taikhoan__DC107AB0FBA3F545");

            entity.ToTable("taikhoan");

            entity.Property(e => e.Ten)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ten");
            entity.Property(e => e.Matkhau)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("matkhau");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
