using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Login_Session_MVCWeb.Models;

public partial class CUsersPlanetOneDriveDocumentsDhruviMdfContext : DbContext
{
    public CUsersPlanetOneDriveDocumentsDhruviMdfContext()
    {
    }

    public CUsersPlanetOneDriveDocumentsDhruviMdfContext(DbContextOptions<CUsersPlanetOneDriveDocumentsDhruviMdfContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Studnet> Studnets { get; set; }

    public virtual DbSet<Table> Tables { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
            // => optionsBuilder.UseSqlServer("server=(LocalDB)\\MSSQLLocalDB;database=C:\\Users\\Planet\\OneDrive\\Documents\\dhruvi.mdf;trusted_connection=true;");

        }
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Studnet>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__studnet__3214EC07E14DBD81");

            entity.ToTable("studnet");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Des)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("des");
            entity.Property(e => e.Nm)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("nm");
        });

        modelBuilder.Entity<Table>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Table__3214EC07F9F2211D");

            entity.ToTable("Table");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("password");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__user__3214EC0768ABF480");

            entity.ToTable("user");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("password");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
