﻿// <auto-generated />
using System;
using Kutuphane.DataAccessLayer.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Kutuphane.DataAccessLayer.Migrations
{
    [DbContext(typeof(SqlDbContext))]
    partial class SqlDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("KategoriKitap", b =>
                {
                    b.Property<int>("KategorilerId")
                        .HasColumnType("int");

                    b.Property<int>("KitaplarId")
                        .HasColumnType("int");

                    b.HasKey("KategorilerId", "KitaplarId");

                    b.HasIndex("KitaplarId");

                    b.ToTable("KategoriKitap");
                });

            modelBuilder.Entity("KitapYazar", b =>
                {
                    b.Property<int>("KitaplarId")
                        .HasColumnType("int");

                    b.Property<int>("YazarlarId")
                        .HasColumnType("int");

                    b.HasKey("KitaplarId", "YazarlarId");

                    b.HasIndex("YazarlarId");

                    b.ToTable("KitapYazar");
                });

            modelBuilder.Entity("Kutuphane.Entities.Concrete.Adres", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CaddeSokak")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Ilce")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sehir")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ulke")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YazarId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("YazarId");

                    b.ToTable("Adresler");
                });

            modelBuilder.Entity("Kutuphane.Entities.Concrete.Kategori", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 7, 26, 19, 30, 45, 150, DateTimeKind.Local).AddTicks(7914));

                    b.Property<string>("KategoriAdi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("UstKategoriId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KategoriAdi")
                        .IsUnique();

                    b.HasIndex("UstKategoriId");

                    b.ToTable("Kategoriler");
                });

            modelBuilder.Entity("Kutuphane.Entities.Concrete.Kitap", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("KitapAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SayfaSayisi")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Kitaplar");
                });

            modelBuilder.Entity("Kutuphane.Entities.Concrete.Yazar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gsm")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyadi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Yazarlar");
                });

            modelBuilder.Entity("KategoriKitap", b =>
                {
                    b.HasOne("Kutuphane.Entities.Concrete.Kategori", null)
                        .WithMany()
                        .HasForeignKey("KategorilerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Kutuphane.Entities.Concrete.Kitap", null)
                        .WithMany()
                        .HasForeignKey("KitaplarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KitapYazar", b =>
                {
                    b.HasOne("Kutuphane.Entities.Concrete.Kitap", null)
                        .WithMany()
                        .HasForeignKey("KitaplarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Kutuphane.Entities.Concrete.Yazar", null)
                        .WithMany()
                        .HasForeignKey("YazarlarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Kutuphane.Entities.Concrete.Adres", b =>
                {
                    b.HasOne("Kutuphane.Entities.Concrete.Yazar", "Yazar")
                        .WithMany("Adresler")
                        .HasForeignKey("YazarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Yazar");
                });

            modelBuilder.Entity("Kutuphane.Entities.Concrete.Kategori", b =>
                {
                    b.HasOne("Kutuphane.Entities.Concrete.Kategori", "UstKategori")
                        .WithMany("AltKategoriler")
                        .HasForeignKey("UstKategoriId");

                    b.Navigation("UstKategori");
                });

            modelBuilder.Entity("Kutuphane.Entities.Concrete.Kategori", b =>
                {
                    b.Navigation("AltKategoriler");
                });

            modelBuilder.Entity("Kutuphane.Entities.Concrete.Yazar", b =>
                {
                    b.Navigation("Adresler");
                });
#pragma warning restore 612, 618
        }
    }
}
