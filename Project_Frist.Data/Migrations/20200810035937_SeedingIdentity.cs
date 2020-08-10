using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project_Frist.Data.Migrations
{
    public partial class SeedingIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Order",
                nullable: false,
                defaultValue: new DateTime(2020, 8, 10, 10, 59, 36, 284, DateTimeKind.Local).AddTicks(8457),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 8, 10, 10, 49, 11, 928, DateTimeKind.Local).AddTicks(4043));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), "719a47b5-eafc-4e95-9186-38871b1ccf6b", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new Guid("8d04dce2-969a-435d-bba4-df3f325983dc") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), 0, "32517b7b-6b53-4eb1-a8e6-801dbf80636e", new DateTime(2020, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "trungvd@gemvietnam.com", true, "Vu", "Trung", false, null, "trungvd@gemvietnam.com", "admin", "AQAAAAEAACcQAAAAEMns8+Qt22mN8WXvJZhY/foTJtQkX+RKcxknAjjwWgP5gAM1gkPugxnud4IIbclIVQ==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 8, 10, 10, 59, 36, 314, DateTimeKind.Local).AddTicks(6908));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new Guid("8d04dce2-969a-435d-bba4-df3f325983dc") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 8, 10, 10, 49, 11, 928, DateTimeKind.Local).AddTicks(4043),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 8, 10, 10, 59, 36, 284, DateTimeKind.Local).AddTicks(8457));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 8, 10, 10, 49, 11, 949, DateTimeKind.Local).AddTicks(8202));
        }
    }
}
