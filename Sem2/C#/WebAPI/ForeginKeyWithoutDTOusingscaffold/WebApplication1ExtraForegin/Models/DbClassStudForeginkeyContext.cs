using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1ExtraForegin.Models;

public partial class DbClassStudForeginkeyContext : DbContext
{
    //Scaffold-DbContext "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=db_class_stud_foreginkey;Integrated Security=True;Encrypt=True;Trust Server Certificate=True" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
   private readonly IConfiguration _configuration;

    public DbClassStudForeginkeyContext(IConfiguration config)
    {
        _configuration = config;
    }

    public DbClassStudForeginkeyContext(DbContextOptions<DbClassStudForeginkeyContext> options,IConfiguration config)
        : base(options)
    {
        _configuration = config;
    }

    public virtual DbSet<Class> Classes { get; set; }

    public virtual DbSet<ErrorLog> ErrorLogs { get; set; }

    public virtual DbSet<Studofclass> Studofclasses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=db_class_stud_foreginkey;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");

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

        modelBuilder.Entity<ErrorLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ErrorLog__3214EC07F19F0372");

            entity.Property(e => e.ErrorMessage).HasMaxLength(4000);
            entity.Property(e => e.LogTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
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

            //entity.HasOne(d => d.Class).WithMany(p => p.Studofclasses)
            //    .HasForeignKey(d => d.ClassId)
            //    .OnDelete(DeleteBehavior.Cascade);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
