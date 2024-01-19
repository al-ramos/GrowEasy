﻿// <auto-generated />
using System;
using GrowEasy.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GrowEasy.Migrations
{
    [DbContext(typeof(RContext))]
    partial class RContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-preview.5.22302.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GrowEasy.Models.Activitie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("VivenciaId")
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("VivenciaId");

                    b.ToTable("Activities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            VivenciaId = 1,
                            description = "WCF / WebService / SOAP / WebForms / ASP.NET / C#",
                            name = "Programmer .NET"
                        });
                });

            modelBuilder.Entity("GrowEasy.Models.MainDesc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("about")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("birhDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("linkedin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("senior")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("MainDescs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            about = "Excelente prossional",
                            birhDate = new DateTime(1978, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            email = "al-ramos@hotmail.com",
                            linkedin = "progalexramos",
                            name = "Alexsandro Ramos",
                            senior = false
                        });
                });

            modelBuilder.Entity("GrowEasy.Models.Vivencia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("MainDescId")
                        .HasColumnType("int");

                    b.Property<DateTime>("beginDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("client")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("endDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MainDescId");

                    b.ToTable("Vivencias");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            MainDescId = 1,
                            beginDate = new DateTime(2022, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            client = "SysMap / Claro",
                            endDate = new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            name = "Anlyst Programmer"
                        });
                });

            modelBuilder.Entity("GrowEasy.Models.Activitie", b =>
                {
                    b.HasOne("GrowEasy.Models.Vivencia", null)
                        .WithMany("Activities")
                        .HasForeignKey("VivenciaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GrowEasy.Models.Vivencia", b =>
                {
                    b.HasOne("GrowEasy.Models.MainDesc", "MainDesc")
                        .WithMany("Vivencias")
                        .HasForeignKey("MainDescId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MainDesc");
                });

            modelBuilder.Entity("GrowEasy.Models.MainDesc", b =>
                {
                    b.Navigation("Vivencias");
                });

            modelBuilder.Entity("GrowEasy.Models.Vivencia", b =>
                {
                    b.Navigation("Activities");
                });
#pragma warning restore 612, 618
        }
    }
}
