using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlogProject.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class testMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("2f9c414e-c0c2-4f3e-b67c-343287c0f330"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("56085fc3-6ff0-4a10-a04a-4d3a91684a96"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("868eb3aa-52ca-4f41-9ebc-0b7ca5b90861"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "CommentCount", "Content", "CreatedBy", "CreatedDate", "Date", "DeletedBy", "DeletedDate", "ModifiedBy", "ModifiedDate", "Statu", "Thumbnail", "Title", "ViewCount", "isDeleted" },
                values: new object[,]
                {
                    { new Guid("69e3fd25-8d9d-42af-8563-77a75ed42786"), new Guid("c33260dd-b051-4a2d-923a-4c16553e4753"), 10, "Java 11 ile ilgili makaleler", "System", new DateTime(2024, 2, 10, 11, 5, 44, 878, DateTimeKind.Local).AddTicks(2886), new DateTime(2024, 2, 10, 11, 5, 44, 878, DateTimeKind.Local).AddTicks(2884), null, null, null, null, 1, "java.png", "Java 11", 100, false },
                    { new Guid("953498a7-c2f3-4a7b-8659-5cbddccf8324"), new Guid("62efdf5e-a5a6-47c8-b853-8de7a23308b3"), 10, "C# 9.0 ile ilgili makaleler", "System", new DateTime(2024, 2, 10, 11, 5, 44, 878, DateTimeKind.Local).AddTicks(2868), new DateTime(2024, 2, 10, 11, 5, 44, 878, DateTimeKind.Local).AddTicks(2848), null, null, null, null, 1, "csharp.png", "C# 9.0", 100, false },
                    { new Guid("b3fd5561-82cf-4de4-ae8b-2e986afd60e5"), new Guid("62efdf5e-a5a6-47c8-b853-8de7a23308b3"), 10, "Python 3.9 ile ilgili makaleler", "System", new DateTime(2024, 2, 10, 11, 5, 44, 878, DateTimeKind.Local).AddTicks(2891), new DateTime(2024, 2, 10, 11, 5, 44, 878, DateTimeKind.Local).AddTicks(2889), null, null, null, null, 1, "python.png", "Python 3.9", 100, false }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("62efdf5e-a5a6-47c8-b853-8de7a23308b3"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 11, 5, 44, 878, DateTimeKind.Local).AddTicks(6285));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c33260dd-b051-4a2d-923a-4c16553e4753"),
                column: "CreatedDate",
                value: new DateTime(2024, 2, 10, 11, 5, 44, 878, DateTimeKind.Local).AddTicks(6295));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("69e3fd25-8d9d-42af-8563-77a75ed42786"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("953498a7-c2f3-4a7b-8659-5cbddccf8324"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("b3fd5561-82cf-4de4-ae8b-2e986afd60e5"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "CommentCount", "Content", "CreatedBy", "CreatedDate", "Date", "DeletedBy", "DeletedDate", "ModifiedBy", "ModifiedDate", "Statu", "Thumbnail", "Title", "ViewCount", "isDeleted" },
                values: new object[,]
                {
                    { new Guid("2f9c414e-c0c2-4f3e-b67c-343287c0f330"), new Guid("62efdf5e-a5a6-47c8-b853-8de7a23308b3"), 10, "C# 9.0 ile ilgili makaleler", "System", new DateTime(2024, 1, 30, 16, 29, 4, 950, DateTimeKind.Local).AddTicks(971), new DateTime(2024, 1, 30, 16, 29, 4, 950, DateTimeKind.Local).AddTicks(949), null, null, null, null, 1, "csharp.png", "C# 9.0", 100, false },
                    { new Guid("56085fc3-6ff0-4a10-a04a-4d3a91684a96"), new Guid("c33260dd-b051-4a2d-923a-4c16553e4753"), 10, "Java 11 ile ilgili makaleler", "System", new DateTime(2024, 1, 30, 16, 29, 4, 950, DateTimeKind.Local).AddTicks(992), new DateTime(2024, 1, 30, 16, 29, 4, 950, DateTimeKind.Local).AddTicks(990), null, null, null, null, 1, "java.png", "Java 11", 100, false },
                    { new Guid("868eb3aa-52ca-4f41-9ebc-0b7ca5b90861"), new Guid("62efdf5e-a5a6-47c8-b853-8de7a23308b3"), 10, "Python 3.9 ile ilgili makaleler", "System", new DateTime(2024, 1, 30, 16, 29, 4, 950, DateTimeKind.Local).AddTicks(997), new DateTime(2024, 1, 30, 16, 29, 4, 950, DateTimeKind.Local).AddTicks(996), null, null, null, null, 1, "python.png", "Python 3.9", 100, false }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("62efdf5e-a5a6-47c8-b853-8de7a23308b3"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 30, 16, 29, 4, 950, DateTimeKind.Local).AddTicks(4929));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c33260dd-b051-4a2d-923a-4c16553e4753"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 30, 16, 29, 4, 950, DateTimeKind.Local).AddTicks(4940));
        }
    }
}
