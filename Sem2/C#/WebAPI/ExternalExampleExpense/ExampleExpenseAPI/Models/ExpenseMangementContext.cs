using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ExampleExpenseAPI.Models;

public partial class ExpenseMangementContext : DbContext
{

    public ExpenseMangementContext()
    {
    }

    public ExpenseMangementContext(DbContextOptions<ExpenseMangementContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Einformation> Einformations { get; set; }

    public virtual DbSet<TblUser> TblUsers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ExpenseMangement;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Einformation>(entity =>
        {
            entity.HasKey(e => e.Eid).HasName("PK__EInforma__C190176BFDD6BB98");

            entity.ToTable("EInformation");

            entity.Property(e => e.Eid)
                .ValueGeneratedNever()
                .HasColumnName("EId");
            entity.Property(e => e.Uid).HasColumnName("UId");

            entity.HasOne(d => d.UidNavigation).WithMany(p => p.Einformations)
                .HasForeignKey(d => d.Uid)
                .HasConstraintName("FK_EInformation_TblUser");
        });

        modelBuilder.Entity<TblUser>(entity =>
        {
            entity.HasKey(e => e.Uid).HasName("PK__TblUser__C5B196626D89F6E1");

            entity.ToTable("TblUser");

            entity.Property(e => e.Uid)
                .ValueGeneratedNever()
                .HasColumnName("UId");
            entity.Property(e => e.Uname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UName");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
