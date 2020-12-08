using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class ChangeFileLengthType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_Products_productId",
                table: "ProductImages");

            migrationBuilder.RenameColumn(
                name: "productId",
                table: "ProductImages",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductImages_productId",
                table: "ProductImages",
                newName: "IX_ProductImages_ProductId");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("5d5087a7-94b6-458c-b8dc-6c5449c42810"),
                column: "ConcurrencyStamp",
                value: "cce5b2c7-151b-47ec-8df3-50f7ff35536b");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("e6d35cf0-aa91-46ab-a880-1133ca8b99a8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ac342e3c-7f7e-4ee9-9729-464d3e8dff63", "AQAAAAEAACcQAAAAEEWOT46rSCSntBVfuN5p+avTaxNBOARzBcKiPNhMDQj2etNlafQ6Aqgvi0hNBlfv+g==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 12, 8, 1, 53, 21, 994, DateTimeKind.Local).AddTicks(5914));

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_Products_ProductId",
                table: "ProductImages",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_Products_ProductId",
                table: "ProductImages");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "ProductImages",
                newName: "productId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                newName: "IX_ProductImages_productId");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("5d5087a7-94b6-458c-b8dc-6c5449c42810"),
                column: "ConcurrencyStamp",
                value: "b6769a39-e552-4c36-b73a-15592477c3a5");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("e6d35cf0-aa91-46ab-a880-1133ca8b99a8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "61cdb5ea-4cc4-4984-8a82-db30718cc455", "AQAAAAEAACcQAAAAEC+5fv/1nUEXpRC4/OUJqCNYeQtVSe4xqRvcKBoo5Y73uTLxpOunVPS1RMf/73OuOg==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 12, 8, 1, 40, 35, 275, DateTimeKind.Local).AddTicks(3604));

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_Products_productId",
                table: "ProductImages",
                column: "productId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
