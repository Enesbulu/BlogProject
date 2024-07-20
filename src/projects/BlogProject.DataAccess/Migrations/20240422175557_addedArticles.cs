using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlogProject.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addedArticles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "AuthorId", "CategoryId", "CommnetCount", "Content", "CreatedBy", "CreatedDate", "Date", "DeletedBy", "DeletedDate", "EditorId", "ModifiedBy", "ModifiedDate", "Statu", "Thumbnail", "Title", "ViewCount", "isDeleted" },
                values: new object[,]
                {
                    { new Guid("3d9e42e2-b866-43b1-b29f-83d62733ca00"), new Guid("1f3d3c64-b372-4a6b-ab7d-d940bd710ebe"), new Guid("62efdf5e-a5a6-47c8-b853-8de7a23308b3"), 10, "Python 3.9 ile ilgili makaleler", "System", new DateTime(2024, 4, 22, 20, 55, 57, 338, DateTimeKind.Local).AddTicks(3658), new DateTime(2024, 4, 22, 20, 55, 57, 338, DateTimeKind.Local).AddTicks(3656), null, null, new Guid("8fc0e49b-fc50-452e-825c-722f95163ea6"), null, null, 1, "python.png", "Python 3.9", 100, false },
                    { new Guid("94ac6e80-1187-4623-bfbe-9149a0c04ef6"), new Guid("1f3d3c64-b372-4a6b-ab7d-d940bd710ebe"), new Guid("62efdf5e-a5a6-47c8-b853-8de7a23308b3"), 10, "C# 9.0 ile ilgili makaleler", "System", new DateTime(2024, 4, 22, 20, 55, 57, 338, DateTimeKind.Local).AddTicks(3639), new DateTime(2024, 4, 22, 20, 55, 57, 338, DateTimeKind.Local).AddTicks(3617), null, null, new Guid("8fc0e49b-fc50-452e-825c-722f95163ea6"), null, null, 1, "csharp.png", "C# 9.0", 100, false },
                    { new Guid("df1004b4-e6c9-4fe1-b87d-4a87f76e6e8d"), new Guid("1f3d3c64-b372-4a6b-ab7d-d940bd710ebe"), new Guid("c33260dd-b051-4a2d-923a-4c16553e4753"), 10, "Java 11 ile ilgili makaleler", "System", new DateTime(2024, 4, 22, 20, 55, 57, 338, DateTimeKind.Local).AddTicks(3652), new DateTime(2024, 4, 22, 20, 55, 57, 338, DateTimeKind.Local).AddTicks(3650), null, null, new Guid("8fc0e49b-fc50-452e-825c-722f95163ea6"), null, null, 1, "java.png", "Java 11", 100, false }
                });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("1f3d3c64-b372-4a6b-ab7d-d940bd710ebe"),
                column: "ConcurrencyStamp",
                value: "bf804529-e20a-433d-af11-782961a1fb2b");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("62efdf5e-a5a6-47c8-b853-8de7a23308b3"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 20, 55, 57, 338, DateTimeKind.Local).AddTicks(7978));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c33260dd-b051-4a2d-923a-4c16553e4753"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 20, 55, 57, 338, DateTimeKind.Local).AddTicks(7987));

            migrationBuilder.UpdateData(
                table: "Editors",
                keyColumn: "Id",
                keyValue: new Guid("8fc0e49b-fc50-452e-825c-722f95163ea6"),
                column: "ConcurrencyStamp",
                value: "2fb2ad52-4c87-4289-b1e6-5d2f820d2185");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("3d9e42e2-b866-43b1-b29f-83d62733ca00"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("94ac6e80-1187-4623-bfbe-9149a0c04ef6"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("df1004b4-e6c9-4fe1-b87d-4a87f76e6e8d"));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("1f3d3c64-b372-4a6b-ab7d-d940bd710ebe"),
                column: "ConcurrencyStamp",
                value: "32dd11e3-e063-4100-aaa8-5581ef757824");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("62efdf5e-a5a6-47c8-b853-8de7a23308b3"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 20, 43, 23, 702, DateTimeKind.Local).AddTicks(8139));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c33260dd-b051-4a2d-923a-4c16553e4753"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 20, 43, 23, 702, DateTimeKind.Local).AddTicks(8157));

            migrationBuilder.UpdateData(
                table: "Editors",
                keyColumn: "Id",
                keyValue: new Guid("8fc0e49b-fc50-452e-825c-722f95163ea6"),
                column: "ConcurrencyStamp",
                value: "7e90b014-3fcf-4044-8e43-7f3c6b6bcb4e");
        }
    }
}
