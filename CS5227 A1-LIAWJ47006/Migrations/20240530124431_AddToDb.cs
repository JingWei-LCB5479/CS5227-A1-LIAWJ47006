using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CS5227_A1_LIAWJ47006.Migrations
{
    /// <inheritdoc />
    public partial class AddToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "09290cff-2aeb-4a1c-8507-e362402f6b0e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "350de496-00c3-41f9-a4ba-89451edfae12");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d884da13-582e-4c25-a6d6-72ceb806b749");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "52ef8642-d3e3-48e1-bc6c-37260e6c72a2", null, "client", "client" },
                    { "5c651e21-2f80-46e8-8b40-28d00e4ba040", null, "seller", "seller" },
                    { "fe1e0160-74ac-4820-bec8-8af4e875df89", null, "admin", "admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "52ef8642-d3e3-48e1-bc6c-37260e6c72a2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5c651e21-2f80-46e8-8b40-28d00e4ba040");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe1e0160-74ac-4820-bec8-8af4e875df89");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "09290cff-2aeb-4a1c-8507-e362402f6b0e", null, "admin", "admin" },
                    { "350de496-00c3-41f9-a4ba-89451edfae12", null, "seller", "seller" },
                    { "d884da13-582e-4c25-a6d6-72ceb806b749", null, "client", "client" }
                });
        }
    }
}
