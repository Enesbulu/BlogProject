using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlogProject.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedEditorAuthor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("0ac3ee9a-98fd-4b59-9e6c-db39e85bc97d"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("3db3d7e6-b63f-432e-8346-a4218f0f858a"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("de0f4eef-442d-44c3-be1b-4969029d9185"));

            migrationBuilder.AddColumn<Guid>(
                name: "AuthorId",
                table: "Articles",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "EditorId",
                table: "Articles",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Editors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Editors", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("1f3d3c64-b372-4a6b-ab7d-d940bd710ebe"), 0, "0ca3d6f3-11af-4f5d-a868-b500a8c9e829", "orhan_balcik.@mail.com", false, "Orhan", "Balçık", false, null, null, null, null, null, false, null, false, null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("62efdf5e-a5a6-47c8-b853-8de7a23308b3"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 4, 4, 0, 42, 886, DateTimeKind.Local).AddTicks(2320));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c33260dd-b051-4a2d-923a-4c16553e4753"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 4, 4, 0, 42, 886, DateTimeKind.Local).AddTicks(2339));

            migrationBuilder.InsertData(
                table: "Editors",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("8fc0e49b-fc50-452e-825c-722f95163ea6"), 0, "e4576dc2-12fc-4c52-9c4e-83ed31bd14d5", "yaver_kocan.@mail.com", false, "Yaver", "Koçan", false, null, null, null, null, null, false, null, false, null });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_AuthorId",
                table: "Articles",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_EditorId",
                table: "Articles",
                column: "EditorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Authors_AuthorId",
                table: "Articles",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Editors_EditorId",
                table: "Articles",
                column: "EditorId",
                principalTable: "Editors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Authors_AuthorId",
                table: "Articles");

            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Editors_EditorId",
                table: "Articles");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Editors");

            migrationBuilder.DropIndex(
                name: "IX_Articles_AuthorId",
                table: "Articles");

            migrationBuilder.DropIndex(
                name: "IX_Articles_EditorId",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "EditorId",
                table: "Articles");

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "CommnetCount", "Content", "CreatedBy", "CreatedDate", "Date", "DeletedBy", "DeletedDate", "ModifiedBy", "ModifiedDate", "Statu", "Thumbnail", "Title", "ViewCount", "isDeleted" },
                values: new object[,]
                {
                    { new Guid("0ac3ee9a-98fd-4b59-9e6c-db39e85bc97d"), new Guid("62efdf5e-a5a6-47c8-b853-8de7a23308b3"), 10, "Python 3.9 ile ilgili makaleler", "System", new DateTime(2024, 4, 4, 1, 0, 15, 747, DateTimeKind.Local).AddTicks(5243), new DateTime(2024, 4, 4, 1, 0, 15, 747, DateTimeKind.Local).AddTicks(5240), null, null, null, null, 1, "python.png", "Python 3.9", 100, false },
                    { new Guid("3db3d7e6-b63f-432e-8346-a4218f0f858a"), new Guid("62efdf5e-a5a6-47c8-b853-8de7a23308b3"), 10, "C# 9.0 ile ilgili makaleler", "System", new DateTime(2024, 4, 4, 1, 0, 15, 747, DateTimeKind.Local).AddTicks(5195), new DateTime(2024, 4, 4, 1, 0, 15, 747, DateTimeKind.Local).AddTicks(5160), null, null, null, null, 1, "csharp.png", "C# 9.0", 100, false },
                    { new Guid("de0f4eef-442d-44c3-be1b-4969029d9185"), new Guid("c33260dd-b051-4a2d-923a-4c16553e4753"), 10, "Java 11 ile ilgili makaleler", "System", new DateTime(2024, 4, 4, 1, 0, 15, 747, DateTimeKind.Local).AddTicks(5215), new DateTime(2024, 4, 4, 1, 0, 15, 747, DateTimeKind.Local).AddTicks(5211), null, null, null, null, 1, "java.png", "Java 11", 100, false }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("62efdf5e-a5a6-47c8-b853-8de7a23308b3"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 4, 1, 0, 15, 748, DateTimeKind.Local).AddTicks(2417));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c33260dd-b051-4a2d-923a-4c16553e4753"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 4, 1, 0, 15, 748, DateTimeKind.Local).AddTicks(2440));
        }
    }
}
