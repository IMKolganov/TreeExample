﻿// <auto-generated />
using System;
using DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DB.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230519094216_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-preview.4.23259.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DB.Entities.Action", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Path")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RefAppId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Action", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5127),
                            Name = "Delete",
                            Path = "",
                            RefAppId = 0,
                            Updated = new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5128)
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5134),
                            Name = "Edit",
                            Path = "",
                            RefAppId = 1,
                            Updated = new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5134)
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5135),
                            Name = "Read",
                            Path = "",
                            RefAppId = 1,
                            Updated = new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5136)
                        },
                        new
                        {
                            Id = 4,
                            Created = new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5136),
                            Name = "Delete",
                            Path = "",
                            RefAppId = 2,
                            Updated = new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5137)
                        },
                        new
                        {
                            Id = 5,
                            Created = new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5137),
                            Name = "Edit",
                            Path = "",
                            RefAppId = 2,
                            Updated = new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5138)
                        },
                        new
                        {
                            Id = 6,
                            Created = new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5140),
                            Name = "Read",
                            Path = "",
                            RefAppId = 2,
                            Updated = new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5140)
                        },
                        new
                        {
                            Id = 7,
                            Created = new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5141),
                            Name = "Delete",
                            Path = "",
                            RefAppId = 3,
                            Updated = new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5141)
                        },
                        new
                        {
                            Id = 8,
                            Created = new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5142),
                            Name = "Edit",
                            Path = "",
                            RefAppId = 3,
                            Updated = new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5142)
                        },
                        new
                        {
                            Id = 9,
                            Created = new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5142),
                            Name = "Read",
                            Path = "",
                            RefAppId = 3,
                            Updated = new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5143)
                        },
                        new
                        {
                            Id = 10,
                            Created = new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5144),
                            Name = "Delete",
                            Path = "",
                            RefAppId = 4,
                            Updated = new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5144)
                        },
                        new
                        {
                            Id = 11,
                            Created = new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5145),
                            Name = "Edit",
                            Path = "",
                            RefAppId = 4,
                            Updated = new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5145)
                        },
                        new
                        {
                            Id = 12,
                            Created = new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5145),
                            Name = "Read",
                            Path = "",
                            RefAppId = 4,
                            Updated = new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5146)
                        },
                        new
                        {
                            Id = 13,
                            Created = new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5146),
                            Name = "Delete",
                            Path = "",
                            RefAppId = 5,
                            Updated = new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5147)
                        },
                        new
                        {
                            Id = 14,
                            Created = new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5147),
                            Name = "Edit",
                            Path = "",
                            RefAppId = 5,
                            Updated = new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5147)
                        },
                        new
                        {
                            Id = 15,
                            Created = new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5148),
                            Name = "Read",
                            Path = "",
                            RefAppId = 5,
                            Updated = new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5148)
                        },
                        new
                        {
                            Id = 16,
                            Created = new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5149),
                            Name = "Delete",
                            Path = "",
                            RefAppId = 6,
                            Updated = new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5149)
                        },
                        new
                        {
                            Id = 17,
                            Created = new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5150),
                            Name = "Edit",
                            Path = "",
                            RefAppId = 6,
                            Updated = new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5150)
                        },
                        new
                        {
                            Id = 18,
                            Created = new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5151),
                            Name = "Read",
                            Path = "",
                            RefAppId = 6,
                            Updated = new DateTime(2023, 5, 19, 9, 42, 16, 557, DateTimeKind.Utc).AddTicks(5151)
                        });
                });

            modelBuilder.Entity("DB.Entities.Application", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ApplicationName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Application", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ApplicationName = "App1",
                            Created = new DateTime(2023, 5, 19, 9, 42, 16, 558, DateTimeKind.Utc).AddTicks(1240),
                            Updated = new DateTime(2023, 5, 19, 9, 42, 16, 558, DateTimeKind.Utc).AddTicks(1240)
                        },
                        new
                        {
                            Id = 2,
                            ApplicationName = "App2",
                            Created = new DateTime(2023, 5, 19, 9, 42, 16, 558, DateTimeKind.Utc).AddTicks(1245),
                            Updated = new DateTime(2023, 5, 19, 9, 42, 16, 558, DateTimeKind.Utc).AddTicks(1245)
                        },
                        new
                        {
                            Id = 3,
                            ApplicationName = "App3",
                            Created = new DateTime(2023, 5, 19, 9, 42, 16, 558, DateTimeKind.Utc).AddTicks(1246),
                            Updated = new DateTime(2023, 5, 19, 9, 42, 16, 558, DateTimeKind.Utc).AddTicks(1246)
                        },
                        new
                        {
                            Id = 4,
                            ApplicationName = "App4",
                            Created = new DateTime(2023, 5, 19, 9, 42, 16, 558, DateTimeKind.Utc).AddTicks(1247),
                            Updated = new DateTime(2023, 5, 19, 9, 42, 16, 558, DateTimeKind.Utc).AddTicks(1247)
                        },
                        new
                        {
                            Id = 5,
                            ApplicationName = "App5",
                            Created = new DateTime(2023, 5, 19, 9, 42, 16, 558, DateTimeKind.Utc).AddTicks(1248),
                            Updated = new DateTime(2023, 5, 19, 9, 42, 16, 558, DateTimeKind.Utc).AddTicks(1249)
                        },
                        new
                        {
                            Id = 6,
                            ApplicationName = "App6",
                            Created = new DateTime(2023, 5, 19, 9, 42, 16, 558, DateTimeKind.Utc).AddTicks(1250),
                            Updated = new DateTime(2023, 5, 19, 9, 42, 16, 558, DateTimeKind.Utc).AddTicks(1251)
                        });
                });

            modelBuilder.Entity("DB.Entities.TreeView", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ApplicationTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int>("ParentApplicationId")
                        .HasColumnType("int");

                    b.Property<int>("RefApplicationId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("TreeView", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ApplicationTypeId = 1,
                            Created = new DateTime(2023, 5, 19, 9, 42, 16, 558, DateTimeKind.Utc).AddTicks(6765),
                            ParentApplicationId = 0,
                            RefApplicationId = 1,
                            Updated = new DateTime(2023, 5, 19, 9, 42, 16, 558, DateTimeKind.Utc).AddTicks(6766)
                        },
                        new
                        {
                            Id = 2,
                            ApplicationTypeId = 1,
                            Created = new DateTime(2023, 5, 19, 9, 42, 16, 558, DateTimeKind.Utc).AddTicks(6770),
                            ParentApplicationId = 0,
                            RefApplicationId = 2,
                            Updated = new DateTime(2023, 5, 19, 9, 42, 16, 558, DateTimeKind.Utc).AddTicks(6771)
                        },
                        new
                        {
                            Id = 3,
                            ApplicationTypeId = 1,
                            Created = new DateTime(2023, 5, 19, 9, 42, 16, 558, DateTimeKind.Utc).AddTicks(6772),
                            ParentApplicationId = 1,
                            RefApplicationId = 3,
                            Updated = new DateTime(2023, 5, 19, 9, 42, 16, 558, DateTimeKind.Utc).AddTicks(6772)
                        },
                        new
                        {
                            Id = 4,
                            ApplicationTypeId = 1,
                            Created = new DateTime(2023, 5, 19, 9, 42, 16, 558, DateTimeKind.Utc).AddTicks(6773),
                            ParentApplicationId = 2,
                            RefApplicationId = 4,
                            Updated = new DateTime(2023, 5, 19, 9, 42, 16, 558, DateTimeKind.Utc).AddTicks(6773)
                        },
                        new
                        {
                            Id = 5,
                            ApplicationTypeId = 1,
                            Created = new DateTime(2023, 5, 19, 9, 42, 16, 558, DateTimeKind.Utc).AddTicks(6775),
                            ParentApplicationId = 3,
                            RefApplicationId = 5,
                            Updated = new DateTime(2023, 5, 19, 9, 42, 16, 558, DateTimeKind.Utc).AddTicks(6775)
                        },
                        new
                        {
                            Id = 6,
                            ApplicationTypeId = 1,
                            Created = new DateTime(2023, 5, 19, 9, 42, 16, 558, DateTimeKind.Utc).AddTicks(6777),
                            ParentApplicationId = 5,
                            RefApplicationId = 6,
                            Updated = new DateTime(2023, 5, 19, 9, 42, 16, 558, DateTimeKind.Utc).AddTicks(6777)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
