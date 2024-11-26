﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace KoiFarmShop.Repositories.Models;

public partial class FA24_PRN221_3W_G1_KoiFarmShopContext : DbContext
{
    public FA24_PRN221_3W_G1_KoiFarmShopContext()
    {
    }

    public FA24_PRN221_3W_G1_KoiFarmShopContext(DbContextOptions<FA24_PRN221_3W_G1_KoiFarmShopContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<Consignment> Consignments { get; set; }

    public virtual DbSet<Koi> Kois { get; set; }

    public virtual DbSet<KoiFarm> KoiFarms { get; set; }

    public virtual DbSet<KoiQualification> KoiQualifications { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderDetail> OrderDetails { get; set; }

    public virtual DbSet<Promotion> Promotions { get; set; }

    public static string GetConnectionString(string connectionStringName)
    {
        var config = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();

        string connectionString = config.GetConnectionString(connectionStringName);
        return connectionString;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(GetConnectionString("DefaultConnection"));


    // TODO: replace your connection string here to parse to appsettings.json
    //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
    //        => optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=FA24_PRN221_3W_G1_KoiFarmShop;Persist Security Info=True;User ID=sa;Password=12345;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Account__3214EC076D738D4C");

            entity.ToTable("Account");

            entity.HasIndex(e => e.Id, "UQ__Account__3214EC068CB441F5").IsUnique();

            entity.Property(e => e.AccountName).HasMaxLength(255);
            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.FullName).HasMaxLength(255);
            entity.Property(e => e.Password).HasMaxLength(255);
            entity.Property(e => e.PhoneNumber).HasMaxLength(255);
            entity.Property(e => e.Role).HasMaxLength(255);
        });

        modelBuilder.Entity<Consignment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Consignm__3214EC07782AA100");

            entity.ToTable("Consignment");

            entity.HasIndex(e => e.Id, "UQ__Consignm__3214EC0693475389").IsUnique();

            entity.Property(e => e.ConsignPaymentMethod).HasMaxLength(255);
            entity.Property(e => e.ConsignPaymentStatus).HasMaxLength(255);
            entity.Property(e => e.ConsignmentStartDate).HasColumnType("datetime");
            entity.Property(e => e.ConsignmentStatus).HasMaxLength(255);

            entity.HasOne(d => d.Account).WithMany(p => p.Consignments)
                .HasForeignKey(d => d.AccountId)
                .HasConstraintName("FK__Consignme__Accou__3B75D760");

            entity.HasOne(d => d.Koi).WithMany(p => p.Consignments)
                .HasForeignKey(d => d.KoiId)
                .HasConstraintName("FK__Consignme__KoiId__3C69FB99");
        });

        modelBuilder.Entity<Koi>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Koi__3214EC0747123D2E");

            entity.ToTable("Koi");

            entity.HasIndex(e => e.Id, "UQ__Koi__3214EC0683013EA1").IsUnique();

            entity.Property(e => e.Image).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Origin).HasMaxLength(255);
            entity.Property(e => e.Specie).HasMaxLength(255);
            entity.Property(e => e.Status).HasMaxLength(255);

            entity.HasOne(d => d.Farm).WithMany(p => p.Kois)
                .HasForeignKey(d => d.FarmId)
                .HasConstraintName("FK__Koi__FarmId__3D5E1FD2");

            entity.HasOne(d => d.Promotion).WithMany(p => p.Kois)
                .HasForeignKey(d => d.PromotionId)
                .HasConstraintName("FK__Koi__PromotionId__403A8C7D");
        });

        modelBuilder.Entity<KoiFarm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__KoiFarm__3214EC07C451651E");

            entity.ToTable("KoiFarm");

            entity.HasIndex(e => e.Id, "UQ__KoiFarm__3214EC0686034993").IsUnique();

            entity.Property(e => e.AwardImage).HasMaxLength(255);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.Image).HasMaxLength(255);
            entity.Property(e => e.Location).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.PhoneNumber).HasMaxLength(255);
            entity.Property(e => e.Status).HasMaxLength(255);
            entity.Property(e => e.Website).HasMaxLength(255);
        });

        modelBuilder.Entity<KoiQualification>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__KoiQuali__3214EC07E1FB41CD");

            entity.ToTable("KoiQualification");

            entity.HasIndex(e => e.Id, "UQ__KoiQuali__3214EC0626591BC5").IsUnique();

            entity.Property(e => e.CreateAt).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.ExpiredDate).HasColumnType("datetime");
            entity.Property(e => e.Image).HasMaxLength(255);
            entity.Property(e => e.IssueBy).HasMaxLength(255);
            entity.Property(e => e.IssueDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Type).HasMaxLength(255);
            entity.Property(e => e.ValidationStatus).HasMaxLength(255);

            entity.HasOne(d => d.Koi).WithMany(p => p.KoiQualifications)
                .HasForeignKey(d => d.KoiId)
                .HasConstraintName("FK__KoiQualif__KoiId__3F466844");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Order__3214EC07708BF0FC");

            entity.ToTable("Order");

            entity.HasIndex(e => e.Id, "UQ__Order__3214EC06E61B2D3D").IsUnique();

            entity.Property(e => e.CreateAt).HasColumnType("datetime");
            entity.Property(e => e.CustomerName).HasMaxLength(255);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.OrderAdress).HasMaxLength(255);
            entity.Property(e => e.OrderPhoneNumber).HasMaxLength(255);
            entity.Property(e => e.OrderStatus).HasMaxLength(255);
            entity.Property(e => e.PaymentMethod).HasMaxLength(255);
            entity.Property(e => e.UpdateAt).HasColumnType("datetime");

            entity.HasOne(d => d.Account).WithMany(p => p.Orders)
                .HasForeignKey(d => d.AccountId)
                .HasConstraintName("FK__Order__AccountId__3A81B327");
        });

        modelBuilder.Entity<OrderDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__OrderDet__3214EC07A5E58818");

            entity.ToTable("OrderDetail");

            entity.HasIndex(e => e.Id, "UQ__OrderDet__3214EC06B5C0F543").IsUnique();

            entity.HasOne(d => d.Koi).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.KoiId)
                .HasConstraintName("FK__OrderDeta__KoiId__3E52440B");

            entity.HasOne(d => d.Order).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("FK__OrderDeta__Order__398D8EEE");
        });

        modelBuilder.Entity<Promotion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Promotio__3214EC07399FEC09");

            entity.ToTable("Promotion");

            entity.HasIndex(e => e.Id, "UQ__Promotio__3214EC06520BFA61").IsUnique();

            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.PromotionName).HasMaxLength(255);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateAt).HasColumnType("datetime");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}