using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ExternalAPI.Models;

public partial class ExternalContext : DbContext
{
    public IConfiguration _config;
    public ExternalContext(IConfiguration config)
    {
        _config = config;
    }

    public ExternalContext(DbContextOptions<ExternalContext> options,IConfiguration config)
        : base(options)
    {
        _config = config;
    }

    public virtual DbSet<Department> Departments { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer(_config.GetConnectionString("dbcs"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.Did).HasName("PK__Departme__D877D2164C36F9D9");

            entity.ToTable("Department");

            entity.Property(e => e.Did)
                .ValueGeneratedNever()
                .HasColumnName("did");
            entity.Property(e => e.Dname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("dname");
            entity.Property(e => e.Dstaffcount).HasColumnName("dstaffcount");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
