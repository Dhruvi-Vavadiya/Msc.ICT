using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebApplicationWebAPI.Models;

public partial class DeptartmentStudentContext : DbContext
{
    private IConfiguration _config;
    public DeptartmentStudentContext(IConfiguration config)
    {
        _config = config;
    }

    public DeptartmentStudentContext(DbContextOptions<DeptartmentStudentContext> options, IConfiguration config)
        : base(options)
    {
        _config = config;
    }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer(_config.GetConnectionString("dbcs"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.DeptId);

            entity.ToTable("Department");

            entity.Property(e => e.DeptId)
                .ValueGeneratedNever()
                .HasColumnName("dept_id");
            entity.Property(e => e.Deptname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deptname");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.StudId);

            entity.ToTable("Student");

            entity.Property(e => e.StudId)
                .ValueGeneratedNever()
                .HasColumnName("stud_id");
            entity.Property(e => e.DeptId).HasColumnName("dept_id");
            entity.Property(e => e.StudAge).HasColumnName("stud_age");
            entity.Property(e => e.StudName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("stud_name");

            entity.HasOne(d => d.Dept).WithMany(p => p.Students)
                .HasForeignKey(d => d.DeptId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Student_Department");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
