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
    [Migration("20240326232655_AddedTagInfrastructure")]
    partial class AddedTagInfrastructure
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlogProject.Entities.Concrete.AuthEntities.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNAmeIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Roles", (string)null);
                });

            modelBuilder.Entity("BlogProject.Entities.Concrete.AuthEntities.RoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaim", (string)null);
                });

            modelBuilder.Entity("BlogProject.Entities.Concrete.AuthEntities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("LastName")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("BlogProject.Entities.Concrete.AuthEntities.UserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims", (string)null);
                });

            modelBuilder.Entity("BlogProject.Entities.Concrete.AuthEntities.UserLogin", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins", (string)null);
                });

            modelBuilder.Entity("BlogProject.Entities.Concrete.AuthEntities.UserRole", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles", (string)null);
                });

            modelBuilder.Entity("BlogProject.Entities.Concrete.AuthEntities.UserToken", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("USerTokens", (string)null);
                });

            modelBuilder.Entity("BlogProject.Entities.Concrete.Entities.Article", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("CategoryId");

                    b.Property<int>("CommentCount")
                        .HasColumnType("int")
                        .HasColumnName("CommnetCount");

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
                            Id = new Guid("91393cb2-88ef-456c-bea1-a8ef66ff3c03"),
                            CategoryId = new Guid("62efdf5e-a5a6-47c8-b853-8de7a23308b3"),
                            CommentCount = 10,
                            Content = "C# 9.0 ile ilgili makaleler",
                            CreatedBy = "System",
                            CreatedDate = new DateTime(2024, 3, 27, 2, 26, 55, 288, DateTimeKind.Local).AddTicks(9898),
                            Date = new DateTime(2024, 3, 27, 2, 26, 55, 288, DateTimeKind.Local).AddTicks(9872),
                            Statu = 1,
                            Thumbnail = "csharp.png",
                            Title = "C# 9.0",
                            ViewCount = 100,
                            isDeleted = false
                        },
                        new
                        {
                            Id = new Guid("42a20358-b01a-42a9-86d7-c90be4128fd7"),
                            CategoryId = new Guid("c33260dd-b051-4a2d-923a-4c16553e4753"),
                            CommentCount = 10,
                            Content = "Java 11 ile ilgili makaleler",
                            CreatedBy = "System",
                            CreatedDate = new DateTime(2024, 3, 27, 2, 26, 55, 288, DateTimeKind.Local).AddTicks(9919),
                            Date = new DateTime(2024, 3, 27, 2, 26, 55, 288, DateTimeKind.Local).AddTicks(9915),
                            Statu = 1,
                            Thumbnail = "java.png",
                            Title = "Java 11",
                            ViewCount = 100,
                            isDeleted = false
                        },
                        new
                        {
                            Id = new Guid("e9bb5381-edb2-4269-9698-1726b1a92a52"),
                            CategoryId = new Guid("62efdf5e-a5a6-47c8-b853-8de7a23308b3"),
                            CommentCount = 10,
                            Content = "Python 3.9 ile ilgili makaleler",
                            CreatedBy = "System",
                            CreatedDate = new DateTime(2024, 3, 27, 2, 26, 55, 288, DateTimeKind.Local).AddTicks(9925),
                            Date = new DateTime(2024, 3, 27, 2, 26, 55, 288, DateTimeKind.Local).AddTicks(9923),
                            Statu = 1,
                            Thumbnail = "python.png",
                            Title = "Python 3.9",
                            ViewCount = 100,
                            isDeleted = false
                        });
                });

            modelBuilder.Entity("BlogProject.Entities.Concrete.Entities.Category", b =>
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
                            CreatedDate = new DateTime(2024, 3, 27, 2, 26, 55, 289, DateTimeKind.Local).AddTicks(5216),
                            Description = "C# ile ilgili makaleler",
                            Name = "C#",
                            Statu = 1,
                            isDeleted = false
                        },
                        new
                        {
                            Id = new Guid("c33260dd-b051-4a2d-923a-4c16553e4753"),
                            CreatedBy = "System",
                            CreatedDate = new DateTime(2024, 3, 27, 2, 26, 55, 289, DateTimeKind.Local).AddTicks(5234),
                            Description = "Java ile ilgili makaleler",
                            Name = "Java",
                            Statu = 1,
                            isDeleted = false
                        });
                });

            modelBuilder.Entity("BlogProject.Entities.Concrete.Entities.Comment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ApprovedUserId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ApprovedUserId ");

                    b.Property<Guid>("ArticleId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ArticleID");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("CommentContents ");

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

                    b.Property<bool>("IsApproved")
                        .HasColumnType("bit")
                        .HasColumnName("IsApproved ");

                    b.Property<bool>("IsPublished")
                        .HasColumnType("bit")
                        .HasColumnName("IsPublished ");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Statu")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("UserID");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ApprovedUserId");

                    b.HasIndex("ArticleId");

                    b.ToTable("COMMENTS", (string)null);
                });

            modelBuilder.Entity("BlogProject.Entities.Concrete.Entities.CorrectionRequest", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ArticleId")
                        .HasMaxLength(40)
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ArticleID");

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

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("RequestContent")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasColumnName("RequestContents");

                    b.Property<int>("Statu")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int")
                        .HasColumnName("Status");

                    b.Property<Guid>("UserId")
                        .HasMaxLength(40)
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("UserID");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ArticleId");

                    b.HasIndex("UserId");

                    b.ToTable("CorrectionRequests", (string)null);
                });

            modelBuilder.Entity("BlogProject.Entities.Concrete.Entities.RelationshipTables.ArticlesTags", b =>
                {
                    b.Property<Guid>("ArticleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TagId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ArticleId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("ArticleTags", (string)null);
                });

            modelBuilder.Entity("BlogProject.Entities.Concrete.Entities.Tag", b =>
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

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("TagName ");

                    b.Property<int>("Statu")
                        .HasColumnType("int");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Tags", (string)null);
                });

            modelBuilder.Entity("BlogProject.Entities.Concrete.AuthEntities.RoleClaim", b =>
                {
                    b.HasOne("BlogProject.Entities.Concrete.AuthEntities.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BlogProject.Entities.Concrete.AuthEntities.UserClaim", b =>
                {
                    b.HasOne("BlogProject.Entities.Concrete.AuthEntities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BlogProject.Entities.Concrete.AuthEntities.UserLogin", b =>
                {
                    b.HasOne("BlogProject.Entities.Concrete.AuthEntities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BlogProject.Entities.Concrete.AuthEntities.UserRole", b =>
                {
                    b.HasOne("BlogProject.Entities.Concrete.AuthEntities.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlogProject.Entities.Concrete.AuthEntities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BlogProject.Entities.Concrete.AuthEntities.UserToken", b =>
                {
                    b.HasOne("BlogProject.Entities.Concrete.AuthEntities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BlogProject.Entities.Concrete.Entities.Article", b =>
                {
                    b.HasOne("BlogProject.Entities.Concrete.Entities.Category", "Category")
                        .WithMany("Articles")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BlogProject.Entities.Concrete.Entities.Comment", b =>
                {
                    b.HasOne("BlogProject.Entities.Concrete.AuthEntities.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("ApprovedUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlogProject.Entities.Concrete.Entities.Article", "Article")
                        .WithMany("Comment")
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Article");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BlogProject.Entities.Concrete.Entities.CorrectionRequest", b =>
                {
                    b.HasOne("BlogProject.Entities.Concrete.Entities.Article", "Article")
                        .WithMany("CorrectionRequest")
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlogProject.Entities.Concrete.AuthEntities.User", "User")
                        .WithMany("CorrectionRequests")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Article");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BlogProject.Entities.Concrete.Entities.RelationshipTables.ArticlesTags", b =>
                {
                    b.HasOne("BlogProject.Entities.Concrete.Entities.Article", "Article")
                        .WithMany("ArticleTags")
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlogProject.Entities.Concrete.Entities.Tag", "Tag")
                        .WithMany("ArticleTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Article");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("BlogProject.Entities.Concrete.AuthEntities.User", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("CorrectionRequests");
                });

            modelBuilder.Entity("BlogProject.Entities.Concrete.Entities.Article", b =>
                {
                    b.Navigation("ArticleTags");

                    b.Navigation("Comment");

                    b.Navigation("CorrectionRequest");
                });

            modelBuilder.Entity("BlogProject.Entities.Concrete.Entities.Category", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("BlogProject.Entities.Concrete.Entities.Tag", b =>
                {
                    b.Navigation("ArticleTags");
                });
#pragma warning restore 612, 618
        }
    }
}
