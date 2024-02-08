﻿// <auto-generated />
using System;
using BlogProject.DataAccess.EntityFramework.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlogProject.DataAccess.Migrations
{
    [DbContext(typeof(BlogProjectDbContext))]
    [Migration("20240130132905_Initialcreate")]
    partial class Initialcreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlogProject.Entities.Concrete.Article", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("CategoryId");

                    b.Property<int>("CommentCount")
                        .HasColumnType("int")
                        .HasColumnName("CommentCount");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Content");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2")
                        .HasColumnName("Date");

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Statu")
                        .HasColumnType("int");

                    b.Property<string>("Thumbnail")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("Thumbnail");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Title");

                    b.Property<int>("ViewCount")
                        .HasColumnType("int")
                        .HasColumnName("ViewCount");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Articles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("2f9c414e-c0c2-4f3e-b67c-343287c0f330"),
                            CategoryId = new Guid("62efdf5e-a5a6-47c8-b853-8de7a23308b3"),
                            CommentCount = 10,
                            Content = "C# 9.0 ile ilgili makaleler",
                            CreatedBy = "System",
                            CreatedDate = new DateTime(2024, 1, 30, 16, 29, 4, 950, DateTimeKind.Local).AddTicks(971),
                            Date = new DateTime(2024, 1, 30, 16, 29, 4, 950, DateTimeKind.Local).AddTicks(949),
                            Statu = 1,
                            Thumbnail = "csharp.png",
                            Title = "C# 9.0",
                            ViewCount = 100,
                            isDeleted = false
                        },
                        new
                        {
                            Id = new Guid("56085fc3-6ff0-4a10-a04a-4d3a91684a96"),
                            CategoryId = new Guid("c33260dd-b051-4a2d-923a-4c16553e4753"),
                            CommentCount = 10,
                            Content = "Java 11 ile ilgili makaleler",
                            CreatedBy = "System",
                            CreatedDate = new DateTime(2024, 1, 30, 16, 29, 4, 950, DateTimeKind.Local).AddTicks(992),
                            Date = new DateTime(2024, 1, 30, 16, 29, 4, 950, DateTimeKind.Local).AddTicks(990),
                            Statu = 1,
                            Thumbnail = "java.png",
                            Title = "Java 11",
                            ViewCount = 100,
                            isDeleted = false
                        },
                        new
                        {
                            Id = new Guid("868eb3aa-52ca-4f41-9ebc-0b7ca5b90861"),
                            CategoryId = new Guid("62efdf5e-a5a6-47c8-b853-8de7a23308b3"),
                            CommentCount = 10,
                            Content = "Python 3.9 ile ilgili makaleler",
                            CreatedBy = "System",
                            CreatedDate = new DateTime(2024, 1, 30, 16, 29, 4, 950, DateTimeKind.Local).AddTicks(997),
                            Date = new DateTime(2024, 1, 30, 16, 29, 4, 950, DateTimeKind.Local).AddTicks(996),
                            Statu = 1,
                            Thumbnail = "python.png",
                            Title = "Python 3.9",
                            ViewCount = 100,
                            isDeleted = false
                        });
                });

            modelBuilder.Entity("BlogProject.Entities.Concrete.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasColumnName("Description");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Name");

                    b.Property<int>("Statu")
                        .HasColumnType("int");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Categories", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("62efdf5e-a5a6-47c8-b853-8de7a23308b3"),
                            CreatedBy = "System",
                            CreatedDate = new DateTime(2024, 1, 30, 16, 29, 4, 950, DateTimeKind.Local).AddTicks(4929),
                            Description = "C# ile ilgili makaleler",
                            Name = "C#",
                            Statu = 1,
                            isDeleted = false
                        },
                        new
                        {
                            Id = new Guid("c33260dd-b051-4a2d-923a-4c16553e4753"),
                            CreatedBy = "System",
                            CreatedDate = new DateTime(2024, 1, 30, 16, 29, 4, 950, DateTimeKind.Local).AddTicks(4940),
                            Description = "Java ile ilgili makaleler",
                            Name = "Java",
                            Statu = 1,
                            isDeleted = false
                        });
                });

            modelBuilder.Entity("BlogProject.Entities.Concrete.Article", b =>
                {
                    b.HasOne("BlogProject.Entities.Concrete.Category", "Category")
                        .WithMany("Articles")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BlogProject.Entities.Concrete.Category", b =>
                {
                    b.Navigation("Articles");
                });
#pragma warning restore 612, 618
        }
    }
}
