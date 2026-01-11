using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlogProject.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addedAuthorseedValue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("c01869ad-e3b2-4799-98bb-957f5725ca93"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("cd7ce4fb-2371-4d39-84dd-3d7d745306ed"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("d1fcb0fa-1c55-4c92-8490-ebe6fc64aa00"));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("1f3d3c64-b372-4a6b-ab7d-d940bd710ebe"),
                column: "ConcurrencyStamp",
                value: "df8b842d-c09a-4ac6-888b-7fdc2649d746");

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("2a4e5f76-c483-4b7c-bc8d-e051ce821fcf"), 0, "564d39a9-c447-458b-876c-b032fc1d89a6", "admin@admin.com", false, "admin", "admin", false, null, null, null, null, null, false, null, false, null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("62efdf5e-a5a6-47c8-b853-8de7a23308b3"),
                column: "CreatedDate",
                value: new DateTime(2026, 1, 11, 22, 38, 30, 748, DateTimeKind.Local).AddTicks(2972));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c33260dd-b051-4a2d-923a-4c16553e4753"),
                column: "CreatedDate",
                value: new DateTime(2026, 1, 11, 22, 38, 30, 748, DateTimeKind.Local).AddTicks(2989));

            migrationBuilder.UpdateData(
                table: "Editors",
                keyColumn: "Id",
                keyValue: new Guid("8fc0e49b-fc50-452e-825c-722f95163ea6"),
                column: "ConcurrencyStamp",
                value: "84a00819-6377-4e41-8644-dbd8961c4f1d");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("2a4e5f76-c483-4b7c-bc8d-e051ce821fcf"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "AuthorId", "CategoryId", "CommnetCount", "Content", "CreatedBy", "CreatedDate", "Date", "DeletedBy", "DeletedDate", "EditorId", "ModifiedBy", "ModifiedDate", "Statu", "Thumbnail", "Title", "ViewCount", "isDeleted" },
                values: new object[,]
                {
                    { new Guid("c01869ad-e3b2-4799-98bb-957f5725ca93"), new Guid("1f3d3c64-b372-4a6b-ab7d-d940bd710ebe"), new Guid("62efdf5e-a5a6-47c8-b853-8de7a23308b3"), 10, "C# 9.0 ile ilgili makaleler", "System", new DateTime(2026, 1, 10, 18, 38, 50, 565, DateTimeKind.Local).AddTicks(6903), new DateTime(2026, 1, 10, 18, 38, 50, 565, DateTimeKind.Local).AddTicks(6885), null, null, new Guid("8fc0e49b-fc50-452e-825c-722f95163ea6"), null, null, 1, "csharp.png", "C# 9.0", 100, false },
                    { new Guid("cd7ce4fb-2371-4d39-84dd-3d7d745306ed"), new Guid("1f3d3c64-b372-4a6b-ab7d-d940bd710ebe"), new Guid("62efdf5e-a5a6-47c8-b853-8de7a23308b3"), 10, "Python 3.9 ile ilgili makaleler", "System", new DateTime(2026, 1, 10, 18, 38, 50, 565, DateTimeKind.Local).AddTicks(6916), new DateTime(2026, 1, 10, 18, 38, 50, 565, DateTimeKind.Local).AddTicks(6915), null, null, new Guid("8fc0e49b-fc50-452e-825c-722f95163ea6"), null, null, 1, "python.png", "Python 3.9", 100, false },
                    { new Guid("d1fcb0fa-1c55-4c92-8490-ebe6fc64aa00"), new Guid("1f3d3c64-b372-4a6b-ab7d-d940bd710ebe"), new Guid("c33260dd-b051-4a2d-923a-4c16553e4753"), 10, "Java 11 ile ilgili makaleler", "System", new DateTime(2026, 1, 10, 18, 38, 50, 565, DateTimeKind.Local).AddTicks(6912), new DateTime(2026, 1, 10, 18, 38, 50, 565, DateTimeKind.Local).AddTicks(6911), null, null, new Guid("8fc0e49b-fc50-452e-825c-722f95163ea6"), null, null, 1, "java.png", "Java 11", 100, false }
                });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("1f3d3c64-b372-4a6b-ab7d-d940bd710ebe"),
                column: "ConcurrencyStamp",
                value: "b226f565-aa39-46ec-a2fa-e857a1d9477d");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("62efdf5e-a5a6-47c8-b853-8de7a23308b3"),
                column: "CreatedDate",
                value: new DateTime(2026, 1, 10, 18, 38, 50, 566, DateTimeKind.Local).AddTicks(254));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c33260dd-b051-4a2d-923a-4c16553e4753"),
                column: "CreatedDate",
                value: new DateTime(2026, 1, 10, 18, 38, 50, 566, DateTimeKind.Local).AddTicks(265));

            migrationBuilder.UpdateData(
                table: "Editors",
                keyColumn: "Id",
                keyValue: new Guid("8fc0e49b-fc50-452e-825c-722f95163ea6"),
                column: "ConcurrencyStamp",
                value: "4d306a51-0eeb-4884-bc7f-2a1211bc4184");
        }
    }
}
