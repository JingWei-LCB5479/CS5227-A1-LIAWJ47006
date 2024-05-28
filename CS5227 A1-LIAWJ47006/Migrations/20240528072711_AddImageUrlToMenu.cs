using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CS5227_A1_LIAWJ47006.Migrations
{
    /// <inheritdoc />
    public partial class AddImageUrlToMenu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Menus",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "14e4db49-9103-4a84-8cd3-c26655043b0b", null, "admin", "admin" },
                    { "2973388c-0e4e-4fa2-90fb-25d7cd82a78b", null, "client", "client" },
                    { "36194476-8e34-4a46-8e63-4de3633808bd", null, "seller", "seller" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "14e4db49-9103-4a84-8cd3-c26655043b0b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2973388c-0e4e-4fa2-90fb-25d7cd82a78b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36194476-8e34-4a46-8e63-4de3633808bd");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Menus");

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
    }
}
