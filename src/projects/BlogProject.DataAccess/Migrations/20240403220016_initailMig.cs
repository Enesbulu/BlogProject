using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlogProject.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class initailMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("42a20358-b01a-42a9-86d7-c90be4128fd7"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("91393cb2-88ef-456c-bea1-a8ef66ff3c03"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("e9bb5381-edb2-4269-9698-1726b1a92a52"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "CommnetCount", "Content", "CreatedBy", "CreatedDate", "Date", "DeletedBy", "DeletedDate", "ModifiedBy", "ModifiedDate", "Statu", "Thumbnail", "Title", "ViewCount", "isDeleted" },
                values: new object[,]
                {
                    { new Guid("42a20358-b01a-42a9-86d7-c90be4128fd7"), new Guid("c33260dd-b051-4a2d-923a-4c16553e4753"), 10, "Java 11 ile ilgili makaleler", "System", new DateTime(2024, 3, 27, 2, 26, 55, 288, DateTimeKind.Local).AddTicks(9919), new DateTime(2024, 3, 27, 2, 26, 55, 288, DateTimeKind.Local).AddTicks(9915), null, null, null, null, 1, "java.png", "Java 11", 100, false },
                    { new Guid("91393cb2-88ef-456c-bea1-a8ef66ff3c03"), new Guid("62efdf5e-a5a6-47c8-b853-8de7a23308b3"), 10, "C# 9.0 ile ilgili makaleler", "System", new DateTime(2024, 3, 27, 2, 26, 55, 288, DateTimeKind.Local).AddTicks(9898), new DateTime(2024, 3, 27, 2, 26, 55, 288, DateTimeKind.Local).AddTicks(9872), null, null, null, null, 1, "csharp.png", "C# 9.0", 100, false },
                    { new Guid("e9bb5381-edb2-4269-9698-1726b1a92a52"), new Guid("62efdf5e-a5a6-47c8-b853-8de7a23308b3"), 10, "Python 3.9 ile ilgili makaleler", "System", new DateTime(2024, 3, 27, 2, 26, 55, 288, DateTimeKind.Local).AddTicks(9925), new DateTime(2024, 3, 27, 2, 26, 55, 288, DateTimeKind.Local).AddTicks(9923), null, null, null, null, 1, "python.png", "Python 3.9", 100, false }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("62efdf5e-a5a6-47c8-b853-8de7a23308b3"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 27, 2, 26, 55, 289, DateTimeKind.Local).AddTicks(5216));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c33260dd-b051-4a2d-923a-4c16553e4753"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 27, 2, 26, 55, 289, DateTimeKind.Local).AddTicks(5234));
        }
    }
}
