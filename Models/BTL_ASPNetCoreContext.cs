using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BTL.Models
{
    public partial class BTL_ASPNetCoreContext : DbContext
    {
        public BTL_ASPNetCoreContext()
        {
        }

        public BTL_ASPNetCoreContext(DbContextOptions<BTL_ASPNetCoreContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Accounts> Accounts { get; set; }
        public virtual DbSet<Brands> Brands { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Colors> Colors { get; set; }
        public virtual DbSet<Materials> Materials { get; set; }
        public virtual DbSet<OrderDetails> OrderDetails { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Posts> Posts { get; set; }
        public virtual DbSet<ProductColors> ProductColors { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<RelatedImage> RelatedImage { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<WishLists> WishLists { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Accounts>(entity =>
            {
                entity.HasKey(e => e.AccountId);

                entity.HasIndex(e => e.Email)
                    .HasName("UQ__Accounts__A9D10534B010BC04")
                    .IsUnique();

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK__Accounts__RoleID__164452B1");
            });

            modelBuilder.Entity<Brands>(entity =>
            {
                entity.HasKey(e => e.BrandId);

                entity.HasIndex(e => e.NameBrand)
                    .HasName("UQ__Brands__CF6F768B1E43A270")
                    .IsUnique();

                entity.Property(e => e.BrandId)
                    .HasColumnName("BrandID")
                    .HasMaxLength(250)
                    .ValueGeneratedNever();

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.NameBrand)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Categories>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.HasIndex(e => e.NameCategory)
                    .HasName("UQ__Categori__40B862F485D4B779")
                    .IsUnique();

                entity.Property(e => e.CategoryId)
                    .HasColumnName("CategoryID")
                    .HasMaxLength(250)
                    .ValueGeneratedNever();

                entity.Property(e => e.NameCategory)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.ParentId)
                    .HasColumnName("ParentID")
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Colors>(entity =>
            {
                entity.HasKey(e => e.ColorId);

                entity.Property(e => e.ColorId)
                    .HasColumnName("ColorID")
                    .HasMaxLength(250)
                    .ValueGeneratedNever();

                entity.Property(e => e.NameColor)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Materials>(entity =>
            {
                entity.HasKey(e => e.MaterialId);

                entity.HasIndex(e => e.NameMaterial)
                    .HasName("UQ__Material__4CD5CB154B2942C5")
                    .IsUnique();

                entity.Property(e => e.MaterialId)
                    .HasColumnName("MaterialID")
                    .HasMaxLength(250)
                    .ValueGeneratedNever();

                entity.Property(e => e.NameMaterial)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<OrderDetails>(entity =>
            {
                entity.Property(e => e.OrderDetailsId).HasColumnName("OrderDetailsID");

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .HasMaxLength(250);

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK__OrderDeta__Order__34C8D9D1");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__OrderDeta__Produ__35BCFE0A");
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.Adress)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("Created_at")
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.NameCustomer)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Posts>(entity =>
            {
                entity.HasKey(e => e.PostId);

                entity.Property(e => e.PostId).HasColumnName("PostID");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.NamePost)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<ProductColors>(entity =>
            {
                entity.Property(e => e.ProductColorsId).HasColumnName("ProductColorsID");

                entity.Property(e => e.ColorId)
                    .HasColumnName("ColorID")
                    .HasMaxLength(250);

                entity.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .HasMaxLength(250);

                entity.HasOne(d => d.Color)
                    .WithMany(p => p.ProductColors)
                    .HasForeignKey(d => d.ColorId)
                    .HasConstraintName("FK__ProductCo__Color__38996AB5");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductColors)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__ProductCo__Produ__398D8EEE");
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.HasKey(e => e.ProductId);

                entity.HasIndex(e => e.NameProduct)
                    .HasName("UQ__Products__DF0C7103D3F1EF66")
                    .IsUnique();

                entity.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .HasMaxLength(250)
                    .ValueGeneratedNever();

                entity.Property(e => e.BrandId)
                    .HasColumnName("BrandID")
                    .HasMaxLength(250);

                entity.Property(e => e.CategoryId)
                    .HasColumnName("CategoryID")
                    .HasMaxLength(250);

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("Created_at")
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).HasColumnType("ntext");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.MaterialId)
                    .HasColumnName("MaterialID")
                    .HasMaxLength(250);

                entity.Property(e => e.NameProduct).HasMaxLength(250);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.BrandId)
                    .HasConstraintName("FK__Products__BrandI__2E1BDC42");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK__Products__Catego__2C3393D0");

                entity.HasOne(d => d.Material)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.MaterialId)
                    .HasConstraintName("FK__Products__Materi__2D27B809");
            });

            modelBuilder.Entity<RelatedImage>(entity =>
            {
                entity.Property(e => e.RelatedImageId).HasColumnName("RelatedImageID");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .HasMaxLength(250);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.RelatedImage)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__RelatedIm__Produ__3C69FB99");
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.HasKey(e => e.RoleId);

                entity.HasIndex(e => e.NameRole)
                    .HasName("UQ__Roles__7EF6AFD6F7F02419")
                    .IsUnique();

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.NameRole)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<WishLists>(entity =>
            {
                entity.Property(e => e.WishListsId).HasColumnName("WishListsID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .HasMaxLength(250);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.WishLists)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK__WishLists__Accou__3F466844");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.WishLists)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__WishLists__Produ__403A8C7D");
            });
        }
    }
}
