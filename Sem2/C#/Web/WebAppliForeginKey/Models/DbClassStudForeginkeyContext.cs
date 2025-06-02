using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebAppliForeginKey.Models;

public partial class DbClassStudForeginkeyContext : DbContext
{
    public readonly IConfiguration _config;
    public DbClassStudForeginkeyContext(IConfiguration confi)
    {
        _config = confi;
    }

    public DbClassStudForeginkeyContext(DbContextOptions<DbClassStudForeginkeyContext> options,IConfiguration configration)
        : base(options)
    {
        _config = configration;
    }

    public virtual DbSet<Class> Classes { get; set; }

    public virtual DbSet<Studofclass> Studofclasses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(_config.GetConnectionString("dbcs"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Class>(entity =>
        {
            entity.HasKey(e => e.ClassId).HasName("PK__class__7577347EE8F167E9");

            entity.ToTable("class");

            entity.Property(e => e.ClassId)
                .ValueGeneratedNever()
                .HasColumnName("classId");
            entity.Property(e => e.Classname)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("classname");
        });

        modelBuilder.Entity<Studofclass>(entity =>
        {
            entity.ToTable("Studofclass");

            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.ClassId).HasColumnName("classId");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");

            entity.HasOne(d => d.Class).WithMany(p => p.Studofclasses)
                .HasForeignKey(d => d.ClassId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
