using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CS5227_A1_LIAWJ47006.Migrations
{
    /// <inheritdoc />
    public partial class AppToDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "289f60ea-22fd-47f3-b078-cfc4f9ab74b7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4cc5ac91-3441-456e-8f83-b6d54f5cd31a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bdc33b0c-2e15-47d4-9465-55787d4828b0");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "43543229-0f04-4f92-8f63-3902c506184c", null, "seller", "seller" },
                    { "966e74ac-20e7-445f-942a-07e46a747ca1", null, "client", "client" },
                    { "dffc5b49-b2b5-4ffb-bdb5-ee3847737eac", null, "admin", "admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "43543229-0f04-4f92-8f63-3902c506184c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "966e74ac-20e7-445f-942a-07e46a747ca1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dffc5b49-b2b5-4ffb-bdb5-ee3847737eac");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "289f60ea-22fd-47f3-b078-cfc4f9ab74b7", null, "admin", "admin" },
                    { "4cc5ac91-3441-456e-8f83-b6d54f5cd31a", null, "client", "client" },
                    { "bdc33b0c-2e15-47d4-9465-55787d4828b0", null, "seller", "seller" }
                });
        }
    }
}
