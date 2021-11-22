using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokemonGolotEF.Migrations
{
    public partial class Pokemonlevelsimplementationfix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pokemon_level",
                columns: table => new
                {
                    pokemon_level = table.Column<float>(type: "real", nullable: false),
                    pc_multiplier = table.Column<double>(type: "double precision", nullable: false),
                    stardust_to_upgrade = table.Column<int>(type: "integer", nullable: false),
                    candy_to_upgrade = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemon_level", x => x.pokemon_level);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pokemon_level");
        }
    }
}
