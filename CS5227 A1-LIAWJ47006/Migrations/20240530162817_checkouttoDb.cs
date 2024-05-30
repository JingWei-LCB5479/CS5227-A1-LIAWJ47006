using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CS5227_A1_LIAWJ47006.Migrations
{
    /// <inheritdoc />
    public partial class checkouttoDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ebf9a1d-5a69-4035-9620-04d5374c345e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "23c384e3-ba0a-48d1-8506-2c22c7d4354e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbad5f8c-d33f-4d9e-9e2a-8c5eb02b3c38");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "59163aaf-062f-46ad-a19d-fe41fd17fbbd", null, "seller", "seller" },
                    { "96d5d8ed-93bc-41af-bf3c-5a0544a207c3", null, "admin", "admin" },
                    { "a5e0a984-e184-42b9-9b01-d8fc9d4c86a7", null, "client", "client" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "59163aaf-062f-46ad-a19d-fe41fd17fbbd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96d5d8ed-93bc-41af-bf3c-5a0544a207c3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5e0a984-e184-42b9-9b01-d8fc9d4c86a7");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0ebf9a1d-5a69-4035-9620-04d5374c345e", null, "client", "client" },
                    { "23c384e3-ba0a-48d1-8506-2c22c7d4354e", null, "admin", "admin" },
                    { "cbad5f8c-d33f-4d9e-9e2a-8c5eb02b3c38", null, "seller", "seller" }
                });
        }
    }
}
