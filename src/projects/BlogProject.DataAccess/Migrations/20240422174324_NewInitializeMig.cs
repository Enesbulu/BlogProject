using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogProject.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class NewInitializeMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("1f3d3c64-b372-4a6b-ab7d-d940bd710ebe"),
                column: "ConcurrencyStamp",
                value: "0ca3d6f3-11af-4f5d-a868-b500a8c9e829");

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

            migrationBuilder.UpdateData(
                table: "Editors",
                keyColumn: "Id",
                keyValue: new Guid("8fc0e49b-fc50-452e-825c-722f95163ea6"),
                column: "ConcurrencyStamp",
                value: "e4576dc2-12fc-4c52-9c4e-83ed31bd14d5");
        }
    }
}
