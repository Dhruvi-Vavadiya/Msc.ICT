using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebUserPersonaldetailsMVC.Models;

public partial class UserPersonalDetailsContext : DbContext
{
    public IConfiguration _config;

    public UserPersonalDetailsContext(IConfiguration config)
    {
        _config = config;
    }

    public UserPersonalDetailsContext(DbContextOptions<UserPersonalDetailsContext> options, IConfiguration config)
        : base(options)
    {
        _config = config;
    }

    public virtual DbSet<PersonalDetail> PersonalDetails { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer(_config.GetConnectionString("dbcs"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PersonalDetail>(entity =>
        {
            entity.HasKey(e => e.PersonalId).HasName("PK__Personal__1788CC4CD6FF629C");

            entity.Property(e => e.PersonalId).ValueGeneratedNever();
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Education)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Gender)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("gender");
            entity.Property(e => e.Hobby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("hobby");

            entity.HasOne(d => d.User).WithMany(p => p.PersonalDetails)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PersonalDetails_Users");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__1788CC4C5E49998A");

            entity.Property(e => e.UserId).ValueGeneratedNever();
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
