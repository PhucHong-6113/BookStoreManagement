using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BusinessObject.Models;

public partial class BookStoreManagementDbContext : DbContext
{
    public BookStoreManagementDbContext()
    {
    }

    public BookStoreManagementDbContext(DbContextOptions<BookStoreManagementDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Author> Authors { get; set; }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Publisher> Publishers { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer(GetConnectionString());

    private string GetConnectionString()
    {
        IConfiguration config = new ConfigurationBuilder()
             .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", true, true)
                    .Build();
        var strConn = config["ConnectionStrings:BookStoreManagementDB"];

        return strConn;
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Author>(entity =>
        {
            entity.HasKey(e => e.AuthorId).HasName("PK__Authors__70DAFC341A84844D");

            entity.Property(e => e.AuthorId).ValueGeneratedNever();
            entity.Property(e => e.AuthorDescription).HasColumnType("text");
            entity.Property(e => e.AuthorName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(e => e.BookId).HasName("PK__Books__3DE0C207A6028BCC");

            entity.Property(e => e.BookId).ValueGeneratedNever();
            entity.Property(e => e.BookName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.CategoryId).HasName("PK__Categori__19093A0BCE9A7F13");

            entity.Property(e => e.CategoryId).ValueGeneratedNever();
            entity.Property(e => e.CategoryDescription).HasColumnType("text");
            entity.Property(e => e.CategoryName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Publisher>(entity =>
        {
            entity.HasKey(e => e.PublisherId).HasName("PK__Publishe__4C657FAB9DEA44F1");

            entity.Property(e => e.PublisherId).ValueGeneratedNever();
            entity.Property(e => e.PublisherDescription).HasColumnType("text");
            entity.Property(e => e.PublisherEmail)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PublisherName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PublisherPhoneNo)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__User__1788CC4C1C1A0937");

            entity.ToTable("User");

            entity.Property(e => e.UserId).ValueGeneratedNever();
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FullName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Role)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
