using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MICMExam.Models;

public partial class ExamMicmContext : DbContext
{
    public readonly IConfiguration _config;
    public ExamMicmContext(IConfiguration config)
    {
        _config = config;
    }

    public ExamMicmContext(DbContextOptions<ExamMicmContext> options,IConfiguration config)
        : base(options)
    {
        _config = config;
    }

    public virtual DbSet<HelpDeskCall> HelpDeskCalls { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer(_config.GetConnectionString("dbcs"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<HelpDeskCall>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__HelpDesk__3214EC078479B600");

            entity.ToTable("HelpDeskCall");

            entity.HasIndex(e => e.TokenNumber, "UQ__HelpDesk__435734E1D5DF0D28").IsUnique();

            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CustomerName).HasMaxLength(100);
            entity.Property(e => e.CustomerQuery).HasMaxLength(500);
            entity.Property(e => e.ExecutiveName).HasMaxLength(100);
            entity.Property(e => e.ResolutionRemarks).HasMaxLength(500);
            entity.Property(e => e.ResolutionStatus)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ResolvedOn).HasColumnType("datetime");
            entity.Property(e => e.TokenNumber)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
