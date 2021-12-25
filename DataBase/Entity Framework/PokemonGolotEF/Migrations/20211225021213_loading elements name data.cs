using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonGolotEF.Migrations
{
    public partial class loadingelementsnamedata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Element",
                columns: new[] { "name", "image" },
                values: new object[,]
                {
                    { "bug", null },
                    { "dark", null },
                    { "dragon", null },
                    { "electric", null },
                    { "fairy", null },
                    { "fighting", null },
                    { "fire", null },
                    { "flying", null },
                    { "ghost", null },
                    { "grass", null },
                    { "ground", null },
                    { "ice", null },
                    { "normal", null },
                    { "poison", null },
                    { "psychic", null },
                    { "rock", null },
                    { "shadow", null },
                    { "steel", null },
                    { "unknown", null },
                    { "water", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Element",
                keyColumn: "name",
                keyValue: "bug");

            migrationBuilder.DeleteData(
                table: "Element",
                keyColumn: "name",
                keyValue: "dark");

            migrationBuilder.DeleteData(
                table: "Element",
                keyColumn: "name",
                keyValue: "dragon");

            migrationBuilder.DeleteData(
                table: "Element",
                keyColumn: "name",
                keyValue: "electric");

            migrationBuilder.DeleteData(
                table: "Element",
                keyColumn: "name",
                keyValue: "fairy");

            migrationBuilder.DeleteData(
                table: "Element",
                keyColumn: "name",
                keyValue: "fighting");

            migrationBuilder.DeleteData(
                table: "Element",
                keyColumn: "name",
                keyValue: "fire");

            migrationBuilder.DeleteData(
                table: "Element",
                keyColumn: "name",
                keyValue: "flying");

            migrationBuilder.DeleteData(
                table: "Element",
                keyColumn: "name",
                keyValue: "ghost");

            migrationBuilder.DeleteData(
                table: "Element",
                keyColumn: "name",
                keyValue: "grass");

            migrationBuilder.DeleteData(
                table: "Element",
                keyColumn: "name",
                keyValue: "ground");

            migrationBuilder.DeleteData(
                table: "Element",
                keyColumn: "name",
                keyValue: "ice");

            migrationBuilder.DeleteData(
                table: "Element",
                keyColumn: "name",
                keyValue: "normal");

            migrationBuilder.DeleteData(
                table: "Element",
                keyColumn: "name",
                keyValue: "poison");

            migrationBuilder.DeleteData(
                table: "Element",
                keyColumn: "name",
                keyValue: "psychic");

            migrationBuilder.DeleteData(
                table: "Element",
                keyColumn: "name",
                keyValue: "rock");

            migrationBuilder.DeleteData(
                table: "Element",
                keyColumn: "name",
                keyValue: "shadow");

            migrationBuilder.DeleteData(
                table: "Element",
                keyColumn: "name",
                keyValue: "steel");

            migrationBuilder.DeleteData(
                table: "Element",
                keyColumn: "name",
                keyValue: "unknown");

            migrationBuilder.DeleteData(
                table: "Element",
                keyColumn: "name",
                keyValue: "water");
        }
    }
}
