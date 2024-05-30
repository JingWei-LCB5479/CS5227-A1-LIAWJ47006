using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CS5227_A1_LIAWJ47006.Migrations
{
    /// <inheritdoc />
    public partial class updatecart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a763a786-7821-4dc2-abe6-f5bac0be7083");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b3a7609b-b317-4297-901b-20fba3a40863");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b7f9e8f1-0b51-4bcb-a0bb-303f75713b1d");

            migrationBuilder.AddColumn<float>(
                name: "Price",
                table: "CartItems",
                type: "real",
                nullable: false,
                defaultValue: 0f);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Price",
                table: "CartItems");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a763a786-7821-4dc2-abe6-f5bac0be7083", null, "admin", "admin" },
                    { "b3a7609b-b317-4297-901b-20fba3a40863", null, "client", "client" },
                    { "b7f9e8f1-0b51-4bcb-a0bb-303f75713b1d", null, "seller", "seller" }
                });
        }
    }
}
