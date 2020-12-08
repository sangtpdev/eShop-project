using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class AddProductImageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Detail",
                table: "ProductTranslations",
                newName: "Details");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 4, 23, 52, 32, 25, DateTimeKind.Local).AddTicks(1009));

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    productId = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<int>(type: "int", maxLength: 200, nullable: false),
                    Caption = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    FileSize = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_productId",
                        column: x => x.productId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("5d5087a7-94b6-458c-b8dc-6c5449c42810"),
                column: "ConcurrencyStamp",
                value: "a6d3f770-f09f-46ce-ba57-63d9da81778f");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("e6d35cf0-aa91-46ab-a880-1133ca8b99a8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9ea0bcf1-ba59-495e-88b9-4b40eae06af8", "AQAAAAEAACcQAAAAEH6WmtpMzFaS+BzCQT4hmgN9HcrnYYSLhgFPdqXEiT8/7chNHy2OZvEWZm5poaloJQ==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 12, 7, 23, 24, 9, 37, DateTimeKind.Local).AddTicks(2236));

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_productId",
                table: "ProductImages",
                column: "productId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.RenameColumn(
                name: "Details",
                table: "ProductTranslations",
                newName: "Detail");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 4, 23, 52, 32, 25, DateTimeKind.Local).AddTicks(1009),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("5d5087a7-94b6-458c-b8dc-6c5449c42810"),
                column: "ConcurrencyStamp",
                value: "7aef57a8-a5d0-42f9-8dfc-d0a8d427621b");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("e6d35cf0-aa91-46ab-a880-1133ca8b99a8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b7923f27-615f-47ef-8768-5b1a3814b241", "AQAAAAEAACcQAAAAEH32fMunM21OlrpRev1a0dvpYRlYw/1GuUY1mvrbkfeLfBmAdth2UnNIdToB20U3Ug==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 12, 4, 23, 52, 32, 57, DateTimeKind.Local).AddTicks(4033));
        }
    }
}
