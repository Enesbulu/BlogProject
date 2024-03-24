using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlogProject.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedDataAccessLayerConfigForCommitAndCorrReq : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("2d531e41-521b-4a61-a8c0-c231bd234831"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("dca7b97e-3775-40bd-b3a1-46df36c63df8"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("e72b82f5-6e80-4367-88ff-e3bfed507dd7"));

            migrationBuilder.RenameColumn(
                name: "CommentCount",
                table: "Articles",
                newName: "CommnetCount");

            migrationBuilder.CreateTable(
                name: "COMMENTS",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArticleID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApprovedUserId = table.Column<Guid>(name: "ApprovedUserId ", type: "uniqueidentifier", nullable: false),
                    CommentContents = table.Column<string>(name: "CommentContents ", type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsPublished = table.Column<bool>(name: "IsPublished ", type: "bit", nullable: false),
                    IsApproved = table.Column<bool>(name: "IsApproved ", type: "bit", nullable: false),
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
                    table.PrimaryKey("PK_COMMENTS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_COMMENTS_Articles_ArticleID",
                        column: x => x.ArticleID,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_COMMENTS_Users_ApprovedUserId ",
                        column: x => x.ApprovedUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CorrectionRequests",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArticleID = table.Column<Guid>(type: "uniqueidentifier", maxLength: 40, nullable: false),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", maxLength: 40, nullable: false),
                    RequestContents = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_CorrectionRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CorrectionRequests_Articles_ArticleID",
                        column: x => x.ArticleID,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CorrectionRequests_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_COMMENTS_ApprovedUserId ",
                table: "COMMENTS",
                column: "ApprovedUserId ");

            migrationBuilder.CreateIndex(
                name: "IX_COMMENTS_ArticleID",
                table: "COMMENTS",
                column: "ArticleID");

            migrationBuilder.CreateIndex(
                name: "IX_CorrectionRequests_ArticleID",
                table: "CorrectionRequests",
                column: "ArticleID");

            migrationBuilder.CreateIndex(
                name: "IX_CorrectionRequests_UserID",
                table: "CorrectionRequests",
                column: "UserID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "COMMENTS");

            migrationBuilder.DropTable(
                name: "CorrectionRequests");

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

            migrationBuilder.RenameColumn(
                name: "CommnetCount",
                table: "Articles",
                newName: "CommentCount");

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "CommentCount", "Content", "CreatedBy", "CreatedDate", "Date", "DeletedBy", "DeletedDate", "ModifiedBy", "ModifiedDate", "Statu", "Thumbnail", "Title", "ViewCount", "isDeleted" },
                values: new object[,]
                {
                    { new Guid("2d531e41-521b-4a61-a8c0-c231bd234831"), new Guid("c33260dd-b051-4a2d-923a-4c16553e4753"), 10, "Java 11 ile ilgili makaleler", "System", new DateTime(2024, 3, 24, 0, 24, 35, 912, DateTimeKind.Local).AddTicks(2873), new DateTime(2024, 3, 24, 0, 24, 35, 912, DateTimeKind.Local).AddTicks(2871), null, null, null, null, 1, "java.png", "Java 11", 100, false },
                    { new Guid("dca7b97e-3775-40bd-b3a1-46df36c63df8"), new Guid("62efdf5e-a5a6-47c8-b853-8de7a23308b3"), 10, "Python 3.9 ile ilgili makaleler", "System", new DateTime(2024, 3, 24, 0, 24, 35, 912, DateTimeKind.Local).AddTicks(2878), new DateTime(2024, 3, 24, 0, 24, 35, 912, DateTimeKind.Local).AddTicks(2876), null, null, null, null, 1, "python.png", "Python 3.9", 100, false },
                    { new Guid("e72b82f5-6e80-4367-88ff-e3bfed507dd7"), new Guid("62efdf5e-a5a6-47c8-b853-8de7a23308b3"), 10, "C# 9.0 ile ilgili makaleler", "System", new DateTime(2024, 3, 24, 0, 24, 35, 912, DateTimeKind.Local).AddTicks(2853), new DateTime(2024, 3, 24, 0, 24, 35, 912, DateTimeKind.Local).AddTicks(2835), null, null, null, null, 1, "csharp.png", "C# 9.0", 100, false }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("62efdf5e-a5a6-47c8-b853-8de7a23308b3"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 24, 0, 24, 35, 925, DateTimeKind.Local).AddTicks(7670));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c33260dd-b051-4a2d-923a-4c16553e4753"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 24, 0, 24, 35, 925, DateTimeKind.Local).AddTicks(7688));
        }
    }
}
