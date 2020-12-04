using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 4, 23, 52, 32, 25, DateTimeKind.Local).AddTicks(1009),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 4, 23, 32, 3, 99, DateTimeKind.Local).AddTicks(1739));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("5d5087a7-94b6-458c-b8dc-6c5449c42810"), "7aef57a8-a5d0-42f9-8dfc-d0a8d427621b", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("5d5087a7-94b6-458c-b8dc-6c5449c42810"), new Guid("e6d35cf0-aa91-46ab-a880-1133ca8b99a8") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DoB", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("e6d35cf0-aa91-46ab-a880-1133ca8b99a8"), 0, "b7923f27-615f-47ef-8768-5b1a3814b241", new DateTime(2020, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "sangtp@gmail.com", true, "Sang", "TP", false, null, "sangtp@gmail.com", "admin", "AQAAAAEAACcQAAAAEH32fMunM21OlrpRev1a0dvpYRlYw/1GuUY1mvrbkfeLfBmAdth2UnNIdToB20U3Ug==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 12, 4, 23, 52, 32, 57, DateTimeKind.Local).AddTicks(4033));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("5d5087a7-94b6-458c-b8dc-6c5449c42810"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5d5087a7-94b6-458c-b8dc-6c5449c42810"), new Guid("e6d35cf0-aa91-46ab-a880-1133ca8b99a8") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("e6d35cf0-aa91-46ab-a880-1133ca8b99a8"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 4, 23, 32, 3, 99, DateTimeKind.Local).AddTicks(1739),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 4, 23, 52, 32, 25, DateTimeKind.Local).AddTicks(1009));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 12, 4, 23, 32, 3, 126, DateTimeKind.Local).AddTicks(4008));
        }
    }
}
