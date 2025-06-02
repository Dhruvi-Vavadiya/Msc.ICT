using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MVCWebApp.Models;

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

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("server=(LocalDB)\\MSSQLLocalDB;database=C:\\Users\\Planet\\OneDrive\\Documents\\dhruvi.mdf;trusted_connection=true;");

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

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
