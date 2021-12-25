using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonGolotEF.Migrations
{
    public partial class pokemonlevelloaddatafixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Pokemon_level",
                columns: new[] { "pokemon_level", "candy_to_upgrade", "cp_multiplier", "stardust_to_upgrade" },
                values: new object[,]
                {
                    { 39.5f, 15, 0.78747358000000001, 10000 },
                    { 40f, 0, 0.79030001000000005, 10000 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 39.5f);

            migrationBuilder.DeleteData(
                table: "Pokemon_level",
                keyColumn: "pokemon_level",
                keyValue: 40f);
        }
    }
}
