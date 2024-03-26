using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlogProject.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedTagInfrastructure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("53518256-7196-4e81-850d-b5e4d01abf7b"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("539d451f-c769-412a-9383-b5c9b72dc03f"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("db76e897-ba03-4a30-af39-dd22629a9a36"));

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TagName = table.Column<string>(name: "TagName ", type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Statu = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ArticleTags",
                columns: table => new
                {
                    ArticleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TagId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleTags", x => new { x.ArticleId, x.TagId });
                    table.ForeignKey(
                        name: "FK_ArticleTags_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticleTags_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ArticleTags_TagId",
                table: "ArticleTags",
                column: "TagId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticleTags");

            migrationBuilder.DropTable(
                name: "Tags");

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
                    { new Guid("53518256-7196-4e81-850d-b5e4d01abf7b"), new Guid("62efdf5e-a5a6-47c8-b853-8de7a23308b3"), 10, "Python 3.9 ile ilgili makaleler", "System", new DateTime(2024, 3, 25, 2, 31, 12, 587, DateTimeKind.Local).AddTicks(643), new DateTime(2024, 3, 25, 2, 31, 12, 587, DateTimeKind.Local).AddTicks(642), null, null, null, null, 1, "python.png", "Python 3.9", 100, false },
                    { new Guid("539d451f-c769-412a-9383-b5c9b72dc03f"), new Guid("c33260dd-b051-4a2d-923a-4c16553e4753"), 10, "Java 11 ile ilgili makaleler", "System", new DateTime(2024, 3, 25, 2, 31, 12, 587, DateTimeKind.Local).AddTicks(625), new DateTime(2024, 3, 25, 2, 31, 12, 587, DateTimeKind.Local).AddTicks(622), null, null, null, null, 1, "java.png", "Java 11", 100, false },
                    { new Guid("db76e897-ba03-4a30-af39-dd22629a9a36"), new Guid("62efdf5e-a5a6-47c8-b853-8de7a23308b3"), 10, "C# 9.0 ile ilgili makaleler", "System", new DateTime(2024, 3, 25, 2, 31, 12, 587, DateTimeKind.Local).AddTicks(612), new DateTime(2024, 3, 25, 2, 31, 12, 587, DateTimeKind.Local).AddTicks(586), null, null, null, null, 1, "csharp.png", "C# 9.0", 100, false }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("62efdf5e-a5a6-47c8-b853-8de7a23308b3"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 25, 2, 31, 12, 587, DateTimeKind.Local).AddTicks(3805));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c33260dd-b051-4a2d-923a-4c16553e4753"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 25, 2, 31, 12, 587, DateTimeKind.Local).AddTicks(3818));
        }
    }
}
