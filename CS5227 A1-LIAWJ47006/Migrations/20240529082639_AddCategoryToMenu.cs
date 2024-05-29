using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CS5227_A1_LIAWJ47006.Migrations
{
    /// <inheritdoc />
    public partial class AddCategoryToMenu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5c893a6c-4f7e-4ec7-84bc-426b2bc78f4b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "657558d5-4c06-4306-b751-e1805e0c23b1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f53d4820-cbc9-4fe9-ad90-e255eadad3e5");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Menus",
                type: "nvarchar(max)",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Category",
                table: "Menus");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5c893a6c-4f7e-4ec7-84bc-426b2bc78f4b", null, "admin", "admin" },
                    { "657558d5-4c06-4306-b751-e1805e0c23b1", null, "client", "client" },
                    { "f53d4820-cbc9-4fe9-ad90-e255eadad3e5", null, "seller", "seller" }
                });
        }
    }
}
