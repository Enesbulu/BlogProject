using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlogProject.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addedarticleseeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Editors_EditorId",
                table: "Articles");

            migrationBuilder.AlterColumn<Guid>(
                name: "EditorId",
                table: "Articles",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "AuthorId", "CategoryId", "CommnetCount", "Content", "CreatedBy", "CreatedDate", "Date", "DeletedBy", "DeletedDate", "EditorId", "ModifiedBy", "ModifiedDate", "Statu", "Thumbnail", "Title", "ViewCount", "isDeleted" },
                values: new object[,]
                {
                    { new Guid("7278fa9b-397a-47a9-8222-71cddaeeafda"), new Guid("1f3d3c64-b372-4a6b-ab7d-d940bd710ebe"), new Guid("62efdf5e-a5a6-47c8-b853-8de7a23308b3"), 10, "Python 3.9 ile ilgili makaleler", "System", new DateTime(2026, 1, 11, 22, 47, 6, 858, DateTimeKind.Local).AddTicks(5302), new DateTime(2026, 1, 11, 22, 47, 6, 858, DateTimeKind.Local).AddTicks(5301), null, null, new Guid("8fc0e49b-fc50-452e-825c-722f95163ea6"), null, null, 1, "python.png", "Python 3.9", 100, false },
                    { new Guid("b960f7fe-dcae-47b1-bb58-1b9932d68cdb"), new Guid("1f3d3c64-b372-4a6b-ab7d-d940bd710ebe"), new Guid("62efdf5e-a5a6-47c8-b853-8de7a23308b3"), 10, "C# 9.0 ile ilgili makaleler", "System", new DateTime(2026, 1, 11, 22, 47, 6, 858, DateTimeKind.Local).AddTicks(5278), new DateTime(2026, 1, 11, 22, 47, 6, 858, DateTimeKind.Local).AddTicks(4839), null, null, new Guid("8fc0e49b-fc50-452e-825c-722f95163ea6"), null, null, 1, "csharp.png", "C# 9.0", 100, false },
                    { new Guid("dcb6d8d1-02d7-4982-aa3b-9b6203712cd1"), new Guid("1f3d3c64-b372-4a6b-ab7d-d940bd710ebe"), new Guid("c33260dd-b051-4a2d-923a-4c16553e4753"), 10, "Java 11 ile ilgili makaleler", "System", new DateTime(2026, 1, 11, 22, 47, 6, 858, DateTimeKind.Local).AddTicks(5298), new DateTime(2026, 1, 11, 22, 47, 6, 858, DateTimeKind.Local).AddTicks(5296), null, null, new Guid("8fc0e49b-fc50-452e-825c-722f95163ea6"), null, null, 1, "java.png", "Java 11", 100, false }
                });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("1f3d3c64-b372-4a6b-ab7d-d940bd710ebe"),
                column: "ConcurrencyStamp",
                value: "5a178ddf-9d82-409a-bfdc-95a5f18bec30");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("2a4e5f76-c483-4b7c-bc8d-e051ce821fcf"),
                column: "ConcurrencyStamp",
                value: "2f1c5933-499f-4e1d-ba8c-1d1c09ace98e");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("62efdf5e-a5a6-47c8-b853-8de7a23308b3"),
                column: "CreatedDate",
                value: new DateTime(2026, 1, 11, 22, 47, 6, 858, DateTimeKind.Local).AddTicks(9433));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c33260dd-b051-4a2d-923a-4c16553e4753"),
                column: "CreatedDate",
                value: new DateTime(2026, 1, 11, 22, 47, 6, 858, DateTimeKind.Local).AddTicks(9445));

            migrationBuilder.UpdateData(
                table: "Editors",
                keyColumn: "Id",
                keyValue: new Guid("8fc0e49b-fc50-452e-825c-722f95163ea6"),
                column: "ConcurrencyStamp",
                value: "bae4aca2-33c0-4b42-bbb5-30ee545b3216");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Editors_EditorId",
                table: "Articles",
                column: "EditorId",
                principalTable: "Editors",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Editors_EditorId",
                table: "Articles");

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("7278fa9b-397a-47a9-8222-71cddaeeafda"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("b960f7fe-dcae-47b1-bb58-1b9932d68cdb"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("dcb6d8d1-02d7-4982-aa3b-9b6203712cd1"));

            migrationBuilder.AlterColumn<Guid>(
                name: "EditorId",
                table: "Articles",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("1f3d3c64-b372-4a6b-ab7d-d940bd710ebe"),
                column: "ConcurrencyStamp",
                value: "df8b842d-c09a-4ac6-888b-7fdc2649d746");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("2a4e5f76-c483-4b7c-bc8d-e051ce821fcf"),
                column: "ConcurrencyStamp",
                value: "564d39a9-c447-458b-876c-b032fc1d89a6");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Editors_EditorId",
                table: "Articles",
                column: "EditorId",
                principalTable: "Editors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
