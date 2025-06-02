using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebAppMobileAPI.Models;

public partial class MobileManagedContext : DbContext
{
    public readonly IConfiguration _config;
    public MobileManagedContext(IConfiguration config)
    {
        _config = config;
    }

    public MobileManagedContext(DbContextOptions<MobileManagedContext> options,IConfiguration config)
        : base(options)
    {
        _config = config;
    }

    public virtual DbSet<Mobile> Mobiles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer(_config.GetConnectionString("dbcs"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Mobile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Mobile__3214EC07300B9C3E");

            entity.ToTable("Mobile");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Brand)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("brand");
            entity.Property(e => e.Model)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("model");
            entity.Property(e => e.Price).HasColumnName("price");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
