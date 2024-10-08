﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParsingProjectMVC.Services;

#nullable disable

namespace ParsingProjectMVC.Migrations
{
    [DbContext(typeof(ParsingDbContext))]
    [Migration("20240712132620_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ParsingProjectMVC.Models.KuyuGrubuModel", b =>
                {
                    b.Property<int>("KuyuGrubuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KuyuGrubuId"));

                    b.Property<string>("KuyuGrubuAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SahaId")
                        .HasColumnType("int");

                    b.HasKey("KuyuGrubuId");

                    b.HasIndex("SahaId");

                    b.ToTable("KuyuGruplari");
                });

            modelBuilder.Entity("ParsingProjectMVC.Models.KuyuModel", b =>
                {
                    b.Property<int>("KuyuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KuyuId"));

                    b.Property<string>("Boylam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Enlem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KuyuAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KuyuGrubuId")
                        .HasColumnType("int");

                    b.HasKey("KuyuId");

                    b.HasIndex("KuyuGrubuId");

                    b.ToTable("Kuyular");
                });

            modelBuilder.Entity("ParsingProjectMVC.Models.SahaModel", b =>
                {
                    b.Property<int>("SahaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SahaId"));

                    b.Property<string>("SahaAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SahaId");

                    b.ToTable("Sahalar");
                });

            modelBuilder.Entity("ParsingProjectMVC.Models.WellboreModel", b =>
                {
                    b.Property<int>("WellboreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WellboreId"));

                    b.Property<string>("Derinlik")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KuyuId")
                        .HasColumnType("int");

                    b.Property<string>("WellboreAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WellboreId");

                    b.HasIndex("KuyuId");

                    b.ToTable("Wellborelar");
                });

            modelBuilder.Entity("ParsingProjectMVC.Models.KuyuGrubuModel", b =>
                {
                    b.HasOne("ParsingProjectMVC.Models.SahaModel", "Saha")
                        .WithMany()
                        .HasForeignKey("SahaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Saha");
                });

            modelBuilder.Entity("ParsingProjectMVC.Models.KuyuModel", b =>
                {
                    b.HasOne("ParsingProjectMVC.Models.KuyuGrubuModel", "KuyuGrubu")
                        .WithMany()
                        .HasForeignKey("KuyuGrubuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KuyuGrubu");
                });

            modelBuilder.Entity("ParsingProjectMVC.Models.WellboreModel", b =>
                {
                    b.HasOne("ParsingProjectMVC.Models.KuyuModel", "Kuyu")
                        .WithMany()
                        .HasForeignKey("KuyuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kuyu");
                });
#pragma warning restore 612, 618
        }
    }
}
