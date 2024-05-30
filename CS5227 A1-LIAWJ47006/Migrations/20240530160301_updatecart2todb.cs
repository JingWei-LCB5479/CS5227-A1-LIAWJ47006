using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CS5227_A1_LIAWJ47006.Migrations
{
    /// <inheritdoc />
    public partial class updatecart2todb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f0ae23f-332c-4b25-bb92-05a61a3183e5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "425d49d8-6157-4d4d-a074-b247a88a5898");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "61ea0cb9-a280-4e49-b073-678055141733");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "CartItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "CartItems");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0f0ae23f-332c-4b25-bb92-05a61a3183e5", null, "seller", "seller" },
                    { "425d49d8-6157-4d4d-a074-b247a88a5898", null, "client", "client" },
                    { "61ea0cb9-a280-4e49-b073-678055141733", null, "admin", "admin" }
                });
        }
    }
}
